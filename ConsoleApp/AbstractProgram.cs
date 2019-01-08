using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    public abstract class Conta
    {

        private double saldo;
        private string tpConta;

        public void depositar(double valor)
        {
            this.saldo += valor;
        }


        public void sacar(double valor)
        {
            this.saldo -= valor;
        }

                
        public double getSaldo()
        {
            return saldo;
        }

        public void setTipoConta(string valor)
        {
            if (valor.Equals("CC")) { tpConta = "Conta Corrente"; } else { tpConta = "Conta Poupança"; }
        }

        public string getTipoConta()
        {
            return tpConta;
        }

        public abstract void imprimeExtrato();

    }

    public class ContaPoupanca : Conta
    {
        
        public override void imprimeExtrato()
        {

            Console.WriteLine(this.getTipoConta() + " - Saldo Atual: " + this.getSaldo());

        }
    }

}
