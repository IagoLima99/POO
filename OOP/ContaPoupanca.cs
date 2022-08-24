using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta , IConta
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite)  
        {
        }

        public void MostrarNumerodaconta()
        {
            Console.WriteLine("A conta poupança é:" + this.Numero);
        }

        public override bool Sacar(double valor)
        {
            bool deuCertoSaque = base.Sacar(valor);

            if (deuCertoSaque)
            {
                this.Saldo -= 6;
            }

            return false;
        }
    }
}
