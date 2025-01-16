using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSmart
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("===== MENU =====\n");

            Console.WriteLine("1 - Verificar se o numero e par");
            Console.WriteLine("2 - Calculadora");
            Console.WriteLine("3 - Reajuste Salarial");
            Console.WriteLine("4 - Calcular IMC");
            Console.WriteLine("5 - Contar Vogais");
            Console.WriteLine("6 - Verificar aluno mais alto");
            Console.WriteLine("7 - Conta Corrente");
            Console.WriteLine("8 - Vetor de inteiros");
            Console.WriteLine("9 - Arquivo Funcionarios");
            Console.WriteLine("10 - Matriz 3x3");

            Console.WriteLine("\nInsira o numero da operacao que deseja executar:");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    verificarParOuImpar();
                    break;

                case 2: 
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine();
                    break;
                
                case 8:
                    Console.WriteLine();
                    break;

                case 9:
                    Console.WriteLine();
                    break;

                case 10:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Numero invalido.");
                    break;
            }

        }
        public static void verificarParOuImpar()
        {
            int a = 10;

            Console.WriteLine(a);
            
        }

        public static void calculadora()
        {

        }

        public static void reajusteSalarial()
        {

        }

        public static void calcularIMC()
        {

        }

        public static void contarVogais()
        {

        }

        public static void verificarAlturaAluno()
        {

        }

        public static void contaCorrente()
        {

        }

        public static void vetorInteiros()
        {

        }

        public static void arquivoCSVFuncionarios()
        {

        }

        public static void matriz()
        {

        }
    }
}
