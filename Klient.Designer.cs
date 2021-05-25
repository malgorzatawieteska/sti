namespace STI
{
    partial class Klient
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
            System.Windows.Forms.Label imięLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label miastoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient));
            this.database1DataSet = new STI.Database1DataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new STI.Database1DataSetTableAdapters.KlienciTableAdapter();
            this.tableAdapterManager = new STI.Database1DataSetTableAdapters.TableAdapterManager();
            this.klienciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.klienciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klienciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            imięLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).BeginInit();
            this.klienciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imięLabel
            // 
            imięLabel.AutoSize = true;
            imięLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            imięLabel.Location = new System.Drawing.Point(3, 255);
            imięLabel.Name = "imięLabel";
            imięLabel.Size = new System.Drawing.Size(36, 16);
            imięLabel.TabIndex = 4;
            imięLabel.Text = "Imię:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazwiskoLabel.Location = new System.Drawing.Point(3, 281);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(69, 16);
            nazwiskoLabel.TabIndex = 6;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            emailLabel.Location = new System.Drawing.Point(3, 307);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefonLabel.Location = new System.Drawing.Point(3, 333);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(57, 16);
            telefonLabel.TabIndex = 10;
            telefonLabel.Text = "Telefon:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            adresLabel.Location = new System.Drawing.Point(3, 359);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(47, 16);
            adresLabel.TabIndex = 12;
            adresLabel.Text = "Adres:";
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            miastoLabel.Location = new System.Drawing.Point(3, 385);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(51, 16);
            miastoLabel.TabIndex = 14;
            miastoLabel.Text = "Miasto:";
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
            this.tableAdapterManager.ProduktyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamówieniaTableAdapter = null;
            // 
            // klienciBindingNavigator
            // 
            this.klienciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klienciBindingNavigator.BindingSource = this.klienciBindingSource;
            this.klienciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klienciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klienciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.klienciBindingNavigatorSaveItem});
            this.klienciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klienciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klienciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klienciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klienciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klienciBindingNavigator.Name = "klienciBindingNavigator";
            this.klienciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klienciBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.klienciBindingNavigator.TabIndex = 0;
            this.klienciBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // klienciBindingNavigatorSaveItem
            // 
            this.klienciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klienciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klienciBindingNavigatorSaveItem.Image")));
            this.klienciBindingNavigatorSaveItem.Name = "klienciBindingNavigatorSaveItem";
            this.klienciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.klienciBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.klienciBindingNavigatorSaveItem.Click += new System.EventHandler(this.klienciBindingNavigatorSaveItem_Click);
            // 
            // klienciDataGridView
            // 
            this.klienciDataGridView.AutoGenerateColumns = false;
            this.klienciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klienciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.klienciDataGridView.DataSource = this.klienciBindingSource;
            this.klienciDataGridView.Location = new System.Drawing.Point(0, 28);
            this.klienciDataGridView.Name = "klienciDataGridView";
            this.klienciDataGridView.Size = new System.Drawing.Size(743, 220);
            this.klienciDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Miasto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Miasto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // imięTextBox
            // 
            this.imięTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Imię", true));
            this.imięTextBox.Location = new System.Drawing.Point(75, 254);
            this.imięTextBox.Name = "imięTextBox";
            this.imięTextBox.Size = new System.Drawing.Size(226, 20);
            this.imięTextBox.TabIndex = 5;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(75, 280);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(226, 20);
            this.nazwiskoTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(75, 306);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(226, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(75, 332);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(226, 20);
            this.telefonTextBox.TabIndex = 11;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(75, 358);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(226, 20);
            this.adresTextBox.TabIndex = 13;
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Miasto", true));
            this.miastoTextBox.Location = new System.Drawing.Point(75, 384);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(226, 20);
            this.miastoTextBox.TabIndex = 15;
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 413);
            this.Controls.Add(imięLabel);
            this.Controls.Add(this.imięTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(this.klienciDataGridView);
            this.Controls.Add(this.klienciBindingNavigator);
            this.Name = "Klient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).EndInit();
            this.klienciBindingNavigator.ResumeLayout(false);
            this.klienciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private Database1DataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klienciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton klienciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView klienciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox imięTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox miastoTextBox;
    }
}