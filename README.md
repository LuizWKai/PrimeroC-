# EditorHtml

EditorHtml é um editor de texto simples em C# para terminal, com funcionalidades de criar, abrir e deletar arquivos.

## Funcionalidades

- Criar novo arquivo de texto
- Abrir arquivo existente no Notepad
- Deletar arquivo
- Interface de menu no terminal

## Como executar

1. Certifique-se de ter o [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) instalado.
2. Clone este repositório ou baixe os arquivos.
3. No terminal, navegue até a pasta do projeto e execute:

```sh
dotnet run
```

## Estrutura do Projeto

- [`Program.cs`](Program.cs): Ponto de entrada do programa.
- [`Menu.cs`](Menu.cs): Interface do menu e opções.
- [`Chosen.cs`](Chosen.cs): Lógica para escolha do usuário.
- [`HandleFile.cs`](HandleFile.cs): Manipulação de arquivos (criar, abrir, deletar).
