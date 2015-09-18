using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardTradingDataEntry.Forms.Product
{
    public partial class ProductViewForm : Form
    {
        public ProductViewForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standardTradingDbDataSet1);

        }

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.ProductUnit' table. You can move, or remove it, as needed.
            this.productUnitTableAdapter.Fill(this.standardTradingDbDataSet1.ProductUnit);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.standardTradingDbDataSet1.ProductType);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.standardTradingDbDataSet1.Product);

        }
    }
}
