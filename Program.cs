using System;

namespace ExemploEvento1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10, "1121211222");
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(chamar_uber);
            carro.Ligar();
        }

        static void tanque_vazio(){
            Console.WriteLine("Tanque vazio");
        }

        static void chamar_uber(){
            Console.WriteLine("Chamar Uber");
        }

        

    }
}
