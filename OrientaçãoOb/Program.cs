using OrientaçãoOb;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            carro[] lista = new carro[]
            {
                new carro("123ABC", "XYZ-9876", "Vermelho", "Elétrico"),
                new carro("456DEF", "ABC-1234", "Azul", "V6"),
                new carro("789GHI", "DEF-5678", "Preto", "1.6 THP   "),
                new carro("101JKL", "GHI","Branco", "2.0 Turbo"),
                new carro("112MNO", "JKL-9101", "Prata", "V8 EcoTec3"),
                new carro("131PQR", "MNO-1121", "Cinza", "Hibrido"),
                new carro("415STU", "PQR-3141", "Verde", "QX50"),
                new carro("161VWX", "STU-5161", "Amarelo", "V6"),
                new carro("718YZA", "VWX-7181", "Laranja", "1.0 TI-VCT"),
                new carro("192BCD", "YZA-9202", "Roxo", "F-150")
            };
            foreach (var carro in lista)
            {
                Console.WriteLine($"Chassis: {carro.Chassis}, License Plate: {carro.LicensePlate}, Color: {carro.Cor}, Engine: {carro.Motor}");
            }
            /* 

            CarroEx carroEx = new CarroEx();

            carroEx.placa = "EER2356";
            carroEx.chassi = "123456789";
            carroEx.EntraPessoa(2);
            carroEx.ligarMotor();


            Moto moto = new Moto();
            moto.placa = "MOTO123";
            moto.chassi = "987654321";
            moto.EntraPessoa(2);
            moto.ligarMotor();

            Veiculo[] veiculos = new Veiculo[2];
            veiculos[0] = carroEx;
            veiculos[1] = moto; 
            */
        }
    }
}