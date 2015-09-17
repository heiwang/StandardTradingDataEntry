using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace StandardTradingDataEntry
{
    public partial class StandardTradingRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void EditCompanyButton_Click(object sender, RibbonControlEventArgs e)
        {
            CompanyViewForm viewForm = new CompanyViewForm();
            viewForm.Show();
        }
    }
}
