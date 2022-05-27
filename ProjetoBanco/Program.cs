using ProjetoBanco.Classes;
using System;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {            
            try
            {
                var mauricio = Cliente.CreateCliente("Maurício", "Rua 9 de Julho 202", 16999222999, "999.999.999-99", new DateTime(2000, 02, 17));
                var roger = Cliente.CreateCliente("Roger", "Rua São Bento 304", 16999222998, "251.851.986-25", new DateTime(2000, 02, 17));
                
                Console.WriteLine(mauricio.ToString());

                
                Conta contaPoupanca = new Poupanca(mauricio, 445852, 1000);
                Conta contaCorrente = new ContaCorrente(roger, 999999, 0);

                Console.WriteLine(contaPoupanca.Saldo);

                contaPoupanca.Transferir(500, contaCorrente);

                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Depositar(1000);
                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Sacar(500);
                Console.WriteLine(contaPoupanca.Saldo);

                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Depositar(5500);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Sacar(500);
                Console.WriteLine(contaCorrente.Saldo);

            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}