using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models
{
    public class PaymentFunderInfoListItem
    {
        public string InvoiceToCode { get; set; }
        public string Funder { get; set; }
        public double Total { get; set; }
        public double TotalPaid { get; set; }
        public double TotalOutstanding { get; set; }
        public PaymentDetailListItem[] Payments { get; set; }

        public PaymentFunderInfoListItem()
        {

        }

        public PaymentFunderInfoListItem(p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result Entity)
        {
            InvoiceToCode = Entity.INVOICE_TO_CODE;
            Funder = Entity.FUNDER;
            Total = Entity.TOTAL;
            TotalPaid = Entity.TOTAL_PAID;
            TotalOutstanding = Entity.TOTAL_OUTSTANDING;
        }

        public static PaymentFunderInfoListItem[] CreateList(IEnumerable<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result> Entities)
        {
            if (Entities == null)
                return null;

            List<PaymentFunderInfoListItem> Result = new List<PaymentFunderInfoListItem>();
            foreach (p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result Item in Entities)
                Result.Add(new PaymentFunderInfoListItem(Item));
            return Result.ToArray();
        }
    }
}
