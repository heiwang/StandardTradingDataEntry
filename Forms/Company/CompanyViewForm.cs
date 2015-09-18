using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StandardTradingDataEntry
{
    public partial class CompanyViewForm : Form
    {
        public CompanyViewForm()
        {
            InitializeComponent();
        }

        private void UpdateCompany_Click(object sender, EventArgs e)
        {

        }

        private void CompanyViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standardTradingDbDataSet.Company' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.BillingType' table. You can move, or remove it, as needed.
            this.billingTypeTableAdapter.Fill(this.standardTradingDbDataSet1.BillingType);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.PaymentType' table. You can move, or remove it, as needed.
            this.paymentTypeTableAdapter.Fill(this.standardTradingDbDataSet1.PaymentType);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.standardTradingDbDataSet1.Company);
            // TODO: This line of code loads data into the 'standardTradingDbDataSet.BillingType' table. You can move, or remove it, as needed.
            //var query = from c in context.Companies
            //            select c;

            //var companies = query.ToList();
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = companies;
            //dataGridView1.Refresh();
            

        }

        private void companyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
