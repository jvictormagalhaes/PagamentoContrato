using System.Globalization;

namespace PagamentoContrato.Entities
{
    internal class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double Total { get; set; }

        public Parcelas(DateTime dataVencimento, double total)
        {
            DataVencimento = dataVencimento;
            Total = total;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyy")
                + " - "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
