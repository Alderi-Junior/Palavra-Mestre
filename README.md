📚 Palavra Mestre - Documentação
By Bocha e Japa

🎯 Apresentação
O Palavra Mestre é um projeto que constrói um Autômato Finito Determinístico (AFD) a partir de palavras inseridas pelo usuário. Ele permite:

Registrar palavras para construir o AFD

Testar se novas palavras são aceitas pelo autômato

Visualizar a tabela de transições de estados

Mostrar o caminho percorrido por uma palavra no AFD

Desenvolvido em .NET MAUI, ele é multiplataforma, mas otimizado para Windows com interface intuitiva e visualização em chips/tags das palavras registradas.

⌨️ Entradas Aceitas
O projeto aceita:
✅ Palavras compostas por:

Letras minúsculas (a-z)

Sem caracteres especiais, números ou espaços

❌ Palavras inválidas:

Vazias

Com símbolos não permitidos (ex: ç, @, 1)

📝 Como Usar (Passo a Passo)
1. Construir o AFD
Passo 1: Digite uma palavra no campo "Digite uma nova palavra para construir o AFD"

Exemplo: abacaxi

Passo 2: Clique em "✨ Construir AFD ✨"

A palavra será adicionada como um chip na seção "Palavras Registradas"

A tabela de transições será atualizada automaticamente

2. Testar uma Palavra no AFD
Passo 1: Digite uma palavra no campo "Verifique se uma palavra é aceita pelo AFD"

Exemplo: aba

Passo 2: Clique em "✅ Testar Palavra"

O sistema dirá se a palavra é aceita ou rejeitada

Passo 3 (Opcional): Clique em "🔍 Mostrar Caminho" para ver o passo a passo no AFD

3. Limpar o AFD
Passo 1: Clique em "🗑️ Limpar AFD"

Todas as palavras e transições serão resetadas

4. Remover uma Palavra Específica
Passo 1: Localize a palavra na lista de chips

Passo 2: Clique no ❌ ao lado da palavra

Ela será removida do AFD e a tabela será atualizada

⚙️ Funções de Cada Etapa
Botão/Função	O que Faz
✨ Construir AFD ✨	Adiciona a palavra ao AFD e atualiza a tabela de transições
✅ Testar Palavra	Verifica se a palavra é aceita pelo autômato
🔍 Mostrar Caminho	Exibe o caminho percorrido no AFD (quais estados foram visitados)
🗑️ Limpar AFD	Reseta completamente o autômato (remove todas as palavras)
❌ (Botão de Remoção)	Remove uma palavra específica do AFD
📦 Compilação e Distribuição
Para gerar um executável único (.exe), execute:


dotnet publish -f net8.0-windows10.0.19041.0 -c Release -p:PublishSingleFile=true --self-contained true
O arquivo estará em:


bin\Release\net8.0-windows10.0.19041.0\win-x64\publish\Palavra_Mestre.exe

🎨 Interface Interativa e Amigável
O Palavra Mestre foi projetado com uma abordagem lúdica e educacional, inspirada em softwares infantis, para demonstrar domínio do .NET MAUI e criar uma experiência mais envolvente.

✨ Características da Interface
Elemento	Descrição	Objetivo
Chips Coloridos	Palavras são exibidas como tags estilo "cápsulas" (ex: 🍍 abacaxi)	Facilitar a visualização e remoção
Cores Vibrantes	Tons pastéis e contrastes suaves (laranja, amarelo, verde)	Chamar atenção sem poluir a tela
Ícones Expressivos	Emojis e símbolos (🎉, ❌, ✅) para ações	Tornar o uso intuitivo
Animações Suaves	Efeitos de confete ao aceitar palavras e fade-in/fade-out nos chips	Dar feedback visual
Fontes Brincalhonas	Uso de Comic Sans MS em labels e botões	Simular um software infantil
Layout Organizado	Agrupamento lógico (AFD Builder × Testador) com espaçamento generoso	Evitar poluição visual
🎮 Interatividade
Toque nos Chips: Efeito de "apertar" ao clicar em uma palavra

Feedback Imediato:

Palavra aceita → Animação de confete + mensagem verde

Palavra rejeitada → Balão vermelho com explicação

Tabela de Transições clicável:

Células destacam-se ao passar o mouse (simulando um jogo de tabuleiro)

📚 Inspiração Educacional
Metáfora de "Construir um Robô":

Cada palavra adicionada "monta" o autômato como peças de Lego

Modo "Passo a Passo":

Ao clicar em "🔍 Mostrar Caminho", o sistema pisca os estados visitados como um jogo de adivinhação

💡 Por que esse design?
Apesar de ser um projeto técnico (AFD), a interface abstrai a complexidade usando elementos familiares a crianças, demonstrando como o MAUI pode adaptar-se a diferentes públicos mantendo a funcionalidade.

Exemplo de Uso com Crianças (Fictício):

"Vamos ensinar o robô a reconhecer frutas! Digite 'banana'..."

"Agora teste 'bana'... Ops! Falta uma letra. O robô não entendeu!"

(Obs.: O projeto não é realmente infantil, mas a interface simula essa abordagem para fins didáticos.)

Próximos Passos (Se Desejado):

Adicionar sons de feedback (ex.: aplausos ao acertar)

Incluir um modo história com personagens guias

Implementar badges/recompensas por palavras aprendidas

Essa escolha de design mostra flexibilidade do MAUI para criar desde apps sérios até experiências imersivas! 🧩

🎨 Preview da Interface
![image](https://github.com/user-attachments/assets/c46db2f3-718b-45d1-8284-d859b2b3258a)


📌 Observações Finais
Desenvolvido em .NET MAUI

Otimizado para Windows (abre em tela cheia automaticamente)

Código aberto, podendo ser estendido para outras funcionalidades


👥 Autores

<img src="https://avatars.githubusercontent.com/u/72262704?s=400&u=44ab8fa5f402e33e0159c1b7848c3ffb72a5a5fe&v=4" width="80" />
[Alderi](https://github.com/Alderi-Junior)

<img src="https://avatars.githubusercontent.com/u/149211310?v=4" width="80" />
[Otavio](https://github.com/otaviojapa)
