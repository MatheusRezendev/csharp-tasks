using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSmart
{
    internal class ContaCorrente
    {
        private long IDdaConta { get; set; }
        private string nomeDoCorrentista { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(long iDdaConta, string nomeDoCorrentista, double saldo)
        {
            IDdaConta = iDdaConta;
            this.nomeDoCorrentista = nomeDoCorrentista;
            this.saldo = saldo;
        }

        public void MenuBanco()
        {
            while (true)
            {
                Console.WriteLine("Bem vindo ao Banco Smart\n");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Consultar Saldo");
                Console.WriteLine("3 - Sair\n");
                Console.WriteLine("Digite a opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nDigite o valor que deseja sacar: ");
                        double valor = double.Parse(Console.ReadLine());
                        Sacar(valor);
                        break;
                    case 2:
                        ConsultarSaldo();
                        break;
                    case 3:
                        Console.WriteLine("\nObrigado por utilizar o Banco Smart, Saindo ...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nOpção invalida");
                        break;
                }
            }
        }
        public void Sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("\nsaque realizado com sucesso!");
                Console.WriteLine($"saldo atual: {saldo}\n");
            }
            else
            {
                Console.WriteLine("saldo insuficiente\n");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"\nSeu saldo é: {saldo}\n");
        }

    }      
}
