using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_heranca_poo
{
    internal class Empresarial : Conta
    {

        public double TaxaAnuidade { get; set; }
        public double Limite { get; set; }
        public double TotalEmpr { get; set; }

        public Empresarial()
        {

        }

        public Empresarial(double taxaAnuidade, double limite, double totalEmpr)
        {
            TaxaAnuidade = taxaAnuidade;
            Limite = limite;
            TotalEmpr = totalEmpr;
        }

        public void FazerEmprestimo(double v)
        {
            //receber o valor do emprestimo e comparar com o seu limite
            if (v < Limite)
            {
                TotalEmpr = v;
                Saldo = Saldo + v;
                Console.WriteLine("O empréstimo foi realizado com sucesso");
            }

            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido");
            }

        }


        public override void Saque(double v)
        {
            if (v > 5000)
            {
                base.Saque(v - 5);
                Console.WriteLine("O valor da taxa é de 5 reais");
            }

            else
            {
                base.Saque(v);
                Console.WriteLine("Sem taxas");
            }
        }


        public override void Deposito(double d)
        {
            base.Deposito(d);
        }
    }
}
