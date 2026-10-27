using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaBridge janela;

        public JanelaAbstrata(IJanelaBridge j)
        {
            janela = j;
        }

        public void DesenharJanela(string titulo)
        {
            Console.WriteLine("Desenhando janela...");
            janela.DesenharJanela(titulo);
        }

        public void DesenharBotao(string texto)
        {
            janela.DesenharBotao(texto);
        }

        public abstract void Desenhar();
    }
}
