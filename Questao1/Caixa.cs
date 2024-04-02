using System;

namespace Trabalho_Robinho_25_03
{
    public class Caixa
    {
        ContaBancaria _contaBancaria = new ContaBancaria();
        public void CaixaEletronico()
        {
            Console.Clear();
            Console.WriteLine("Escreva o saldo da sua conta:");
            double saldo = double.Parse(Console.ReadLine());
            _contaBancaria.QualSaldo(saldo);

            Console.WriteLine("Escreva o número da sua conta:");
            string numeroConta = Console.ReadLine();
            _contaBancaria.QualNumeroConta(numeroConta);

            Console.WriteLine("Escreva o titular da sua conta:");
            string titularConta = Console.ReadLine();
            _contaBancaria.QualTitularConta(titularConta);

            Console.WriteLine($"Saldo: {saldo}, Número da conta: {numeroConta}, Titular da conta: {titularConta}");

            while (true)
            {
                Console.WriteLine("Escolha o que você quer fazer:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        _contaBancaria.Depositar();
                        break;
                    case "2":
                        _contaBancaria.Sacar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
