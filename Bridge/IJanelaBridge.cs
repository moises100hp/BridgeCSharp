using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IJanelaBridge
    {
        void DesenharJanela(string titulo);
        void DesenharBotao(string texto);
    }
}
