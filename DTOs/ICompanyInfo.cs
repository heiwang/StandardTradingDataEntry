using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardTradingDataEntry.DTOs
{
    public interface ICompanyInfo
    {
        string ChineseName { get; set; }

        string EnglishName { get; set; }

        int Order { get; set; }

        string NickName { get; set; }

        int Id { get; set; }
    }
}
