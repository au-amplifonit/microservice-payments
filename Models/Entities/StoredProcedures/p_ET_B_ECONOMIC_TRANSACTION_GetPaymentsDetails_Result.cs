using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models.Entities.StoredProcedures
{
    public class p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result
    {
        public string SALE_NUMBER { get; set; }
        public DateTime SALE_DATE { get; set; }
        public string INVOICE_TO_CODE { get; set; }
        public string FUNDER { get; set; }
        public double TOTAL { get; set; }
        public double TOTAL_PAID { get; set; }
        public double TOTAL_OUTSTANDING { get; set; }
    }
}
