    using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP!");

            AnalistaDeTI analistaDeTI = new AnalistaDeTI();

            analistaDeTI.AdicionarNome("Acaciano", "Neves");
            analistaDeTI.AdicionarSalarioPadrao(1000);

            analistaDeTI.Reajustar();

            Console.WriteLine("Salario é:" + analistaDeTI.Salario);





            //ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Sacar(10);
            //double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();

            //Console.WriteLine("Saldo poupanca é: " + saldoPoupanca);



            //ContaCorrente ContaCorrente = new ContaCorrente(111, 100);

            //ContaCorrente.Deposita(100);
            //ContaCorrente.Sacar(20);
            //double saldoCorrente = ContaCorrente.ConsultaSaldoDisponivel();

            //Console.WriteLine("Saldo corrente é: " + saldoCorrente);




            /*AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            Gerente gerente = new Gerente();
            GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            GerenteDeTI gerenteDeTI = new GerenteDeTI();

            analistaDeTI.Nome = "Acaciano Neves";
            analistaDeTI.Salario = 3000;

            Console.WriteLine("O salário do Analista de Ti é:" + analistaDeTI.Salario);

            analistaDeTI.Reajustar();

            Console.WriteLine("O salário do Analista de Ti reajustado é:" + analistaDeTI.Salario);

            Console.WriteLine("__________________________________");

            gerente.Nome = "Amanda Neves";
            gerente.Salario = 8000;

            Console.WriteLine("O salário do Gerente é:" + gerente.Salario);

            gerente.Reajustar();

            Console.WriteLine("O salário do Gerente reajustado é:" + gerente.Salario);

            Console.WriteLine("__________________________________");

            gerenteDeAgencia.Nome = "Caio Neves";
            gerenteDeAgencia.Salario = 10000;

            Console.WriteLine("O salário do GerenteDeAgencia é:" + gerenteDeAgencia.Salario);

            gerenteDeAgencia.Reajustar();

            Console.WriteLine("O salário do GerenteDeAgencia reajustado é:" + gerenteDeAgencia.Salario);

            Console.WriteLine("__________________________________");

            gerenteDeTI.Nome = "Rick Neves";
            gerenteDeTI.Salario = 20000;

            Console.WriteLine("O salário do GerenteDeTI é:" + gerenteDeTI.Salario);

            gerenteDeTI.Reajustar();

            Console.WriteLine("O salário do GerenteDeTI reajustado é:" + gerenteDeTI.Salario);*/

            /*
                        ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);

                        contaPoupanca.Deposita(100);
                        contaPoupanca.Sacar(10);

                        double saldo = contaPoupanca.ConsultaSaldoDisponivel();

                        contaPoupanca.MostrarNumerodaconta();

                        Console.WriteLine("O saldo da conta poupança é: " + saldo);

                        Conta conta = new Conta(113, 100);

                        conta.Deposita(500);
                        conta.Sacar(140);

                        double saldoContaCorrente = conta.ConsultaSaldoDisponivel();
                        Console.WriteLine("O saldo da conta corrente é: " + saldoContaCorrente);*/




            /*Conta conta1 = new Conta(123, 300);
            Conta conta2 = new Conta(456, 600);
            Conta conta3 = new Conta(789, 900);
            Conta conta4 = new Conta(999, 1000);


            Console.WriteLine("Total de contas: " + Conta.TotalDeContasCriadas);

            int total = Conta.ProximoTotalDeContasCriadas();

            Console.WriteLine("Próximo Total de contas: " + total);*/







            /* CartaoDeCredito cdc = new CartaoDeCredito();
             Cliente c = new Cliente();

             // Adicionando o nome do cliente 
             c.Nome = "Acaciano Neves";

             // Adiconando o numero e a data de validade do cartão

             cdc.Numero = "52354252451251421";
             cdc.DataDeValidade = "02/2025";
             cdc.Cliente = c;

             Console.WriteLine("O nome do seu cliente é:" + c.Nome);
             Console.WriteLine("O número do cartão é:" + cdc.Numero);
             Console.WriteLine("A data de validade do cartão é:" + cdc.DataDeValidade);
             Console.WriteLine("O nome do cliente agregado é:" + cdc.Cliente.Nome);*/







            // Criando instância da conta 1
            //Conta conta = new Conta(123,400);

            //conta.AdicionarLimite(1500);

            //conta.Deposita(1500);
            //conta.Deposita(2500);
            //conta.Deposita(4500);

            //conta.Sacar(7000);

            //double saldo = conta.ConsultaSaldoDisponivel();

            //Console.WriteLine("Seu saldo é: " + saldo);
            //Console.WriteLine("Seu limite é: " + conta.Limite);
            //Console.WriteLine("O numero da sua conta é: " + conta.Numero);

        }
    }
}
