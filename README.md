🧠 PalavraMestre
Simulador visual de AFD (Autômato Finito Determinístico), criado com .NET MAUI. Permite criar e testar autômatos com base em palavras digitadas.

🚀 Funcionalidades
Construção dinâmica de AFDs a partir de palavras.

Verificação se uma palavra é aceita pelo autômato.

Exibição visual da tabela de transições com destaques.

Animação do caminho percorrido por uma palavra.

Lista interativa de palavras registradas.

🖥️ Como executar o projeto (versão Windows)
Esta versão já vem com todos os arquivos necessários. Não é necessário instalar o .NET nem bibliotecas adicionais.

✅ Passos:
Vá para o caminho \PalavraMestre\bin\Release\net8.0-windows10.0.19041.0/RELEASE(ela contém PalavraMestre.exe e várias outras DLLs).

Encontre o arquivo PalavraMestre.exe

Dê duplo clique no arquivo:

PalavraMestre.exe
O aplicativo será iniciado com a interface gráfica.

🛠️ Tecnologias utilizadas
.NET 8

.NET MAUI (Multi-platform App UI)

C#

📁 Estrutura original do projeto
bash
Copiar
Editar
PalavraMestre/
├── MainPage.xaml           # Interface visual
├── MainPage.xaml.cs        # Lógica da interface
├── Core/AfdEngine.cs       # Núcleo do simulador de AFD
├── App.xaml                # Configuração da aplicação
├── Platforms/              # Código específico para Windows/Android/etc.
├── PalavraMestre.csproj    # Arquivo de configuração do projeto MAUI
💡 Como o projeto funciona
Ao digitar uma palavra e clicar em Construir AFD, o app gera um autômato com transições baseadas na palavra.

As transições são adicionadas à tabela de forma visual.

Você pode verificar se outras palavras são aceitas com base nesse autômato.

O botão Mostrar Caminho anima o percurso do autômato para a palavra testada.

🧳 Exportação
O executável foi gerado com:

bash
Copiar
Editar
dotnet publish -f net8.0-windows10.0.19041.0 -c Release -p:WindowsAppSDKSelfContained=true -p:WindowsPackageType=None
Isso garante que o app funcione mesmo sem .NET instalado no PC de destino.

👥 Autores
Bocha 🧠

Japa 💡
