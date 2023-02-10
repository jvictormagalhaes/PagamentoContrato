using PagamentoContrato.Entities;
using PagamentoContrato.Services;
using System.Globalization;

namespace PagamentoContrato.Services
{
    internal class ServicoContrato
    {
        public Contrato Contrato { get; set; }
        public int Mes { get; set; }

        private IServicoPagamentoOnline _servicoPagamento;

        public ServicoContrato(Contrato contrato, int mes, IServicoPagamentoOnline servicoPagamento)
        {
            Contrato = contrato;
            Mes = mes;
            _servicoPagamento = servicoPagamento;
        }

        public void ProcessoContrato(Contrato contrato, int mes)
        {
            double quantia = contrato.ValorTotal / mes;
            for (int i = 1; i <= mes; i++)
            {
                DateTime duracao = contrato.Date.AddMonths(i);
                double juros = _servicoPagamento.Juros(quantia, i);
                double taxa = _servicoPagamento.TaxaPagamento(juros);

                contrato.AdicionarParcela(new Parcelas(duracao, taxa));
            }
        }
    }
}
