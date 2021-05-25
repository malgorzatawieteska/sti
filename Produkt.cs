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
    public partial class Produkt : Form
    {
        public Produkt()
        {
            InitializeComponent();
        }

        private void produktyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produktyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Produkt_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.database1DataSet.Produkty);

        }
    }
}
