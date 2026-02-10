using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Pessoas
    {
        public string Nomes = "";
        public int Idades;

        public void ExibirDados()
        {
            System.Console.WriteLine($"minha idade é {Idades}");
            System.Console.WriteLine($"Mu nome é {Nomes}");

        }
    }
}