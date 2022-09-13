using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }       

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double saldo) : this(numero, nome)
        {
        Saldo = saldo;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }


        public override string ToString()
        {
            return "Conta: "
                + Numero
                + " Nome: "
                + Nome
                + " saldo: $ "
                + Saldo.ToString("f2");
        }
    }
}
