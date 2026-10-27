# Padrão Bridge

Este repositório é um projeto de estudo que demonstra o padrão de projeto
estrutural **Bridge** (Ponte) em C#. O exemplo separa o tipo de janela que a
aplicação deseja exibir da plataforma responsável por desenhá-la.

## Para que serve o Bridge?

O Bridge desacopla uma abstração de sua implementação, permitindo que ambas
variem independentemente. Neste projeto existem duas dimensões:

- **Abstração:** o tipo de janela, representado por `JanelaAbstrata` e sua
  especialização `JanelaDialogo`.
- **Implementação:** os comandos de desenho específicos de cada plataforma,
  definidos pelo contrato `IJanelaBridge` e implementados em `JanelaWindows`
  e `JanelaLinux`.

Assim, o diálogo não precisa conhecer os detalhes de desenho de Windows ou
Linux. Ele delega essas operações para a implementação recebida.

## Estrutura do exemplo

| Arquivo | Papel no padrão |
| --- | --- |
| `Bridge/IJanelaBridge.cs` | Define o contrato de implementação: desenhar uma janela e um botão. |
| `Bridge/JanelaAbstrata.cs` | Abstração que mantém uma referência a `IJanelaBridge` e delega a ela as operações de desenho. |
| `Bridge/JanelaDialogo.cs` | Abstração refinada que compõe um diálogo de confirmação com título e botões. |
| `Bridge/JanelaWindows.cs` | Implementação concreta que representa o desenho no Windows. |
| `Bridge/JanelaLinux.cs` | Implementação concreta que representa o desenho no Linux. |
| `Bridge/Program.cs` | Cria o mesmo diálogo com implementações diferentes. |

## Como o exemplo funciona

O programa instancia `JanelaDialogo` duas vezes, passando uma implementação
diferente em cada caso:

```csharp
JanelaAbstrata janela = new JanelaDialogo(new JanelaWindows());
janela.Desenhar();

janela = new JanelaDialogo(new JanelaLinux());
janela.Desenhar();
```

`JanelaDialogo.Desenhar()` define o conteúdo do diálogo — a pergunta e os
botões “Sim” e “Não”. As chamadas de desenho são encaminhadas pela classe
`JanelaAbstrata` para o objeto recebido pelo construtor. Por isso, a estrutura
do diálogo permanece a mesma enquanto a saída varia de acordo com a plataforma.

As implementações deste projeto são demonstrativas: elas escrevem no console,
em vez de desenhar uma interface gráfica real.

## Executar

É necessário ter o .NET 8 SDK instalado. Na raiz do repositório, execute:

```bash
dotnet run --project Bridge/Bridge.csproj
```

O programa imprime no console as operações de desenho para Windows e, em
seguida, Linux.

## Experimentar

- Crie outra classe que implemente `IJanelaBridge` para representar uma nova
  plataforma, sem alterar `JanelaDialogo`.
- Crie outra especialização de `JanelaAbstrata` para representar outro tipo de
  janela, reutilizando as implementações de plataforma existentes.

Essas variações ilustram o objetivo do padrão: evitar uma hierarquia de classes
para cada combinação de tipo de janela e plataforma.
