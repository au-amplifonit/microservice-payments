using System;
using System.Collections.Generic;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class ET_B_ECONOMIC_TRANSACTION
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string SHOP_CODE { get; set; }
        public string LAPTOP_CODE { get; set; }
        public string TRANSACTION_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public string TRANSACTION_TYPE_CODE { get; set; }
        public string CASH_CLOSURE_CATEGORY_CODE { get; set; }
        public string PAYER_CODE { get; set; }
        public string DOCUMENT_TYPE_CODE { get; set; }
        public string DOCUMENT_NUMBER { get; set; }
        public DateTime? DOCUMENT_DATE { get; set; }
        public string PAYMENT_METHOD_CODE { get; set; }
        public string TRANSACTION_NOTE { get; set; }
        public Guid? GROUP_ID { get; set; }
        public string ACCOUNT_NUMBER { get; set; }
        public string CURRENCY_CODE { get; set; }
        public double? CURRENCY_RATE { get; set; }
        public double? FINANCIAL_IN { get; set; }
        public double? FINANCIAL_OUT { get; set; }
        public double? ECONOMIC_IN { get; set; }
        public double? ECONOMIC_OUT { get; set; }
        public string FINANCIAL_TYPE_CODE { get; set; }
        public DateTime? BANK_DEPOSIT_DATE { get; set; }
        public string BANK_DEPOSIT_NUMBER { get; set; }
        public string CASH_CLOSURE_NUMBER { get; set; }
        public DateTime? CASH_CLOSURE_DATE { get; set; }
        public string EMPLOYEE_CODE { get; set; }
        public string RECEIPT_NUMBER { get; set; }
        public string EXPENSE_FUND_NUMBER { get; set; }
        public DateTime? EXPENSE_FUND_DATE { get; set; }
        public string FLG_PROCESSED { get; set; }
        public string FLG_DELETED { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid ROWGUID { get; set; }
    }
}
