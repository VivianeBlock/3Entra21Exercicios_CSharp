using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Comportamento
    {

        public static double Comer(double kilos) // recebe a diferença de kilos
        {
            kilos *= 250;

            return kilos;
        }

        public static double Descansar(int horas) // recebe a diferença de horas
        {
            horas *= 100;

            return horas;
        }


        public static double Trabalhar(int horas) // recebe as horas de trabalho
        {
            double ganho = 0.0; // não uso a mesma variavel por ser int.
            ganho = horas * 24.52;
            
            return ganho;
        }


    }
}
