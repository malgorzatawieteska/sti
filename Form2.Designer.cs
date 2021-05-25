namespace STI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new STI.Database1DataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new STI.Database1DataSetTableAdapters.KlienciTableAdapter();
            this.tableAdapterManager = new STI.Database1DataSetTableAdapters.TableAdapterManager();
            this.produktyTableAdapter = new STI.Database1DataSetTableAdapters.ProduktyTableAdapter();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaTableAdapter = new STI.Database1DataSetTableAdapters.ZamówieniaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.złóżZamówienieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odświeżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.database1DataSet;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.UpdateOrder = STI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamówieniaTableAdapter = null;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.database1DataSet;
            // 
            // zamówieniaBindingSource
            // 
            this.zamówieniaBindingSource.DataMember = "Zamówienia";
            this.zamówieniaBindingSource.DataSource = this.database1DataSet;
            // 
            // zamówieniaTableAdapter
            // 
            this.zamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.złóżZamówienieToolStripMenuItem,
            this.odświeżToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientToolStripMenuItem,
            this.produktToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // klientToolStripMenuItem
            // 
            this.klientToolStripMenuItem.Name = "klientToolStripMenuItem";
            this.klientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klientToolStripMenuItem.Text = "Klienta";
            this.klientToolStripMenuItem.Click += new System.EventHandler(this.klientToolStripMenuItem_Click);
            // 
            // produktToolStripMenuItem
            // 
            this.produktToolStripMenuItem.Name = "produktToolStripMenuItem";
            this.produktToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.produktToolStripMenuItem.Text = "Produkt";
            this.produktToolStripMenuItem.Click += new System.EventHandler(this.produktToolStripMenuItem_Click);
            // 
            // złóżZamówienieToolStripMenuItem
            // 
            this.złóżZamówienieToolStripMenuItem.Name = "złóżZamówienieToolStripMenuItem";
            this.złóżZamówienieToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.złóżZamówienieToolStripMenuItem.Text = "Złóż Zamówienie";
            this.złóżZamówienieToolStripMenuItem.Click += new System.EventHandler(this.złóżZamówienieToolStripMenuItem_Click);
            // 
            // odświeżToolStripMenuItem
            // 
            this.odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
            this.odświeżToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program zawiera trzy lokalne tabele: klienci, produkty i zamówienia. \r\nW zakładce" +
    " dodaj mamy możliwość podglądu, edycji i dodawania klientów oraz produków. \r\nW z" +
    "akładce złóż zamówienie - zamówień.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private Database1DataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private System.Windows.Forms.BindingSource zamówieniaBindingSource;
        private Database1DataSetTableAdapters.ZamówieniaTableAdapter zamówieniaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem złóżZamówienieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odświeżToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}