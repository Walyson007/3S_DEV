using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        // Construtor
        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }
    }

}