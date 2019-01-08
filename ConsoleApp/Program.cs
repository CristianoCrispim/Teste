using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- EX. INTERFACE -------------------------");

            IConta cc = new ContaPoupancaIntarface();
            cc.depositar(800.80);
            cc.sacar(380);
            cc.setTipoConta("CC");

            IConta cp = new ContaPoupancaIntarface();
            cp.depositar(444.44);
            cp.sacar(25.44);
            cp.setTipoConta("CP");
            

            GerarExtrato gerador = new GerarExtrato();
            gerador.gerarConta(cc);
            gerador.gerarConta(cp);

            Console.WriteLine("----------------- EX. ABSTRACT -------------------------");

            Conta ct = new ContaPoupanca();
            ct.depositar(252.26);
            ct.sacar(52.23);
            ct.setTipoConta("CC");

            ct.imprimeExtrato();

            Conta ct2 = new ContaPoupanca();
            ct2.depositar(52.26);
            ct2.sacar(2.23);
            ct2.setTipoConta("CP");

            ct2.imprimeExtrato();

            Console.WriteLine("----------------- EX. HERANÇA -------------------------");

            Filha filha = new Filha();
            filha.Inf();

            Console.WriteLine("----------------- EX. DELEGATE -------------------------");
            int n1 = 25;
            int n2 = 5;
            DelegateProgram dp = new DelegateProgram();
            Calcular so = new Calcular(dp.Somar);
            Calcular d = new Calcular(dp.Dividir);
            Calcular su = new Calcular(dp.Subtrair);
            Calcular m = new Calcular(dp.Multiplicar);
            Console.WriteLine("Soma por Delegate: "+ so(n1, n2));
            Console.WriteLine("Dividir por Delegate: " + d(n1, n2));
            Console.WriteLine("Subtrair por Delegate: " + su(n1, n2));
            Console.WriteLine("Multiplicar por Delegate: " + m(n1, n2));


            Console.WriteLine("----------------- EX. HIPERMERCADO -------------------------");
            double custo = 5.00;
            int validade = 2;
            DT dt = new HiperMercado();
            dt.Custo(custo);
            dt.Validade(validade);
            dt.FormulaMagica();


            Console.WriteLine("----------------- EX. CANDIDATO  -------------------------");

            Dictionary<int, Casa> eleitores = new Dictionary<int, Casa>();
            eleitores.Add(1, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 11" }, numero = 1, totalEleitores = 2 });
            eleitores.Add(2, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 12" }, numero = 2, totalEleitores = 6 });
            eleitores.Add(3, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 21" }, numero = 1, totalEleitores = 11});
            eleitores.Add(4, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 31" }, numero = 1, totalEleitores = 76});
            eleitores.Add(5, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 32" }, numero = 2, totalEleitores = 8 });
            eleitores.Add(6, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 41" }, numero = 1, totalEleitores = 45});
            eleitores.Add(7, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 42" }, numero = 2, totalEleitores = 22});
            eleitores.Add(8, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 43" }, numero = 3, totalEleitores = 32});
            eleitores.Add(9, new Casa() { rua = new Rua { cep = "72520-520", nome = "rua 51" }, numero = 1, totalEleitores = 52});
            eleitores.Add(10, new Casa() { rua = new Rua { cep ="72520-520", nome = "rua 52" }, numero = 2, totalEleitores = 9 });

            CandidatoProgram cdt = new CandidatoProgram();
            List<Casa> listCasa = new List<Casa>();
            foreach (var c in eleitores) {
                listCasa.Add(c.Value);
            }

            List<Rua> listRua = new List<Rua>();
            listRua = cdt.listaRuas(listCasa);

            foreach (var r in listRua)
            {
                Console.WriteLine(r.nome);
            }

        }
    }
}
