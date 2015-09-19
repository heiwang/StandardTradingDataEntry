namespace StandardTradingDataEntry.Forms.Pricelist
{
    partial class PriceListViewForm
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
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListViewForm));
            this.standardTradingDbDataSet1 = new StandardTradingDataEntry.StandardTradingDbDataSet1();
            this.priceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceListTableAdapter = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.PriceListTableAdapter();
            this.tableAdapterManager = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.TableAdapterManager();
            this.companyTableAdapter = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.CompanyTableAdapter();
            this.productTableAdapter = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.ProductTableAdapter();
            this.priceListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.priceListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.priceListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceListTableAdapter1 = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.PriceListTableAdapter();
            this.companyId = new System.Windows.Forms.ComboBox();
            this.product = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            companyLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.standardTradingDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingNavigator)).BeginInit();
            this.priceListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(12, 59);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(51, 13);
            companyLabel.TabIndex = 4;
            companyLabel.Text = "Company";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(12, 85);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(59, 13);
            productIdLabel.TabIndex = 6;
            productIdLabel.Text = "Product Id:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 111);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // standardTradingDbDataSet1
            // 
            this.standardTradingDbDataSet1.DataSetName = "StandardTradingDbDataSet1";
            this.standardTradingDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceListBindingSource
            // 
            this.priceListBindingSource.DataMember = "PriceList";
            this.priceListBindingSource.DataSource = this.standardTradingDbDataSet1;
            // 
            // priceListTableAdapter
            // 
            this.priceListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingTypeTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.PriceListTableAdapter = this.priceListTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.ProductUnitTableAdapter = null;
            this.tableAdapterManager.TransactionDetailTableAdapter = null;
            this.tableAdapterManager.TransactionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // priceListBindingNavigator
            // 
            this.priceListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.priceListBindingNavigator.BindingSource = this.priceListBindingSource;
            this.priceListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.priceListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.priceListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.priceListBindingNavigatorSaveItem});
            this.priceListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.priceListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.priceListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.priceListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.priceListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.priceListBindingNavigator.Name = "priceListBindingNavigator";
            this.priceListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.priceListBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.priceListBindingNavigator.TabIndex = 0;
            this.priceListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // priceListBindingNavigatorSaveItem
            // 
            this.priceListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.priceListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("priceListBindingNavigatorSaveItem.Image")));
            this.priceListBindingNavigatorSaveItem.Name = "priceListBindingNavigatorSaveItem";
            this.priceListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.priceListBindingNavigatorSaveItem.Text = "Save Data";
            this.priceListBindingNavigatorSaveItem.Click += new System.EventHandler(this.priceListBindingNavigatorSaveItem_Click);
            // 
            // priceListDataGridView
            // 
            this.priceListDataGridView.AutoGenerateColumns = false;
            this.priceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.priceListDataGridView.DataSource = this.priceListBindingSource;
            this.priceListDataGridView.Location = new System.Drawing.Point(0, 215);
            this.priceListDataGridView.Name = "priceListDataGridView";
            this.priceListDataGridView.Size = new System.Drawing.Size(473, 330);
            this.priceListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.standardTradingDbDataSet1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.priceListBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(84, 108);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // priceListTableAdapter1
            // 
            this.priceListTableAdapter1.ClearBeforeFill = true;
            // 
            // companyId
            // 
            this.companyId.DataSource = this.companyBindingSource;
            this.companyId.DisplayMember = "Nickname";
            this.companyId.FormattingEnabled = true;
            this.companyId.Location = new System.Drawing.Point(84, 56);
            this.companyId.Name = "companyId";
            this.companyId.Size = new System.Drawing.Size(121, 21);
            this.companyId.TabIndex = 10;
            this.companyId.ValueMember = "CompanyId";
            this.companyId.SelectedIndexChanged += new System.EventHandler(this.companyId_ValueChanged);
            // 
            // product
            // 
            this.product.DataSource = this.productBindingSource;
            this.product.DisplayMember = "EnglishName";
            this.product.FormattingEnabled = true;
            this.product.Location = new System.Drawing.Point(84, 83);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(121, 21);
            this.product.TabIndex = 11;
            this.product.ValueMember = "ProductId";
            this.product.SelectedIndexChanged += new System.EventHandler(this.product_ValueChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.standardTradingDbDataSet1;
            // 
            // PriceListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 588);
            this.Controls.Add(this.product);
            this.Controls.Add(this.companyId);
            this.Controls.Add(companyLabel);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceListDataGridView);
            this.Controls.Add(this.priceListBindingNavigator);
            this.Name = "PriceListViewForm";
            this.Text = "PriceListViewForm";
            this.Load += new System.EventHandler(this.PriceListViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standardTradingDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingNavigator)).EndInit();
            this.priceListBindingNavigator.ResumeLayout(false);
            this.priceListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StandardTradingDbDataSet1 standardTradingDbDataSet1;
        private System.Windows.Forms.BindingSource priceListBindingSource;
        private StandardTradingDbDataSet1TableAdapters.PriceListTableAdapter priceListTableAdapter;
        private StandardTradingDbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator priceListBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton priceListBindingNavigatorSaveItem;
        private StandardTradingDbDataSet1TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridView priceListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox priceTextBox;
        private StandardTradingDbDataSet1TableAdapters.PriceListTableAdapter priceListTableAdapter1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private StandardTradingDbDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox companyId;
        private System.Windows.Forms.ComboBox product;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}