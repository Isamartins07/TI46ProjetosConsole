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

            // Ctrl + K e Ctrl+D arruma o codigo selecionado.
            //CTRL+K e Ctrl+C deixa em comentário
            // Console.Clear();limpa a tela
            //Console.ReadKey(); dar pause no programa para a pessoa ler. congela a tela
            // menu com switch case


            string opcao;
            Lista01_19_09_2024 lista01_19_09_2024 = new Lista01_19_09_2024();



            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma operação:\n");
                Console.WriteLine("0 - Programa média notas \n");
                Console.WriteLine("1 - Declaração de Varíaveis \n");
                Console.WriteLine("2 - Exercício área do círculo \n");
                Console.WriteLine("3 - Média de três números \n");
                Console.WriteLine("4 - Prioridade dos operadores \n");
                Console.WriteLine("5 - Cálculo de desconto\n ");
                Console.WriteLine("6 - Convesão de Temperaturas\n");
                Console.WriteLine("Lista dia 19/09/2024\n");
                Console.WriteLine("7 - SE número positivo\n");
                Console.WriteLine("8 - SE aluno esta aprovado\n");
                Console.WriteLine("9 - SE maior de idade \n ");
                Console.WriteLine("10 - SE temperaura \n");
                Console.WriteLine("11 - Para contar de 1 a 10 \n");



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

                    case 7:
                        lista01_19_09_2024.SeNúmeroPositivo();
                        break;

                    case 8:
                        SeAlunoAprovado();
                        break;
                    case 9:
                        SeMaiorDeIdade();
                        break;
                    case 10:
                        SeTemperatura();
                        break;
                    case 11:
                        ParaContar();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                Console.WriteLine("Deseja continuar no programa (S/N)");
                opcao = Console.ReadLine().ToUpper(); // to upper serve para ele ler o que o usuário digita independente de estar maiúsculo ou minúsculo


            } while (opcao == "S");

        }

        private static void ParaContar()
        {
            int i;
            for(i=1; i<11; i++) 
            {
                Console.WriteLine(i + "\n");
            }


            Console.ReadKey();  
        }

        private static void SeTemperatura()
        {
            double temp;
            Console.WriteLine("Digite a temperatura atual:  ");
            temp = double.Parse(Console.ReadLine());

            if (temp < 15)
            {
                Console.WriteLine("A temperatura está fria!");


            }
            else
            {
                if (temp >= 15 && temp < 25) // && é "entre" e OU é  "||"
                {

                    Console.WriteLine("A temperatura está agradável!");
                }
                else
                {
                    Console.WriteLine("A temperatura está quente!");

                }


            }





            Console.ReadKey();
        }

        private static void SeMaiorDeIdade()
        {
            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");

            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }


            Console.ReadKey();
        }

        private static void SeAlunoAprovado()
        {
            int x;

            Console.WriteLine("Digite quantos acertos o aluno teve no teste (10 quetões): ");
            x = int.Parse(Console.ReadLine());

            if (x >= 7)
            {

                Console.WriteLine("Aluno esta aprovado!");

            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }
            Console.ReadKey();


        }





        private static void Exercicio06()
        {
            // F = (C * 9 / 5) + 32
            double c, conversão;
            Console.WriteLine("Vamos converter graus Celsius para Fahrenheit, digite a temperatura que esta em graus Celsius: ");
            c = double.Parse(Console.ReadLine());

            conversão = (c * 9 / 5) + 32;

            Console.WriteLine("Resultado em Fahrenheit: " + conversão);



            Console.ReadKey();

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
            //int idade = 15;
            //string nome = "Isa";
            //double pi = 3.14;




        }

        private static void Exercicio04()
        {
            double v1, v2, v3, resultado;

            v1 = 2 + (3 * 42);
            v2 = (1 - 5) * 2 + (3 * 42);
            v3 = 1 - 5;
            resultado = v1 / v2 / v3;

            Console.WriteLine("O resultado é: " + resultado);



            Console.ReadKey();
        }



        private static void Exercicio03()
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digite 3 números inteiros: \n");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média entre os números é: " + media);

            Console.ReadKey();

        }



        private static void Exercicio02()
        {

            double raio;
            double PI = 3.14159;

            Console.WriteLine("Escreva o valor do raio: ");

            raio = double.Parse(Console.ReadLine());

            double area = PI * (raio * raio);

            Console.WriteLine("A área do círculo é de: " + area);

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

