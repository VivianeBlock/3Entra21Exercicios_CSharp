using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Empresa : Endereco
    {
        public string Nome { get; set; }
        public int Funcionarios { get; set; }
    }
}
