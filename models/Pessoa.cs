using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projet_c_sharpe.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void apresentar()
        { 
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos.")
            }
    }
}