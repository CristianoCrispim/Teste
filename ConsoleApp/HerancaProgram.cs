using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    public class Pai

    {
        public string Nome = "Cristiano";
        public int Idade = 40;
    }


    public class Filha : Pai

    {

        public string Nome = "Alana Cristina";
        public int Idade = 11;

        public void Inf()
        {
            Console.Write("Filha -> Nome: " + this.Nome);
            Console.WriteLine(" - Idade: " + this.Idade);
            Console.Write("Pai -> Nome: " + base.Nome);
            Console.WriteLine(" - Idade: " + base.Idade);
        }

    }





}
