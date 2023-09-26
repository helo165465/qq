using atividade_heranca_poo;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sistema de um banco");

        Conta c = new Conta();
        Console.Write("Digite seu nome: ");
        c.Titular = Console.ReadLine();
        Console.Write("Digite o nome da agencia : ");
        c.Agencia = Console.ReadLine();
        Console.Write("Digite o num da conta: ");
        c.NumConta = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o saldo : ");
        c.Saldo = Convert.ToDouble(Console.ReadLine()); ;


        Console.Write("Sua conta é: \n1- Conta Estudantil \n2- Conta Empresarial \n");
        Console.WriteLine("Digite sua opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());


        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o nome da instuição de ensino: ");
                string nomeInst = Console.ReadLine();
                Console.WriteLine("Digite seu cpf:");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite o valor do cheque especial: ");
               double chequeEspecial = Convert.ToInt32(Console.ReadLine());
                Estudantil e = new Estudantil(chequeEspecial, cpf, nomeInst);

                Console.WriteLine("Deseja realizar um saque: 1- Sim \n2- Não");
                int opcao2 = Convert.ToInt32(Console.ReadLine());

                if (opcao2 == 1)
                {
                    Console.WriteLine("Informe o valor do saque: ");
                    double v = Convert.ToDouble(Console.ReadLine());
                    e.Saque(v);
                }

                else if (opcao2 == 2)
                {
                    Console.WriteLine("Tchau");
                }

                break;
            case 2:



                break;

            default:
                Console.WriteLine("Opcão inválida");
                break;

        }


        Console.ReadKey();
    }




}