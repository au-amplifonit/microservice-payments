using System;
using System.Collections.Generic;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class SA_B_SALES_HEADER_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public DateTime SALE_DATE { get; set; }
        public string SALE_NUMBER { get; set; }
        public string DELIVERY_SHOP_CODE { get; set; }
        public string CUSTOMER_TYPE_CODE { get; set; }
        public string INSURANCE_CODE { get; set; }
        public string SALE_TYPE_CODE { get; set; }
        public DateTime? TRIAL_RETURN_DATE { get; set; }
        public DateTime? TRIAL_EXTENSION_DATE { get; set; }
        public string EXTENSION_STATUS { get; set; }
        public string EXTENSION_REASON { get; set; }
        public string FUNDING_TYPE_CREATED { get; set; }
        public string FLG_BILLED { get; set; }
        public string IS_TOPUP { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid ROWGUID { get; set; }
        public string VOUCHER_ID { get; set; }
        public string MANUFACTURER_COMMENT { get; set; }
        public string SIDE_CODE_FOR_CLAIM { get; set; }
        public string VISITING_TYPE_CODE { get; set; }
        public string VISITING_SHOP_CODE { get; set; }
        public string GE_CREDIT_CARE { get; set; }
        public string VALIDATION_STATUS_CODE { get; set; }
        public bool? IS_FROM_OPEN_SALES_TOOL { get; set; }
        public string SALE_NUMBER_VC { get; set; }
        public string DVA_CLIENT_NUMBER { get; set; }
        public string DVA_APPROVAL_NUMBER { get; set; }
        public DateTime? RaptorInvoiceDate { get; set; }
        public string FLG_RB { get; set; }
    }
}
