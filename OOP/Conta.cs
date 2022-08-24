using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta
    {
        public Conta(int numero,double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalDeContasCriadas++; 

        }
        protected double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; set; }
        public static int ProximoTotalDeContasCriadas()
        {
            return Conta.TotalDeContasCriadas + 1;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel");
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
