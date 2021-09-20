using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Habitacao : Endereco
    {
        public string Tipo { get; set; }
        public string NomeDoDono { get; set; }
    }
}
