using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models
{
    public class PaymentInfoListItem
    {
        public string SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string DocumentTypeCode { get; set; }
        public string MarketTypeCode { get; set; }
        public string StatusCode { get; set; }
        public string ShopCode { get; set; }
        public double Total { get; set; }
        public double TotalPaid { get; set; }
        public double TotalOutstanding { get; set; }
        public double ClientOutstanding { get; set; }

        //NOT USED
        /*
        public string DocumentTypeDescription { get; set; }
        public string MarketTypeDescription { get; set; }
        public string StatusDescription { get; set; }
        public string ShopDescrption { get; set; }
        */

        public PaymentFunderInfoListItem[] Details { get; set; }

        public PaymentInfoListItem()
        {

        }

        public PaymentInfoListItem(p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result Entity)
        {
            SaleNumber = Entity.SALE_NUMBER;
            SaleDate = Entity.SALE_DATE;
            DocumentTypeCode = Entity.DOCUMENT_TYPE_CODE;
            MarketTypeCode = Entity.MARKET_TYPE_CODE;
            StatusCode = Entity.STATUS_CODE;
            ShopCode = Entity.SHOP_CODE;
            Total = Entity.TOTAL;
            TotalPaid = Entity.TOTAL_PAID;
            TotalOutstanding = Entity.TOTAL_OUTSTANDING;
            ClientOutstanding = Entity.CLIENT_OUTSTANDING;
        }
    }
}
