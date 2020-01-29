using System;
using System.Collections.Generic;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class SA_B_SALES_HEADER
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public DateTime SALE_DATE { get; set; }
        public string SALE_NUMBER { get; set; }
        public string DOCUMENT_TYPE_CODE { get; set; }
        public string STATUS_CODE { get; set; }
        public DateTime? DT_UPDATE_STATUS { get; set; }
        public string VALIDATION_STATUS_CODE { get; set; }
        public DateTime? DT_UPDATE_VALIDATION_STATUS { get; set; }
        public string SHOP_CODE { get; set; }
        public string LAPTOP_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string EMPLOYEE_CODE { get; set; }
        public string MARKET_TYPE_CODE { get; set; }
        public string PAYMENT_MODE_CODE { get; set; }
        public string PAYMENT_METHOD_CODE { get; set; }
        public string PAYER_CODE { get; set; }
        public string INVOICE_TO_CODE { get; set; }
        public string CURRENCY_CODE { get; set; }
        public double? CURRENCY_RATE { get; set; }
        public double? GROSS_AMOUNT { get; set; }
        public DateTime? DT_EXPIRATION { get; set; }
        public DateTime? DT_PRESCRIPTION { get; set; }
        public string PRESCRIPTION_NUMBER { get; set; }
        public string PRESCRIPTION_LEVEL_CODE { get; set; }
        public string PRESCRIPTION_SIDE_CODE { get; set; }
        public DateTime? SALE_CANCELLATION_DATE { get; set; }
        public string SALE_CANCELLATION_NUMBER { get; set; }
        public string DOCUMENT_TYPE_CODE_REF { get; set; }
        public DateTime? DOCUMENT_DATE_REF { get; set; }
        public string DOCUMENT_NUMBER_REF { get; set; }
        public string PREVIOUS_DOCUMENT_TYPE_CODE { get; set; }
        public DateTime? PREVIOUS_DOCUMENT_DATE { get; set; }
        public string PREVIOUS_DOCUMENT_NUMBER { get; set; }
        public string NEXT_DOCUMENT_TYPE_CODE { get; set; }
        public DateTime? NEXT_DOCUMENT_DATE { get; set; }
        public string NEXT_DOCUMENT_NUMBER { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public string DELIVERY_EMPLOYEE_CODE { get; set; }
        public DateTime? JOURNEY_DATE { get; set; }
        public string JOURNEY_NUMBER { get; set; }
        public string REASON_CODE { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public Guid ROWGUID { get; set; }
    }
}
