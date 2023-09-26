using System;

namespace atividade_heranca_poo
{
    internal class Conta
    {
        public double NumConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }

        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(double numConta, string agencia, string titular, double saldo)
        {
            NumConta = numConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double v)
        {
            if (Saldo >= v)
            {
                Saldo = Saldo - v;
                Console.WriteLine("Saque realizado");
            }

            else
            {
                Console.WriteLine("Valor inferior ao seu saldo");
            }
        }

        public virtual void Deposito(double d)
        {
            Saldo = Saldo + d;
        }

    }
}
