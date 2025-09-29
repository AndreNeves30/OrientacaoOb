using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoOb
{
    internal class CarroEx : Veiculo
    {
        internal int lugaresOcupados;
        public string tipoCarroceria;

        public int Ocupacao()
            {
            return lugaresOcupados;
        }

        public void EntraPessoa(int pessoa) 
        {
            lugaresOcupados += pessoa;
            if (lugaresOcupados > 5) 
            {
                Console.WriteLine("lotado");
            }
        }
    }
}
