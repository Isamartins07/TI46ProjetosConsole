using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, nota4, resultado;
            Console.WriteLine("Escreva seu nome");
            nome= Console.ReadLine();
            Console.WriteLine("Seja bem vindo "+nome);

            Console.WriteLine("Digite as notas do aluno ");
           
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            nota4 = double.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A média das notas é: " + resultado);
           


            Console.ReadKey();

        }
    }
}
