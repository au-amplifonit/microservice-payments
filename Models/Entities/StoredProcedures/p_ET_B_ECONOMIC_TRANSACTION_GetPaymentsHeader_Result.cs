using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models.Entities.StoredProcedures
{
    public class p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result
    {
        public string SALE_NUMBER { get; set; }
        public DateTime SALE_DATE { get; set; }
        public string DOCUMENT_TYPE_CODE { get; set; }
        public string MARKET_TYPE_CODE { get; set; }
        public string STATUS_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string SHOP_CODE { get; set; }
        public string LAPTOP_CODE { get; set; }
        public double TOTAL { get; set; }
        public double TOTAL_PAID { get; set; }
        public double TOTAL_OUTSTANDING { get; set; }
        public double CLIENT_OUTSTANDING { get; set; }
    }
}
