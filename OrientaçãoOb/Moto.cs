using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoOb
{
    internal class Moto : CarroEx
    {
        public new void EntraPessoa(int pessoa)
        {
            lugaresOcupados += pessoa;
            if (pessoa > 2)
            {
                Console.WriteLine("Moto só pode levar 2 pessoas!");
            }
            
        }
    }
}
