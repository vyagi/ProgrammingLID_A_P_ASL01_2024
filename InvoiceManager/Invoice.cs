using System.Globalization;

namespace InvoiceManager
{
    public class Invoice
    {
        public string Name { get; private set; }

        public decimal Amount { get; private set; }

        public string Category { get; private set; }

        public DateTime Date { get; private set; }

        public Invoice(string line)
        {
            var split = line.Split(';');

            Name = split[0];
            Amount = decimal.Parse(split[1]
                .Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)
                .Replace(".", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));

            Category = split[2];
            Date = DateTime.Parse(split[3]);
        }
    }
}
