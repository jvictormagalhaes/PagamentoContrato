using System.Globalization;
using PagamentoContrato.Services;

namespace PagamentoContrato.Services
{
    internal class ServiçoPayPal : IServicoPagamentoOnline
    {
        public double TaxaPagamento(double quantia)
        {
           return quantia += quantia * 0.02;
        }
        public double Juros(double quantia, int mes)
        {
            return quantia += quantia * 0.01 * mes;
        }

    }
}
