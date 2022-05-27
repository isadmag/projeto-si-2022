using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, int numero, decimal saldo) : base(cliente, numero, saldo)
        { }
      
        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                MensagemTransacoes = $"Não é possível realizar o depósito!";
                return false;
            }

            Saldo += valorDeposito;
            MensagemTransacoes = "Depósito realizado com sucesso!";

            return true;
        }

        public override bool Sacar(decimal valorSaque)
        {
            if (Saldo <= 0m)
            {
                MensagemTransacoes = $"Saldo insuficiente para saque. Sua conta está com o valor atual de {Saldo}";
                return false;
            }

            if (Saldo < valorSaque)
            {
                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque} e o Saldo é {Saldo}";
                return false;
            }

            Saldo -= valorSaque;
            return true;
        }

       
    }
}

