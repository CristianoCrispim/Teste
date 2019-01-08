using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    public abstract class  DT {

        private double preco;
        public void Custo(double valor)
        {
            this.preco += valor;
        }


        public void Validade(int valor)
        {
            this.preco -= valor;
        }

        
        protected double getPreco()
        {
            return preco;
        }

        public abstract void FormulaMagica();

    }

    public class HiperMercado : DT
    {

        public override void FormulaMagica()
        {
            Console.WriteLine("Preço: " + this.getPreco());
        }
    }

}
