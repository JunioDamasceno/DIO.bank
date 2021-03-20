using System;
using System.Collections.Generic;

namespace DIO.bank
{
    class Program
    {

        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarContas();
                        break;
                    case "2":
                    InserirConta();
                        break;
                    case "3":
                    //Transferir();
                        break;
                    case "4":
                   //Sacar();
                        break;
                    case "5":
                    //Depositar();
                       break;
                    case "C":
                    Console.Clear();
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nossos serviços!");

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if (listContas.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhuma Conta Cadastrada.");
                Console.WriteLine("Aperte Enter para retornar ao menu");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#(0) - ", i);
                Console.WriteLine(conta);

            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir Nova Conta");

            Console.Write("Digite 1 para conta Física e 2 para Jurídica: ");
            int entradaTipoConta = int.Parse((Console.ReadLine()));
            
            Console.Write("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digito o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                         saldo: entradaSaldo,
                                         credito: entradaCredito,
                                         nome: entradaNome);
            
            listContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank ao seu dispor!");
            Console.WriteLine("informe a opção desejada: ");
            Console.WriteLine("1 - listar contas; ");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 = Transferir: ");
            Console.WriteLine("4 - Sacar: ");
            Console.WriteLine("5 - Depositar: ");
            Console.WriteLine("C - Limpar Tela: ");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        
    }
}
