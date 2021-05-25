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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void klienciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klienciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.database1DataSet.Klienci);

        }
    }
}
