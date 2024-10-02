using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //CTRL+K e Ctrl+C deixa em comentário



            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("0 - Programa média notas");
            Console.WriteLine("1 - Declaração de Varíaveis");
            Console.WriteLine("2 - Exercício área do círculo");
            Console.WriteLine("3 - Média de três números");
            Console.WriteLine("4 - Prioridade dos operadores");
            Console.WriteLine("5 - Cálculo de desconto");
            Console.WriteLine("6- Convesão de Temperaturas");


            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {


                case 0:
                    Exercicio00();
                    break;


                case 1:
                    Exercicio01();
                    break;

                case 2:
                    Exercicio02();
                    break;

                case 3:
                    Exercicio03();
                    break;

                case 4:
                    Exercicio04();
                    break;


                case 5:
                    Exercicio05();
                    break;

                case 6:
                    Exercicio06();
                    break;





                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

        }

        private static void Exercicio06()
        {
            throw new NotImplementedException();




        }

        private static void Exercicio05()
        {
            double p = 0.10, desconto, valor, resultado;
            Console.WriteLine("Digite o valor que terá 10% de deconto: ");
            valor = double.Parse(Console.ReadLine());

            desconto = valor * p;
            resultado = valor - desconto;
            Console.WriteLine("O desconto final é de R$: " + resultado);

            Console.ReadKey();

        }

        private static void Exercicio01()
        {
            int idade = 15;
            string nome = "Isa";
            double pi = 3.14;




        }

        private static void Exercicio04()
        {
            double v1, v2, v3, resultado;

            v1 = 2 + (3 * 42);
            v2 = (1-5)*2+(3 * 42);
            v3 = 1 - 5;
            resultado = v1 / v2 / v3;

            Console.WriteLine("O resultado é: "+resultado);
            


            Console.ReadKey();
        }

      

        private static void Exercicio03()
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digite 3 números inteiros: \n");
            n1 =double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3= double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média entre os números é: "+media);

            Console.ReadKey();

        }



        private static void Exercicio02()
        {
          
            double  raio;
            double PI = 3.14159;

            Console.WriteLine("Escreva o valor do raio: ");

           raio =double.Parse(Console.ReadLine());

            double area = PI * (raio * raio);

            Console.WriteLine("A área do círculo é de: "+area);

            Console.ReadKey();

        }


        private static void Exercicio00()
        {
            string nome;
            double nota1, nota2, nota3, nota4, resultado;
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo " + nome);

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

