using System;
using System.Globalization;
using PagamentoContrato.Entities;
using PagamentoContrato.Services;

namespace PagamentoContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o número de parcelas: ");
            int qtdparcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);
            Console.WriteLine();
            Console.WriteLine("Parcelas: ");

            ServicoContrato servicoContrato =  new ServicoContrato(contrato, qtdparcelas, new ServiçoPayPal());
            servicoContrato.ProcessoContrato(contrato, qtdparcelas);

            foreach(Parcelas p in contrato.Parcelas)
            {
                Console.WriteLine(p);
            }
        }
    }
}