namespace STI
{
    partial class Produkt
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
            System.Windows.Forms.Label nawaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label ilośćLabel;
            System.Windows.Forms.Label opisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkt));
            this.database1DataSet = new STI.Database1DataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new STI.Database1DataSetTableAdapters.ProduktyTableAdapter();
            this.tableAdapterManager = new STI.Database1DataSetTableAdapters.TableAdapterManager();
            this.produktyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nawaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.ilośćTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.produktyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produktyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nawaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            ilośćLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingNavigator)).BeginInit();
            this.produktyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.database1DataSet;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.UpdateOrder = STI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamówieniaTableAdapter = null;
            // 
            // produktyBindingNavigator
            // 
            this.produktyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produktyBindingNavigator.BindingSource = this.produktyBindingSource;
            this.produktyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produktyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produktyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produktyBindingNavigatorSaveItem});
            this.produktyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produktyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produktyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produktyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produktyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produktyBindingNavigator.Name = "produktyBindingNavigator";
            this.produktyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produktyBindingNavigator.Size = new System.Drawing.Size(545, 25);
            this.produktyBindingNavigator.TabIndex = 0;
            this.produktyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nawaLabel
            // 
            nawaLabel.AutoSize = true;
            nawaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nawaLabel.Location = new System.Drawing.Point(-1, 256);
            nawaLabel.Name = "nawaLabel";
            nawaLabel.Size = new System.Drawing.Size(46, 16);
            nawaLabel.TabIndex = 3;
            nawaLabel.Text = "Nawa:";
            // 
            // nawaTextBox
            // 
            this.nawaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Nawa", true));
            this.nawaTextBox.Location = new System.Drawing.Point(47, 254);
            this.nawaTextBox.Name = "nawaTextBox";
            this.nawaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nawaTextBox.TabIndex = 4;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cenaLabel.Location = new System.Drawing.Point(-1, 282);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(43, 16);
            cenaLabel.TabIndex = 5;
            cenaLabel.Text = "Cena:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(47, 280);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cenaTextBox.TabIndex = 6;
            // 
            // ilośćLabel
            // 
            ilośćLabel.AutoSize = true;
            ilośćLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            ilośćLabel.Location = new System.Drawing.Point(-1, 308);
            ilośćLabel.Name = "ilośćLabel";
            ilośćLabel.Size = new System.Drawing.Size(39, 16);
            ilośćLabel.TabIndex = 7;
            ilośćLabel.Text = "Ilość:";
            // 
            // ilośćTextBox
            // 
            this.ilośćTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Ilość", true));
            this.ilośćTextBox.Location = new System.Drawing.Point(47, 306);
            this.ilośćTextBox.Name = "ilośćTextBox";
            this.ilośćTextBox.Size = new System.Drawing.Size(100, 20);
            this.ilośćTextBox.TabIndex = 8;
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            opisLabel.Location = new System.Drawing.Point(-1, 334);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(39, 16);
            opisLabel.TabIndex = 9;
            opisLabel.Text = "Opis:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(47, 332);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(100, 20);
            this.opisTextBox.TabIndex = 10;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // produktyBindingNavigatorSaveItem
            // 
            this.produktyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produktyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produktyBindingNavigatorSaveItem.Image")));
            this.produktyBindingNavigatorSaveItem.Name = "produktyBindingNavigatorSaveItem";
            this.produktyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produktyBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.produktyBindingNavigatorSaveItem.Click += new System.EventHandler(this.produktyBindingNavigatorSaveItem_Click);
            // 
            // produktyDataGridView
            // 
            this.produktyDataGridView.AutoGenerateColumns = false;
            this.produktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produktyDataGridView.DataSource = this.produktyBindingSource;
            this.produktyDataGridView.Location = new System.Drawing.Point(0, 28);
            this.produktyDataGridView.Name = "produktyDataGridView";
            this.produktyDataGridView.Size = new System.Drawing.Size(543, 220);
            this.produktyDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nawa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nawa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ilość";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ilość";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Produkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 361);
            this.Controls.Add(this.produktyDataGridView);
            this.Controls.Add(nawaLabel);
            this.Controls.Add(this.nawaTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(ilośćLabel);
            this.Controls.Add(this.ilośćTextBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.produktyBindingNavigator);
            this.Name = "Produkt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingNavigator)).EndInit();
            this.produktyBindingNavigator.ResumeLayout(false);
            this.produktyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Database1DataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produktyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produktyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nawaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox ilośćTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.DataGridView produktyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}