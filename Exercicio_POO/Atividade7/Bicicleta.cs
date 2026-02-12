using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Bicicleta : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("A bicicleta está sendo pedalada.");
        }
    }
}