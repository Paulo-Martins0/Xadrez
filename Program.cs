using System;
using System.Globalization;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            

            for (int i = 0; i < 3; i++)
            {

                Console.Write("|*|");
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("|*|");


                }
                Console.WriteLine();
                
            }

            Console.WriteLine("Você escolhe X ou O ? ");
            Char escolha = Char.Parse(Console.ReadLine());

        }
    }
}