using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoOb
{
    abstract class Veiculo
    {
        public String placa;
        public String chassi;
        public String cor;
        bool mortorLigado = false;

        public void ligarMotor()
        {
            mortorLigado = true;
            Console.WriteLine("Motor ligado!");
        }

        public void desligarMotor()
        {
            mortorLigado = false;
            Console.WriteLine("Motor desligado!");
        }
    }
}
