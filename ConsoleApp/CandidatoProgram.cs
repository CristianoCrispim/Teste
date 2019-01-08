using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CandidatoProgram
    {
        public List<Rua> listaRuas(List<Casa> casas) {

            List<Rua> lr = casas.OrderByDescending(o=>o.totalEleitores).Select(s => s.rua).ToList();
            return lr;
        }



    }
    public class Casa
    {
        public Rua rua;
        public int numero;
        public int totalEleitores;
    }
    public class Rua
    {
        public String cep;
        public String nome;
    }
}
