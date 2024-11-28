namespace InvoiceManager
{
    public partial class InvoiceManager : Form
    {
        public InvoiceManager()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue...");
                return;
            }

            var content = File
                .ReadAllText(path)
                .Replace(";","\t")
                .Replace("\n","\r\n");

            resultTextBox.Text = content;
        }

        private void byCategoryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue...");
                return;
            }

            var lines = File.ReadAllLines(path);

            var summary = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                var invoice = new Invoice(line);

                if (summary.ContainsKey(invoice.Category))
                {
                    summary[invoice.Category] += invoice.Amount;
                }
                else
                {
                    summary[invoice.Category] = invoice.Amount;
                }
            }

            resultTextBox.Clear();

            foreach (var entry in summary)
            {
                resultTextBox.Text += $"{entry.Key}\t{entry.Value}\r\n";
            }
        }

        private void byMonthButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue...");
                return;
            }

            var lines = File.ReadAllLines(path);

            var summary = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                var invoice = new Invoice(line);

                var month = $"{invoice.Date.Year}-{invoice.Date.Month}";

                if (summary.ContainsKey(month))
                {
                    summary[month] += invoice.Amount;
                }
                else
                {
                    summary[month] = invoice.Amount;
                }
            }

            resultTextBox.Clear();

            foreach (var entry in summary)
            {
                resultTextBox.Text += $"{entry.Key}\t{entry.Value}\r\n";
            }
        }
    }
}
