using System;

namespace Trabalho_Robinho_25_03
{
    public class ContaBancaria
    {
        public double saldo { get; private set; }
        public string numeroConta { get; set; }
        public string titular { get; set; }

        public void QualSaldo(double novoSaldo)
        {
            saldo = novoSaldo;
        }

        public void QualNumeroConta(string novoNumero)
        {
            numeroConta = novoNumero;
        }

        public void QualTitularConta(string novoTitular)
        {
            titular = novoTitular;
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public string ObterNumeroConta()
        {
            return numeroConta;
        }

        public string ObterTitularConta()
        {
            return titular;
        }

        public void Depositar()
        {
            Console.WriteLine("Quanto você quer depositar?");
            double deposito = double.Parse(Console.ReadLine());

            saldo += deposito;
            Console.WriteLine($"Você fez um depósito de {deposito}");
            Console.WriteLine($"O novo saldo da conta é: {saldo}");
        }

        public void Sacar()
        {
            Console.WriteLine("Quanto você quer sacar?");
            double saque = double.Parse(Console.ReadLine());

            if (saldo >= saque)
            {
                saldo -= saque;
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine($"O novo saldo da conta é: {saldo}");
            }
            else
            {
                Console.WriteLine("Saque não permitido. Saldo insuficiente.");
            }
        }
    }
}
