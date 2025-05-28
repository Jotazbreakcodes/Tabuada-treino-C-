using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite um número para  ver sua tabuada");
            int numero = int.Parse(Console.ReadLine());
            Tabuada(numero);

        }
        static void Tabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                int multiplicar = numero * i;

                Console.WriteLine($" {numero} x {i} = {multiplicar}");
                Thread.Sleep(1000);
            }

            Console.ReadLine();
            Menu();


        }
    }
}