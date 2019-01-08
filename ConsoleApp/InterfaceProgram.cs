using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IConta
    {
         void depositar(double valor);
         void sacar(double valor);
         double getSaldo();
         void setTipoConta(string valor);
         string getTipoConta();
    }

    public class ContaPoupancaIntarface : IConta
    {
        private double saldo;
        private string tpConta;

        void IConta.depositar(double valor)
        {
            this.saldo += valor;
        }

        double IConta.getSaldo()
        {
            return this.saldo;
        }

        void IConta.sacar(double valor)
        {
            this.saldo -= valor;
        }

        void IConta.setTipoConta(string valor)
        {
            if (valor.Equals("CC")) { tpConta = "Conta Corrente"; } else { tpConta = "Conta Poupança"; }
        }

        string IConta.getTipoConta()
        {
           return tpConta; 
        }
    }

    public class GerarExtrato
    {

        public void gerarConta(IConta conta)
        {
            Console.WriteLine(conta.getTipoConta() + " - Saldo Atual: " + conta.getSaldo());
        }

    }



}


