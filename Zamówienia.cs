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
    public partial class Zamówienia : Form
    {
        public Zamówienia()
        {
            InitializeComponent();
        }

        private void zamówieniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zamówieniaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Zamówienia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.database1DataSet.Produkty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Zamówienia' . Możesz go przenieść lub usunąć.
            this.zamówieniaTableAdapter.Fill(this.database1DataSet.Zamówienia);

        }

        private void kosztTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cena = database1DataSet.Produkty.FindById(Convert.ToInt32(id_ProduktTextBox.Text)).Cena;
            double koszt = cena * Convert.ToInt32(ilośćTextBox.Text);
            kosztTextBox.Text = Convert.ToString(koszt);
        }
    }
}
