using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoOb
{
    internal class carro
    {
        public string Chassis { get; set; }
        public string LicensePlate { get; set; }
        public string Cor { get; set; }
        public string Motor { get; set; }
        public carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }
    }
}
