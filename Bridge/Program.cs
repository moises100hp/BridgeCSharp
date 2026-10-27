using Bridge;

JanelaAbstrata janela = new JanelaDialogo(new JanelaWindows());
janela.Desenhar();

janela = new JanelaDialogo(new JanelaLinux());
janela.Desenhar();

