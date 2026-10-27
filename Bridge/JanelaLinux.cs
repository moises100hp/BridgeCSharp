using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class JanelaLinux : IJanelaBridge
    {
        public void DesenharJanela(string titulo)
        {
            // simple implementation — replace with your real UI drawing logic
            Console.WriteLine($"Desenhar janela no Linux: {titulo}");
        }
        public void DesenharBotao(string texto)
        {
            // simple implementation — replace with your real UI drawing logic
            Console.WriteLine($"Desenhar botão no Linux: {texto}");
        }
    }
}
