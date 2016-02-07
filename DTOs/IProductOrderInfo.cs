using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardTradingDataEntry.DTOs
{
    interface IProductOrderInfo
    {
        IProductItem ProductItem { get; set; }

        double Quantity { get; set; }

        ICompanyInfo Company { get; set; }

        DateTime OrderDate { get; set; }

        Guid Id { get; set; }
    }
}
