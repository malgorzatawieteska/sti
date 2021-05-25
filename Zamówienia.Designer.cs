namespace STI
{
    partial class Zamówienia
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
            System.Windows.Forms.Label id_ProduktLabel;
            System.Windows.Forms.Label id_KlientLabel;
            System.Windows.Forms.Label ilośćLabel;
            System.Windows.Forms.Label kosztLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamówienia));
            this.database1DataSet = new STI.Database1DataSet();
            this.zamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaTableAdapter = new STI.Database1DataSetTableAdapters.ZamówieniaTableAdapter();
            this.tableAdapterManager = new STI.Database1DataSetTableAdapters.TableAdapterManager();
            this.zamówieniaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamówieniaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new STI.Database1DataSetTableAdapters.ProduktyTableAdapter();
            this.id_ProduktTextBox = new System.Windows.Forms.TextBox();
            this.id_KlientTextBox = new System.Windows.Forms.TextBox();
            this.ilośćTextBox = new System.Windows.Forms.TextBox();
            this.kosztTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.zamówieniaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            id_ProduktLabel = new System.Windows.Forms.Label();
            id_KlientLabel = new System.Windows.Forms.Label();
            ilośćLabel = new System.Windows.Forms.Label();
            kosztLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingNavigator)).BeginInit();
            this.zamówieniaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.UpdateOrder = STI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamówieniaTableAdapter = this.zamówieniaTableAdapter;
            // 
            // zamówieniaBindingNavigator
            // 
            this.zamówieniaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zamówieniaBindingNavigator.BindingSource = this.zamówieniaBindingSource;
            this.zamówieniaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zamówieniaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zamówieniaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zamówieniaBindingNavigatorSaveItem});
            this.zamówieniaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zamówieniaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zamówieniaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zamówieniaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zamówieniaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zamówieniaBindingNavigator.Name = "zamówieniaBindingNavigator";
            this.zamówieniaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zamówieniaBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.zamówieniaBindingNavigator.TabIndex = 0;
            this.zamówieniaBindingNavigator.Text = "bindingNavigator1";
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
            // zamówieniaDataGridView
            // 
            this.zamówieniaDataGridView.AutoGenerateColumns = false;
            this.zamówieniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zamówieniaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.zamówieniaDataGridView.DataSource = this.zamówieniaBindingSource;
            this.zamówieniaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.zamówieniaDataGridView.Name = "zamówieniaDataGridView";
            this.zamówieniaDataGridView.Size = new System.Drawing.Size(644, 220);
            this.zamówieniaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Produkt";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Produkt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Klient";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Klient";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Koszt";
            this.dataGridViewTextBoxColumn5.HeaderText = "Koszt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // id_ProduktLabel
            // 
            id_ProduktLabel.AutoSize = true;
            id_ProduktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            id_ProduktLabel.Location = new System.Drawing.Point(0, 256);
            id_ProduktLabel.Name = "id_ProduktLabel";
            id_ProduktLabel.Size = new System.Drawing.Size(71, 16);
            id_ProduktLabel.TabIndex = 4;
            id_ProduktLabel.Text = "Id Produkt:";
            // 
            // id_ProduktTextBox
            // 
            this.id_ProduktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamówieniaBindingSource, "Id_Produkt", true));
            this.id_ProduktTextBox.Location = new System.Drawing.Point(73, 254);
            this.id_ProduktTextBox.Name = "id_ProduktTextBox";
            this.id_ProduktTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_ProduktTextBox.TabIndex = 5;
            // 
            // id_KlientLabel
            // 
            id_KlientLabel.AutoSize = true;
            id_KlientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            id_KlientLabel.Location = new System.Drawing.Point(0, 282);
            id_KlientLabel.Name = "id_KlientLabel";
            id_KlientLabel.Size = new System.Drawing.Size(57, 16);
            id_KlientLabel.TabIndex = 6;
            id_KlientLabel.Text = "Id Klient:";
            // 
            // id_KlientTextBox
            // 
            this.id_KlientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamówieniaBindingSource, "Id_Klient", true));
            this.id_KlientTextBox.Location = new System.Drawing.Point(73, 280);
            this.id_KlientTextBox.Name = "id_KlientTextBox";
            this.id_KlientTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_KlientTextBox.TabIndex = 7;
            // 
            // ilośćLabel
            // 
            ilośćLabel.AutoSize = true;
            ilośćLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            ilośćLabel.Location = new System.Drawing.Point(0, 308);
            ilośćLabel.Name = "ilośćLabel";
            ilośćLabel.Size = new System.Drawing.Size(39, 16);
            ilośćLabel.TabIndex = 8;
            ilośćLabel.Text = "Ilość:";
            // 
            // ilośćTextBox
            // 
            this.ilośćTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamówieniaBindingSource, "Ilość", true));
            this.ilośćTextBox.Location = new System.Drawing.Point(73, 306);
            this.ilośćTextBox.Name = "ilośćTextBox";
            this.ilośćTextBox.Size = new System.Drawing.Size(121, 20);
            this.ilośćTextBox.TabIndex = 9;
            // 
            // kosztLabel
            // 
            kosztLabel.AutoSize = true;
            kosztLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kosztLabel.Location = new System.Drawing.Point(0, 334);
            kosztLabel.Name = "kosztLabel";
            kosztLabel.Size = new System.Drawing.Size(43, 16);
            kosztLabel.TabIndex = 10;
            kosztLabel.Text = "Koszt:";
            // 
            // kosztTextBox
            // 
            this.kosztTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamówieniaBindingSource, "Koszt", true));
            this.kosztTextBox.Location = new System.Drawing.Point(73, 332);
            this.kosztTextBox.Name = "kosztTextBox";
            this.kosztTextBox.Size = new System.Drawing.Size(121, 20);
            this.kosztTextBox.TabIndex = 11;
            this.kosztTextBox.TextChanged += new System.EventHandler(this.kosztTextBox_TextChanged);
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            statusLabel.Location = new System.Drawing.Point(0, 360);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(48, 16);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamówieniaBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Zapłacone",
            "Zapłata przy odbiorze"});
            this.statusComboBox.Location = new System.Drawing.Point(73, 358);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 13;
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
            // zamówieniaBindingNavigatorSaveItem
            // 
            this.zamówieniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zamówieniaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zamówieniaBindingNavigatorSaveItem.Image")));
            this.zamówieniaBindingNavigatorSaveItem.Name = "zamówieniaBindingNavigatorSaveItem";
            this.zamówieniaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zamówieniaBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.zamówieniaBindingNavigatorSaveItem.Click += new System.EventHandler(this.zamówieniaBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sprawdź koszt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zamówienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_ProduktLabel);
            this.Controls.Add(this.id_ProduktTextBox);
            this.Controls.Add(id_KlientLabel);
            this.Controls.Add(this.id_KlientTextBox);
            this.Controls.Add(ilośćLabel);
            this.Controls.Add(this.ilośćTextBox);
            this.Controls.Add(kosztLabel);
            this.Controls.Add(this.kosztTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.zamówieniaDataGridView);
            this.Controls.Add(this.zamówieniaBindingNavigator);
            this.Name = "Zamówienia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienia";
            this.Load += new System.EventHandler(this.Zamówienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingNavigator)).EndInit();
            this.zamówieniaBindingNavigator.ResumeLayout(false);
            this.zamówieniaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource zamówieniaBindingSource;
        private Database1DataSetTableAdapters.ZamówieniaTableAdapter zamówieniaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zamówieniaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zamówieniaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView zamówieniaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Database1DataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private System.Windows.Forms.TextBox id_ProduktTextBox;
        private System.Windows.Forms.TextBox id_KlientTextBox;
        private System.Windows.Forms.TextBox ilośćTextBox;
        private System.Windows.Forms.TextBox kosztTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button button1;
    }
}