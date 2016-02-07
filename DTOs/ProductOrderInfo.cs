using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StandardTradingDataEntry.DTOs
{
    public class ProductOrderInfo : StandardTradingDataEntry.DTOs.IProductOrderInfo
    {
        public IProductItem ProductItem
        {
            get;
            set;
        }

        public double Quantity
        {
            get;
            set;
        }

        public ICompanyInfo Company
        {
            get;
            set;
        }

        public DateTime OrderDate
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }
    }
}
