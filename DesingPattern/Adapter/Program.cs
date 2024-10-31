using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem player = new Personagem();
            Console.WriteLine("Começou o jogo");
            player.Andar("Pablo");
            player.Atirar();

            Aviao aviao_batalha = new Aviao();
            IAcao adaptador = new AdapterAviao(aviao_batalha);

            Console.WriteLine("Pegou um avião de combate!");
            adaptador.Andar("Pablo");
            adaptador.Atirar();

            Console.ReadKey();
        }
    }
}
