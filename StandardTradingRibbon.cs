using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using StandardTradingDataEntry.Forms.Company;
using StandardTradingDataEntry.Forms.Product;

namespace StandardTradingDataEntry
{
    public partial class StandardTradingRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void EditCompanyButton_Click(object sender, RibbonControlEventArgs e)
        {
            CompanyViewForm1 viewForm = new CompanyViewForm1();
            viewForm.Show();
        }

        private void EditProductButton_Click(object sender, RibbonControlEventArgs e)
        {
            ProductViewForm viewForm = new ProductViewForm();
            viewForm.Show();
        }
    }
}
