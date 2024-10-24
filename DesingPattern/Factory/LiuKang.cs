using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class LiuKang : PersonagemBase
    {
        public override void Escolhido()
        {
            
            Console.WriteLine(GetName());
        }

        public override void Atacar()
        {
            Console.WriteLine("Ataque" + GetName());
        }

      
    }
}
