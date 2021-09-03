using System;
using System.Threading;

namespace TernoVermelho.Contador
{
    class Program
    {
        ModeloDePontuaçãoPorRodada modelo = new ModeloDePontuaçãoPorRodada();

        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Seja Bem Vindo ao Contador de Terno Vermelho");
            Console.WriteLine("==================================================");
            Thread.Sleep(2000);

            Console.WriteLine("Desenvolvido e Pensado Por Uanderson");
            Thread.Sleep(3000);

            Console.WriteLine("==============Bom Game============================");
            Thread.Sleep(2000);


            Console.ReadKey();
        }
    }
}
