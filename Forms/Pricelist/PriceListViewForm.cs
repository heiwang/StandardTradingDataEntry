using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardTradingDataEntry.Forms.Pricelist
{
    public partial class PriceListViewForm : Form
    {
        public PriceListViewForm()
        {
            InitializeComponent();
        }

        private void priceListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priceListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standardTradingDbDataSet1);

        }

        private void PriceListViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.standardTradingDbDataSet1.Product);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.standardTradingDbDataSet1.Company);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.PriceList' table. You can move, or remove it, as needed.
            this.priceListTableAdapter.Fill(this.standardTradingDbDataSet1.PriceList);

        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            this.OnCompanyOrProductChange();
        }

        private void companyId_ValueChanged(object sender, EventArgs e)
        {
            this.OnCompanyOrProductChange();
        }

        private void OnCompanyOrProductChange()
        {
            if (companyId.SelectedItem != null && product.SelectedItem != null)
            {
                var companyIdValue = (int)companyId.SelectedValue;
                var productIdValue = (int)product.SelectedValue;

                var price = this.priceListTableAdapter.GetData()
                    .Where(pl => pl.CompanyId == companyIdValue && pl.ProductId == productIdValue)
                    .Select(c => c.Price);

                priceTextBox.Text = price.Any() ? price.First().ToString("C") : "N/A";

            }

            ((BindingSource) (priceListDataGridView.DataSource)).Filter = string.Format("CompanyId = '{0}'",
                (int) companyId.SelectedValue);
        }


    }
}
