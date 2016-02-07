using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StandardTradingDataEntry.DTOs
{
    public class CompanyInfo : StandardTradingDataEntry.DTOs.ICompanyInfo
    {

        public string ChineseName
        {
            get;
            set;
        }

        public string EnglishName
        {
            get;
            set;
        }

        public int Order
        {
            get;
            set;
        }

        public string NickName
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
    }
}
