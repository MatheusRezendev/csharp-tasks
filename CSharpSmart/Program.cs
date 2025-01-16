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

            Console.WriteLine("\nInsira o numero da operacao que deseja executar (ou digite 0 para sair):");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    verificarParOuImpar();
                    break;

                case 2:
                    calculadora();
                    break;

                case 3:
                    reajusteSalarial();
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
            Console.WriteLine("\nInsira um numero: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("O numero e: Par\n");
            }
            else
            {
                Console.WriteLine("O numero e: Impar\n");
            }
        }

        public static void calculadora()
        {
            Console.WriteLine("Insira o tipo de operacao que deseja realizar: ");
            Console.WriteLine("+ Adicao");
            Console.WriteLine("- Subtracao");
            Console.WriteLine("* Multiplicacao");
            Console.WriteLine("/ Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero: ");
            int numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int numB = int.Parse(Console.ReadLine());

            double resultado;

            if (operacao == "+")
            {
                resultado = numA + numB;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (operacao == "-")
            {
                resultado = numA - numB;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (operacao == "*")
            {
                 resultado = numA * numB;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (operacao == "/")
            {
                if (numB != 0)
                {
                    resultado = (double)numA / numB;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Nao e possivel dividir por zero");
                }
            }
            else
            {
                Console.WriteLine("Operacao Invalida");
            }

        }

        public static void reajusteSalarial()
        {
            Console.WriteLine("\nInforme seu salario:");
            double salario = Double.Parse(Console.ReadLine());
            double novoSalario;
            
            if (salario < 1700){
                novoSalario = salario + 300;
            }
            else{
                novoSalario = salario + 200;
            }

            Console.WriteLine($"\nSalario atual: {novoSalario}");
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
