using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista01_19_09_2024
    {
        public void SeNúmeroPositivo()
        {
            int n;
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine("O número digitado é positivo!");

            }
            else
            {
                Console.WriteLine("O número é negativo");

            }
            Console.ReadKey();


        }




    }
}
