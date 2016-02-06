using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StandardTradingDataEntry.DTOs
{
    public class ProductItem : StandardTradingDataEntry.DTOs.IProductItem
    {
        public int ProductId { get; set;}

        public string EnglishName { get; set; }

        public string ChineseName { get; set; }

        public string NickName { get; set; }

        public string Unit { get; set; }

        public ProductCategory Category { get; set; }

        public double Price { get; set; }

        public Image Image { get; set; }

        public double Significance { get; set; }
    }
}
