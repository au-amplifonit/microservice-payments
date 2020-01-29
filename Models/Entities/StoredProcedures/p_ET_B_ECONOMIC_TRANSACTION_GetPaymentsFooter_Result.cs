using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models.Entities.StoredProcedures
{
    public class p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result
    {
        public string SALE_NUMBER { get; set; }
        public DateTime SALE_DATE { get; set; }
        public string INVOICE_TO_CODE { get; set; }
        public DateTime DATE { get; set; }
        public string TRANSACTIONTYPE { get; set; }
        public double AMOUNT { get; set; }
        public string PAYMENTMETHOD { get; set; }
        public string TRANSACTION_ID { get; set; }
        public string PAYMENT_METHOD_CODE { get; set; }
    }
}
