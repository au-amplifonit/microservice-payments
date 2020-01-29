using System;
using System.Collections.Generic;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class ET_B_ECONOMIC_TRANSACTION_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string SHOP_CODE { get; set; }
        public string LAPTOP_CODE { get; set; }
        public string TRANSACTION_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public string DEPOSIT_BAG_NUMBER { get; set; }
        public string NOTES { get; set; }
        public string CLAIM_ID { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid? ROWGUID { get; set; }
    }
}
