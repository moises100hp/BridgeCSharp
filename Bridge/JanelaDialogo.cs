using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class JanelaDialogo : JanelaAbstrata
    {
        public JanelaDialogo(IJanelaBridge janela) : base(janela) { }
        public override void Desenhar()
        {
            DesenharJanela("Atenção! Deseja encerrar sem salvar ?");
            DesenharBotao("Sim");
            DesenharBotao("Não");
        }
    }
}
