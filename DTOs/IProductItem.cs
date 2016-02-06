using System;
using System.Drawing;
namespace StandardTradingDataEntry.DTOs
{
    interface IProductItem
    {
        ProductCategory Category { get; set; }
        
        string ChineseName { get; set; }
        
        string EnglishName { get; set; }
        
        Image Image { get; set; }
        
        string NickName { get; set; }
        
        double Price { get; set; }
        
        int ProductId { get; set; }
        
        string Unit { get; set; }

        double Significance { get; set; }
    }
}
