using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

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
                    calcularIMC();
                    break;

                case 5:
                    contarVogais();
                    break;

                case 6:
                    verificarAlturaAluno();
                    break;

                case 7:
                    contaCorrente();
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
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("======= Calculo IMC =======");
                Console.WriteLine("N - Novo");
                Console.WriteLine("C - Consultar");
                Console.WriteLine("S - Sair");

                string opc = Console.ReadLine();

                Console.WriteLine("===========================");

                switch (opc.ToUpper())
                {
                    case "N":
                        novoIMC();
                        break;

                    case "C":
                        consultarIMC();
                        break;

                    case "S":
                        Console.WriteLine("Encerrando operacao...");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            }
        }

        static void novoIMC()
        {
            try {
                Console.WriteLine("Informe seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe seu peso: ");
                float peso = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe sua altura: ");
                float altura = float.Parse(Console.ReadLine());

                float imc = peso / (altura * altura);

                string resultadoIMC;

                if (imc < 18.5) {
                    resultadoIMC = "Abaixo do peso";
                }
                else if (imc < 24.9) {
                    resultadoIMC = "Peso normal";
                }
                else if (imc < 29.9) {
                    resultadoIMC = "Sobrepeso";
                }
                else if (imc < 34.9) {
                    resultadoIMC = "Obesidade Grau I";
                }
                else if (imc < 39.9) {
                    resultadoIMC = "Obesidade Grau II";
                }
                else {
                    resultadoIMC = "Obesidade Grau III";
                }

                Console.WriteLine($"Resultado: {resultadoIMC}");

                string conteudo = $"Nome: {nome} \n" +
                    $"Idade: {idade} \n" +
                    $"Peso: {peso} kg \n" +
                    $"Altura: {altura} m \n" +
                    $"IMC: {imc:F2} \n" +
                    $"Resultado: {resultadoIMC}\n" +
                    $"===========================\n";

                string caminho = "C:\\Users\\conta\\OneDrive\\Área de Trabalho\\Area de trabalho\\Matheus\\C# Projects VS\\CSharpSmart\\imc.txt";
                File.AppendAllText(caminho, conteudo);

                Console.WriteLine("Dados gravados com sucesso!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Formato invalido.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        static void consultarIMC()
        {
            string caminho = "C:\\Users\\conta\\OneDrive\\Área de Trabalho\\Area de trabalho\\Matheus\\C# Projects VS\\CSharpSmart\\imc.txt";
            if (File.Exists(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado.");
            }
        }

        public static void contarVogais()
        {
            Console.WriteLine("Digite a string que sera contada: ");
            string texto = Console.ReadLine();

            int vogais = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
                {
                    vogais++;
                }
            }

            Console.WriteLine($"A quantidade de vogais e: {vogais}");
        }

        public static void verificarAlturaAluno()
        {
            string alunoMaisAlto = "";
            float maiorAltura = 0.0f;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nDigite o nome do {i}º aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"\nDigite a altura do {i}º aluno: ");
                float altura = float.Parse(Console.ReadLine());

                if (altura > maiorAltura)
                {   
                    maiorAltura = altura;
                    alunoMaisAlto = nome;

                }
            }
                Console.WriteLine("O aluno mais alto e: " + alunoMaisAlto);

        }

        public static void contaCorrente()
        {
            ContaCorrente conta = new ContaCorrente(1, "Matheus Reginato Rezende", 1500);

            conta.MenuBanco();
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
