using System;
using System.Collections.Generic;
using System.Linq;

namespace PalavraMestre.Core
{
    public class AfdEngine
    {
        public List<string> Nos { get; private set; } = new() { "s0" };
        public List<char> Simbolos { get; private set; } = Enumerable.Range(0, 26).Select(i => (char)('a' + i)).ToList();
        public Dictionary<string, Dictionary<char, string>> Rotas { get; private set; } = new();
        public string Origem { get; private set; } = "s0";
        public List<string> Finais { get; private set; } = new();

        public void Reiniciar()
        {
            Nos = new() { "s0" };
            Rotas.Clear();
            Finais.Clear();
        }

        public string ConstruirAFD(string palavra)
        {
            if (string.IsNullOrWhiteSpace(palavra))
                return "Insira uma palavra válida.";

            palavra = palavra.Trim().ToLower();
            string atual = Origem;
            int contadorEstado = Nos.Count;

            foreach (char c in palavra)
            {
                if (!Simbolos.Contains(c))
                    return $"Caractere '{c}' fora do alfabeto permitido (a-z).";

                if (!Rotas.ContainsKey(atual))
                    Rotas[atual] = new();

                if (!Rotas[atual].ContainsKey(c))
                {
                    string novoEstado = $"s{contadorEstado++}";
                    Nos.Add(novoEstado);
                    Rotas[atual][c] = novoEstado;
                }

                atual = Rotas[atual][c];
            }

            if (!Finais.Contains(atual))
                Finais.Add(atual);

            return "";
        }

        public (bool Aceita, string Mensagem) VerificarPalavra(string palavra)
        {
            if (string.IsNullOrWhiteSpace(palavra))
                return (false, "Insira uma palavra para verificar.");

            palavra = palavra.Trim().ToLower();
            string atual = Origem;

            foreach (char c in palavra)
            {
                if (!Simbolos.Contains(c))
                    return (false, $"Símbolo '{c}' não está no alfabeto permitido.");

                if (Rotas.ContainsKey(atual) && Rotas[atual].ContainsKey(c))
                    atual = Rotas[atual][c];
                else
                    return (false, "Palavra rejeitada: transição inválida.");
            }

            if (Finais.Contains(atual))
                return (true, "Palavra aceita!");
            else
                return (false, "Palavra rejeitada: não termina em estado final.");
        }

        public List<(string EstadoAtual, char Simbolo, string ProximoEstado)> CaminhoDaPalavra(string palavra)
        {
            List<(string, char, string)> caminho = new();
            if (string.IsNullOrWhiteSpace(palavra)) return caminho;

            palavra = palavra.Trim().ToLower();
            string atual = Origem;

            foreach (char c in palavra)
            {
                if (!Simbolos.Contains(c)) break;

                if (Rotas.ContainsKey(atual) && Rotas[atual].ContainsKey(c))
                {
                    string proximo = Rotas[atual][c];
                    caminho.Add((atual, c, proximo));
                    atual = proximo;
                }
                else
                {
                    caminho.Add((atual, c, "❌"));
                    break;
                }
            }

            return caminho;
        }
    }
}