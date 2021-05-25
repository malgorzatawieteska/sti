using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void klienciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klienciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Zamówienia' . Możesz go przenieść lub usunąć.
            this.zamówieniaTableAdapter.Fill(this.database1DataSet.Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.database1DataSet.Produkty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.database1DataSet.Klienci);

        }

        private void klientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klient k = new Klient();
            k.ShowDialog();
        }

        private void produktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkt p = new Produkt();
            p.ShowDialog();
        }

        private void złóżZamówienieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zamówienia z = new Zamówienia();
            z.ShowDialog();
        }
    }
}
