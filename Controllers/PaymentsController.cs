using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fox.Microservices.Payments.Models;
using Fox.Microservices.Payments.Models.Entities;
using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPITools.Models.Configuration;

namespace Fox.Microservices.Payments.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IOptions<AppSettings> Settings;
        private readonly PaymentsContext DBContext;

        public PaymentsController(IOptions<AppSettings> ASettings, PaymentsContext ADBContext)
        {
            this.Settings = ASettings;
            DBContext = ADBContext;
        }

        /// <summary>
        /// Given a customer ID returns all customer's payments
        /// </summary>
        /// <param name="id">Customer's ID</param>
        /// <returns>Customer's payments</returns>
        [HttpGet("[action]/{id}")]
        public ActionResult<IEnumerable<PaymentInfoListItem>> Customer(string id)
        {
            List<PaymentInfoListItem> Result = new List<PaymentInfoListItem>();
            IQueryable<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result> HeaderList = DBContext.p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader.FromSql("EXECUTE [dbo].[p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader] @CUSTOMER_CODE = {0}", id).Take(Settings.Value.MaxQueryResult);
            IQueryable<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result> FunderList = DBContext.p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails.FromSql("EXECUTE [dbo].[p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails] @CUSTOMER_CODE = {0}", id).Take(Settings.Value.MaxQueryResult);
            IQueryable<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result> PaymentList = DBContext.p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooters.FromSql("EXECUTE [dbo].[p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter] @CUSTOMER_CODE = {0}", id).Take(Settings.Value.MaxQueryResult);

            foreach (p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result Item in HeaderList)
            {
                PaymentInfoListItem ListItem = new PaymentInfoListItem(Item);
                Result.Add(ListItem);
                ListItem.Details = PaymentFunderInfoListItem.CreateList(FunderList?.Where(E => E.SALE_NUMBER == Item.SALE_NUMBER && E.SALE_DATE == Item.SALE_DATE));
                if (ListItem.Details != null)
                {
                    foreach (PaymentFunderInfoListItem FunderItem in ListItem.Details)
                        FunderItem.Payments = PaymentDetailListItem.CreateList(PaymentList.Where(E => E.SALE_DATE == Item.SALE_DATE && E.SALE_NUMBER == Item.SALE_NUMBER && E.INVOICE_TO_CODE == FunderItem.InvoiceToCode));
                }
            }
            return Result;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        // GET api/values
        public ActionResult<IEnumerable<PaymentInfoListItem>> Get()
        {
            return null;
        }
        /*
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
