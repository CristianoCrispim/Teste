using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    public delegate int Calcular(int value1, int value2);

    public class DelegateProgram
    {


        public int Somar(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Dividir(int value1, int value2)
        {
            return value1 / value2;
        }

        public int Subtrair(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiplicar(int value1, int value2)
        {
            return value1 * value2;
        }


    }
}
