
namespace PagamentoContrato.Services
{
    interface IServicoPagamentoOnline
    {
        double TaxaPagamento(double quantia);
        double Juros(double quantia, int meses);
    }
}
