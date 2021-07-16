using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 6 atribuiçoes de variaveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 39;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();

        }
    }
}
