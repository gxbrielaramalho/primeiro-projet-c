using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projet_c_sharpe.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public int Ano { get; set; }

        public void apresentar()
        { 
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Nasci no ano de {Ano}.");
            }
    }
}