using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private Guerreiros guerreiros;
        private ColetaRecursos recursos;
        private Armamento armamento;

        public Facade()
        {
            this.armamento = new Armamento();
            this.recursos = new ColetaRecursos();
            this.guerreiros = new Guerreiros();
        }

        public void CriarArmamento()
        {
            Console.WriteLine("Operação Criar Armamento");
            this.recursos.Respondabilidade();
            this.armamento.Responsabilidade();
        }

        public void TreinarGuerreiros()
        {
            Console.WriteLine("Operação treinar guerreiros");
            this.guerreiros.Responsabilidade();
        }
    }
}
