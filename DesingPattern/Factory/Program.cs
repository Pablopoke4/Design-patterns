using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.Write("Voce vai jogar com ");
            personagem.Escolhido();
            personagem.Atacar();

            Console.ReadKey();
        }
    }
}
