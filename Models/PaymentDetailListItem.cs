using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models
{
    public class PaymentDetailListItem
    {
        public DateTime Date { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionID { get; set; }
        public string PaymentMethodCode { get; set; }

        public PaymentDetailListItem()
        {

        }

        public PaymentDetailListItem(p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result Entity)
        {
            Date = Entity.DATE;
            TransactionType = Entity.TRANSACTIONTYPE;
            Amount = Entity.AMOUNT;
            PaymentMethod = Entity.PAYMENTMETHOD;
            TransactionID = Entity.TRANSACTION_ID;
            PaymentMethodCode = Entity.PAYMENT_METHOD_CODE;
        }

        public static PaymentDetailListItem[] CreateList(IEnumerable<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result> Entities)
        {
            if (Entities == null)
                return null;

            List<PaymentDetailListItem> Result = new List<PaymentDetailListItem>();
            foreach (p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result Item in Entities)
                Result.Add(new PaymentDetailListItem(Item));
            return Result.ToArray();
        }
    }
}
