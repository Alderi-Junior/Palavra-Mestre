using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using PalavraMestre.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;


namespace PalavraMestre;

public partial class MainPage : ContentPage
{
    private AfdEngine afd = new();
    private List<string> historicoPalavras = new();
    private (int Row, int Col)? celulaSelecionada = null;
    private Dictionary<(int Row, int Col), Color> celulasComCor = new();
    private ObservableCollection<string> palavrasRegistradas = new();
    public MainPage()
    {
        InitializeComponent();
        //PalavrasListView.ItemsSource = palavrasRegistradas;
    }

    private void OnConstruirAfd(object sender, EventArgs e)
    {
        string entrada = InputText.Text?.ToLower().Trim() ?? "";
        string resultado = afd.ConstruirAFD(entrada);

        if (!string.IsNullOrEmpty(resultado))
        {
            OutputLabel.Text = resultado;
            return;
        }

        historicoPalavras.Add(entrada);
        if (!string.IsNullOrWhiteSpace(entrada) && !palavrasRegistradas.Contains(entrada))
        {
            palavrasRegistradas.Add(entrada);
        }

        InputText.Text = "";
        celulaSelecionada = null;
        DesenharTabela();
        OutputLabel.Text = "";
    }

    private void OnLimparAfd(object sender, EventArgs e)
    {
        afd.Reiniciar();
        historicoPalavras.Clear();
        OutputLabel.Text = "";
        VerificacaoOutput.Text = "";
        TabelaGrid.Children.Clear();
        TabelaGrid.RowDefinitions.Clear();
        TabelaGrid.ColumnDefinitions.Clear();
    }

    void DesenharTabela()
    {
        TabelaGrid.Children.Clear();
        TabelaGrid.RowDefinitions.Clear();
        TabelaGrid.ColumnDefinitions.Clear();

        int colCount = afd.Simbolos.Count + 1;
        int rowCount = afd.Nos.Count + 1;

        for (int i = 0; i < colCount; i++)
            TabelaGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = 35 });

        for (int i = 0; i < rowCount; i++)
            TabelaGrid.RowDefinitions.Add(new RowDefinition { Height = 30 });

        var header = new Label
        {
            Text = "Estados",
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.DarkBlue,
            FontFamily = "Courier New",
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center
        };
        TabelaGrid.Add(header, 0, 0);

        for (int i = 0; i < afd.Simbolos.Count; i++)
        {
            var letra = afd.Simbolos[i];
            var label = new Label
            {
                Text = letra.ToString(),
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.DarkBlue,
                FontFamily = "Courier New",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            TabelaGrid.Add(label, i + 1, 0);
        }

        for (int i = 0; i < afd.Nos.Count; i++)
        {
            string estado = afd.Nos[i];
            string labelEstado = estado == afd.Origem ? $"→{estado}" : estado;
            if (afd.Finais.Contains(estado)) labelEstado += "*";

            var estadoLabel = new Label
            {
                Text = labelEstado,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.DarkRed,
                FontFamily = "Courier New",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            TabelaGrid.Add(estadoLabel, 0, i + 1);

            for (int j = 0; j < afd.Simbolos.Count; j++)
            {
                char letra = afd.Simbolos[j];
                string destino = afd.Rotas.ContainsKey(estado) && afd.Rotas[estado].ContainsKey(letra)
                    ? afd.Rotas[estado][letra]
                    : "-";

                var labelCell = new Label
                {
                    Text = destino,
                    TextColor = Colors.DarkSlateGray,
                    FontFamily = "Courier New",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    BackgroundColor = Colors.LightYellow,
                };

                var tapGesture = new TapGestureRecognizer();
                int row = i + 1;
                int col = j + 1;

                tapGesture.Tapped += (s, e) =>
                {
                    celulaSelecionada = (row, col);
                    //AtualizarDestaques();
                };

                labelCell.GestureRecognizers.Add(tapGesture);
                TabelaGrid.Add(labelCell, col, row);
            }
        }

        //AtualizarDestaques();
    }


}