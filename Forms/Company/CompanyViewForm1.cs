using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardTradingDataEntry.Forms.Company
{
    public partial class CompanyViewForm1 : Form
    {
        public CompanyViewForm1()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standardTradingDbDataSet1);

        }

        private void CompanyViewForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.PaymentType' table. You can move, or remove it, as needed.
            this.paymentTypeTableAdapter.Fill(this.standardTradingDbDataSet1.PaymentType);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.BillingType' table. You can move, or remove it, as needed.
            this.billingTypeTableAdapter.Fill(this.standardTradingDbDataSet1.BillingType);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.standardTradingDbDataSet1.Company);

        }
    }
}
