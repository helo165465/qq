using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_heranca_poo
{
    internal class Estudantil : Conta
    {
        public double ChequeEspecial { get; set; }
        public string Cpf { get; set; }

        public string NomeInst { get; set; }

        public Estudantil()
        {

        }

        public Estudantil(double chequeEspecial, string cpf, string nomeInst)
        {
            ChequeEspecial = chequeEspecial;
            Cpf = cpf;
            NomeInst = nomeInst;
        }


        public override void Saque(double v)
        {
            if (v < Saldo + ChequeEspecial)
            {
                base.Saque(v);
            }

            else
            {
                Console.WriteLine("Não foi possivel adicionar");
            }
        }

        public override void Deposito(double v)
        {
            base.Deposito(v);
        }
    }
}
