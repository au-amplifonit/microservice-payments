using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class PaymentsContext : DbContext
    {
        public virtual DbSet<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result> p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader { get; set; }
        public virtual DbSet<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result> p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails { get; set; }
        public virtual DbSet<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result> p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooters { get; set; }

        //TODO: REMEMBER TO ADD THIS CALL TO THE OnModelCreating OF THE DBContext each time it's updated
        protected void RegisterStoredProcedurePK(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result>().HasKey(table => new
            {
                table.COMPANY_CODE,
                table.DIVISION_CODE,
                table.SALE_NUMBER,
                table.SALE_DATE
            }).HasName("PK_p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsHeader_Result");

            modelBuilder.Entity<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result>().HasKey(table => new
            {
                table.SALE_NUMBER,
                table.SALE_DATE,
                table.INVOICE_TO_CODE
            }).HasName("PK_p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsDetails_Result");

            modelBuilder.Entity<p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result>().HasKey(table => new
            {
                table.SALE_NUMBER,
                table.SALE_DATE,
                table.INVOICE_TO_CODE,
                table.DATE,
                table.TRANSACTION_ID
            }).HasName("PK_p_ET_B_ECONOMIC_TRANSACTION_GetPaymentsFooter_Result");
        }
    }   
}
