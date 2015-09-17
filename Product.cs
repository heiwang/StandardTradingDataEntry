//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StandardTradingDataEntry
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.PriceLists = new HashSet<PriceList>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
        }
    
        public int ProductId { get; set; }
        public string EnglishName { get; set; }
        public string ChineseName { get; set; }
        public string Nickname { get; set; }
        public int Category { get; set; }
        public decimal DefaultPrice { get; set; }
        public byte[] Image { get; set; }
    
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
