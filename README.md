# 📚 Palavra Mestre - Documentação
**By Alderí e Otavio**

## 🎯 Apresentação
O **Palavra Mestre** é um projeto que constrói um **Autômato Finito Determinístico (AFD)** a partir de palavras inseridas pelo usuário. Ele permite:

- Registrar palavras para construir o AFD
- Testar se novas palavras são aceitas pelo autômato
- Visualizar a tabela de transições de estados
- Mostrar o caminho percorrido por uma palavra no AFD

Desenvolvido em **.NET MAUI**, ele é multiplataforma, mas otimizado para **Windows** com interface intuitiva e visualização em **chips/tags** das palavras registradas.

## ⌨️ Entradas Aceitas
O projeto aceita:

### ✅ Palavras válidas:
- Letras minúsculas (a-z)
- Sem caracteres especiais, números ou espaços

### ❌ Palavras inválidas:
- Vazias
- Com símbolos não permitidos (ex: ç, @, 1)

## 📝 Como Usar (Passo a Passo)

### 1. Construir o AFD
```plaintext
Passo 1: Digite uma palavra no campo "Digite uma nova palavra para construir o AFD"
Exemplo: abacaxi

Passo 2: Clique em "✨ Construir AFD ✨"
→ A palavra será adicionada como um chip na seção "Palavras Registradas"
→ A tabela de transições será atualizada automaticamente
```

### 2. Testar uma Palavra no AFD
```plaintext
Passo 1: Digite uma palavra no campo "Verifique se uma palavra é aceita pelo AFD"
Exemplo: aba

Passo 2: Clique em "✅ Testar Palavra"
→ O sistema dirá se a palavra é aceita ou rejeitada

Passo 3 (Opcional): Clique em "🔍 Mostrar Caminho" para ver o passo a passo no AFD
```

### 3. Limpar o AFD
```plaintext
Passo 1: Clique em "🗑️ Limpar AFD"
→ Todas as palavras e transições serão resetadas
```

### 4. Remover uma Palavra Específica
```plaintext
Passo 1: Localize a palavra na lista de chips
Passo 2: Clique no ❌ ao lado da palavra
→ Ela será removida do AFD e a tabela será atualizada
```

## ⚙️ Funções de Cada Etapa
| Botão/Função           | O que Faz                                               |
|------------------------|---------------------------------------------------------|
| ✨ Construir AFD ✨     | Adiciona a palavra ao AFD e atualiza a tabela           |
| ✅ Testar Palavra       | Verifica se a palavra é aceita pelo autômato            |
| 🔍 Mostrar Caminho     | Exibe o caminho percorrido no AFD                       |
| 🗑️ Limpar AFD          | Reseta completamente o autômato                         |
| ❌ (Remoção de Palavra) | Remove uma palavra específica do AFD                    |

## 📦 Compilação e Distribuição

Para gerar um executável único (.exe), execute:

```bash
dotnet publish -f net8.0-windows10.0.19041.0 -c Release -p:PublishSingleFile=true --self-contained true
```

O arquivo estará em:

```bash
bin\Release\net8.0-windows10.0.19041.0\win-x64\publish\Palavra_Mestre.exe
```

## 🎨 Interface Interativa e Amigável
O Palavra Mestre foi projetado com uma abordagem **lúdica e educacional**, inspirada em softwares infantis, para demonstrar domínio do .NET MAUI e criar uma experiência mais envolvente.

### ✨ Características da Interface
| Elemento           | Descrição                                                    | Objetivo                                      |
|--------------------|--------------------------------------------------------------|-----------------------------------------------|
| Chips Coloridos    | Palavras exibidas como "cápsulas" (ex: 🍍 abacaxi)            | Facilitar visualização e remoção              |
| Cores Vibrantes    | Tons pastéis e suaves (laranja, amarelo, verde)              | Chamar atenção sem poluir visualmente         |
| Ícones Expressivos | Emojis/símbolos para ações (🎉, ❌, ✅)                        | Tornar uso mais intuitivo                     |
| Animações Suaves   | Confete ao aceitar palavras, fade nos chips                  | Dar feedback visual                           |
| Fontes Brincalhonas| Uso de Comic Sans MS                                         | Simular software infantil                     |
| Layout Organizado  | AFD Builder × Testador com bom espaçamento                   | Evitar poluição visual                        |

## 🎮 Interatividade

- **Toque nos Chips:** efeito de "apertar" ao clicar
- **Feedback Imediato:**
  - Palavra aceita → Animação de confete + mensagem verde
  - Palavra rejeitada → Balão vermelho com explicação
- **Tabela de Transições Clicável:**
  - Células se destacam ao passar o mouse

## 📚 Inspiração Educacional

### Metáfora de "Construir um Robô":
Cada palavra adicionada "monta" o autômato como peças de Lego

### Modo "Passo a Passo":
O sistema pisca os estados visitados como um jogo de adivinhação

### Por que esse design?
Apesar de técnico, o projeto usa elementos familiares a crianças, mostrando como o MAUI pode ser flexível.

#### Exemplo de Uso com Crianças (Fictício):
> "Vamos ensinar o robô a reconhecer frutas! Digite 'banana'..."
> 
> "Agora teste 'bana'... Ops! Falta uma letra. O robô não entendeu!"

(Obs.: O projeto não é realmente infantil, apenas simula uma abordagem didática.)

### Próximos Passos (Ideias Futuras):
- Sons de feedback (aplausos, etc.)
- Modo história com personagens guias
- Badges/recompensas por palavras

## 🎨 Preview da Interface
![image](https://github.com/user-attachments/assets/c46db2f3-718b-45d1-8284-d859b2b3258a)

## 📌 Observações Finais
- Desenvolvido em **.NET MAUI**
- Otimizado para **Windows**
- Código aberto e extensível

## 👥 Autores

<img src="https://avatars.githubusercontent.com/u/72262704?s=400&u=44ab8fa5f402e33e0159c1b7848c3ffb72a5a5fe&v=4" width="80" />  
**[Alderi](https://github.com/Alderi-Junior)**

<img src="https://avatars.githubusercontent.com/u/149211310?v=4" width="80" />  
**[Otavio](https://github.com/otaviojapa)**
