using System;
using Fox.Microservices.Payments.Models.Entities.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fox.Microservices.Payments.Models.Entities
{
    public partial class PaymentsContext : DbContext
    {
        public PaymentsContext()
        {
        }

        public PaymentsContext(DbContextOptions<PaymentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ET_B_ECONOMIC_TRANSACTION> ET_B_ECONOMIC_TRANSACTION { get; set; }
        public virtual DbSet<ET_B_ECONOMIC_TRANSACTION_EXT_AUS> ET_B_ECONOMIC_TRANSACTION_EXT_AUS { get; set; }
        public virtual DbSet<SA_B_SALES_HEADER> SA_B_SALES_HEADER { get; set; }
        public virtual DbSet<SA_B_SALES_HEADER_EXT_AUS> SA_B_SALES_HEADER_EXT_AUS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=CAU02DB01FOXSIT.D09.ROOT.SYS;Database=FoxAustralia_SIT2;Trusted_Connection=False;User ID=foxuser;Password=Df0x35ZZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            RegisterStoredProcedurePK(modelBuilder);

            modelBuilder.Entity<ET_B_ECONOMIC_TRANSACTION>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.LAPTOP_CODE, e.TRANSACTION_ID });

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("UQ_ET_B_ECONOMIC_TRANSACTION_ROWGUID")
                    .IsUnique();

                entity.HasIndex(e => new { e.CASH_CLOSURE_NUMBER, e.CASH_CLOSURE_DATE })
                    .HasName("missing_index_47620");

                entity.HasIndex(e => new { e.CASH_CLOSURE_NUMBER, e.USERINSERT, e.FINANCIAL_IN })
                    .HasName("missing_index_54911");

                entity.HasIndex(e => new { e.DOCUMENT_NUMBER, e.DOCUMENT_DATE, e.FINANCIAL_IN })
                    .HasName("IDX_ET_B_ECONOMIC_TRANSACTION_001");

                entity.HasIndex(e => new { e.CASH_CLOSURE_DATE, e.FINANCIAL_IN, e.CASH_CLOSURE_NUMBER, e.USERINSERT })
                    .HasName("missing_index_54970");

                entity.HasIndex(e => new { e.CASH_CLOSURE_DATE, e.USERINSERT, e.FINANCIAL_IN, e.CASH_CLOSURE_NUMBER })
                    .HasName("missing_index_54952");

                entity.HasIndex(e => new { e.CASH_CLOSURE_NUMBER, e.CASH_CLOSURE_DATE, e.FINANCIAL_IN, e.USERINSERT })
                    .HasName("missing_index_54950");

                entity.HasIndex(e => new { e.CASH_CLOSURE_NUMBER, e.CASH_CLOSURE_DATE, e.USERINSERT, e.FINANCIAL_IN })
                    .HasName("missing_index_54914");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.CASH_CLOSURE_NUMBER })
                    .HasName("missing_index_47593");

                entity.HasIndex(e => new { e.DOCUMENT_TYPE_CODE, e.DOCUMENT_NUMBER, e.DOCUMENT_DATE, e.TRANSACTION_TYPE_CODE })
                    .HasName("IDX_ET_B_ECONOMIC_TRANSACTION_TRANSACTION_TYPE_CODE");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.DOCUMENT_TYPE_CODE, e.DOCUMENT_NUMBER, e.TRANSACTION_DATE })
                    .HasName("IDX_ET_B_ECONOMIC_TRANSACTION_TRANSACTION_DATE");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.BANK_DEPOSIT_DATE, e.PAYMENT_METHOD_CODE })
                    .HasName("missing_index_47597");

                entity.HasIndex(e => new { e.DOCUMENT_TYPE_CODE, e.COMPANY_CODE, e.DIVISION_CODE, e.DOCUMENT_NUMBER, e.TRANSACTION_DATE })
                    .HasName("IDX_ET_B_ECONOMIC_TRANSACTION_DOCUMENT_NUMBER_TRANSACTION_DATE");

                entity.HasIndex(e => new { e.PAYER_CODE, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE })
                    .HasName("IDX_ET_B_ECONOMIC_TRANSACTION_Payer_Comp_Div_Shop_Tran");

                entity.HasIndex(e => new { e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE })
                    .HasName("missing_index_53195");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.CASH_CLOSURE_NUMBER, e.CASH_CLOSURE_DATE, e.TRANSACTION_TYPE_CODE })
                    .HasName("missing_index_47720");

                entity.HasIndex(e => new { e.FINANCIAL_OUT, e.CASH_CLOSURE_DATE, e.PAYER_CODE, e.FINANCIAL_IN, e.CASH_CLOSURE_NUMBER, e.USERINSERT })
                    .HasName("missing_index_54981");

                entity.HasIndex(e => new { e.PAYER_CODE, e.FINANCIAL_OUT, e.CASH_CLOSURE_DATE, e.FINANCIAL_IN, e.CASH_CLOSURE_NUMBER, e.USERINSERT })
                    .HasName("missing_index_54976");

                entity.HasIndex(e => new { e.LAPTOP_CODE, e.TRANSACTION_ID, e.PAYMENT_METHOD_CODE, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.CASH_CLOSURE_NUMBER })
                    .HasName("missing_index_47595");

                entity.HasIndex(e => new { e.TRANSACTION_ID, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.PAYMENT_METHOD_CODE })
                    .HasName("missing_index_47602");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.LAPTOP_CODE, e.TRANSACTION_ID, e.DT_INSERT, e.USERUPDATE, e.DT_UPDATE })
                    .HasName("missing_index_47639");

                entity.HasIndex(e => new { e.ECONOMIC_IN, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE, e.CASH_CLOSURE_CATEGORY_CODE })
                    .HasName("missing_index_53189");

                entity.HasIndex(e => new { e.ECONOMIC_OUT, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE, e.CASH_CLOSURE_CATEGORY_CODE })
                    .HasName("missing_index_53187");

                entity.HasIndex(e => new { e.FINANCIAL_IN, e.FINANCIAL_OUT, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.PAYMENT_METHOD_CODE })
                    .HasName("missing_index_47599");

                entity.HasIndex(e => new { e.LAPTOP_CODE, e.TRANSACTION_ID, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.PAYMENT_METHOD_CODE })
                    .HasName("missing_index_47604");

                entity.HasIndex(e => new { e.TRANSACTION_ID, e.DOCUMENT_TYPE_CODE, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.CASH_CLOSURE_CATEGORY_CODE })
                    .HasName("missing_index_53200");

                entity.HasIndex(e => new { e.TRANSACTION_ID, e.DOCUMENT_TYPE_CODE, e.PAYMENT_METHOD_CODE, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.TRANSACTION_TYPE_CODE })
                    .HasName("missing_index_53197");

                entity.HasIndex(e => new { e.DOCUMENT_TYPE_CODE, e.FINANCIAL_IN, e.FINANCIAL_OUT, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE, e.PAYMENT_METHOD_CODE })
                    .HasName("missing_index_53191");

                entity.HasIndex(e => new { e.DOCUMENT_TYPE_CODE, e.PAYMENT_METHOD_CODE, e.FINANCIAL_IN, e.FINANCIAL_OUT, e.BANK_DEPOSIT_DATE, e.BANK_DEPOSIT_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.TRANSACTION_TYPE_CODE })
                    .HasName("missing_index_53193");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.SHOP_CODE).HasMaxLength(3);

                entity.Property(e => e.LAPTOP_CODE).HasMaxLength(3);

                entity.Property(e => e.TRANSACTION_ID).HasMaxLength(13);

                entity.Property(e => e.ACCOUNT_NUMBER).HasMaxLength(10);

                entity.Property(e => e.BANK_DEPOSIT_DATE).HasColumnType("date");

                entity.Property(e => e.BANK_DEPOSIT_NUMBER).HasMaxLength(8);

                entity.Property(e => e.CASH_CLOSURE_CATEGORY_CODE).HasMaxLength(3);

                entity.Property(e => e.CASH_CLOSURE_DATE).HasColumnType("date");

                entity.Property(e => e.CASH_CLOSURE_NUMBER).HasMaxLength(8);

                entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);

                entity.Property(e => e.DOCUMENT_DATE).HasColumnType("date");

                entity.Property(e => e.DOCUMENT_NUMBER).HasMaxLength(6);

                entity.Property(e => e.DOCUMENT_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.EMPLOYEE_CODE).HasMaxLength(8);

                entity.Property(e => e.EXPENSE_FUND_DATE).HasColumnType("date");

                entity.Property(e => e.EXPENSE_FUND_NUMBER).HasMaxLength(6);

                entity.Property(e => e.FINANCIAL_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.FLG_DELETED).HasMaxLength(1);

                entity.Property(e => e.FLG_PROCESSED).HasMaxLength(1);

                entity.Property(e => e.PAYER_CODE).HasMaxLength(8);

                entity.Property(e => e.PAYMENT_METHOD_CODE).HasMaxLength(3);

                entity.Property(e => e.RECEIPT_NUMBER).HasMaxLength(8);

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TRANSACTION_DATE).HasColumnType("datetime");

                entity.Property(e => e.TRANSACTION_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);
            });

            modelBuilder.Entity<ET_B_ECONOMIC_TRANSACTION_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.LAPTOP_CODE, e.TRANSACTION_ID });

                entity.HasIndex(e => new { e.NOTES, e.COMPANY_CODE, e.DIVISION_CODE, e.TRANSACTION_ID })
                    .HasName("missing_index_28262");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.SHOP_CODE).HasMaxLength(3);

                entity.Property(e => e.LAPTOP_CODE).HasMaxLength(3);

                entity.Property(e => e.TRANSACTION_ID).HasMaxLength(13);

                entity.Property(e => e.CLAIM_ID).HasMaxLength(8);

                entity.Property(e => e.DEPOSIT_BAG_NUMBER).HasMaxLength(250);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.NOTES).HasColumnType("nvarchar(max)");

                entity.Property(e => e.TRANSACTION_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);
            });

            modelBuilder.Entity<SA_B_SALES_HEADER>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER });

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("UQ_SA_B_SALES_HEADER_ROWGUID")
                    .IsUnique();

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE })
                    .HasName("IDX_SA_B_SALES_HEADER_CU_B_ADDRESS_BOOK");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.MARKET_TYPE_CODE })
                    .HasName("IDX_SA_B_SALES_HEADER_SA_S_MARKET_TYPE");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.PRESCRIPTION_LEVEL_CODE })
                    .HasName("IDX_SA_B_SALES_HEADER_SA_S_PRESCRIPTION_LEVEL");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_NUMBER })
                    .HasName("missing_index_47729");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_CANCELLATION_DATE, e.SALE_NUMBER })
                    .HasName("missing_index_54532");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_CANCELLATION_NUMBER, e.SALE_NUMBER })
                    .HasName("missing_index_54534");

                entity.HasIndex(e => new { e.SALE_NUMBER, e.DOCUMENT_TYPE_CODE, e.CUSTOMER_CODE })
                    .HasName("IX_SA_B_SALES_HEADER");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.JOURNEY_DATE, e.JOURNEY_NUMBER })
                    .HasName("IDX_SA_B_SALES_HEADER_SA_B_JOURNEY");

                entity.HasIndex(e => new { e.NEXT_DOCUMENT_TYPE_CODE, e.NEXT_DOCUMENT_DATE, e.NEXT_DOCUMENT_NUMBER, e.MARKET_TYPE_CODE })
                    .HasName("IDX_SA_B_SALES_HEADER_MARKET_TYPE_CODE");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_NUMBER, e.NEXT_DOCUMENT_DATE, e.NEXT_DOCUMENT_NUMBER, e.DOCUMENT_TYPE_CODE })
                    .HasName("missing_index_51445");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_NUMBER, e.COMPANY_CODE, e.DIVISION_CODE, e.DOCUMENT_TYPE_CODE, e.SHOP_CODE })
                    .HasName("missing_index_53176");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_NUMBER, e.NEXT_DOCUMENT_DATE, e.NEXT_DOCUMENT_NUMBER, e.DOCUMENT_TYPE_CODE, e.NEXT_DOCUMENT_TYPE_CODE })
                    .HasName("missing_index_51440");

                entity.HasIndex(e => new { e.SHOP_CODE, e.CUSTOMER_CODE, e.EMPLOYEE_CODE, e.GROSS_AMOUNT, e.SALE_DATE, e.SALE_NUMBER })
                    .HasName("IDX_SA_B_SALES_HEADER_003");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER, e.CUSTOMER_CODE, e.USERUPDATE, e.DT_INSERT, e.DT_UPDATE })
                    .HasName("missing_index_47634");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER, e.DOCUMENT_TYPE_CODE, e.USERUPDATE, e.DT_INSERT, e.DT_UPDATE })
                    .HasName("missing_index_47631");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER, e.CUSTOMER_CODE, e.DELIVERY_DATE, e.STATUS_CODE, e.USERINSERT, e.USERUPDATE })
                    .HasName("missing_index_54542");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER, e.CUSTOMER_CODE, e.EMPLOYEE_CODE, e.MARKET_TYPE_CODE, e.GROSS_AMOUNT, e.NEXT_DOCUMENT_NUMBER, e.DOCUMENT_TYPE_CODE, e.STATUS_CODE })
                    .HasName("SA_B_SALES_HEADER_STATUS_CODE");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.SALE_DATE).HasColumnType("date");

                entity.Property(e => e.SALE_NUMBER).HasMaxLength(6);

                entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);

                entity.Property(e => e.CUSTOMER_CODE).HasMaxLength(8);

                entity.Property(e => e.DELIVERY_DATE).HasColumnType("date");

                entity.Property(e => e.DELIVERY_EMPLOYEE_CODE).HasMaxLength(8);

                entity.Property(e => e.DOCUMENT_DATE_REF).HasColumnType("date");

                entity.Property(e => e.DOCUMENT_NUMBER_REF).HasMaxLength(6);

                entity.Property(e => e.DOCUMENT_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.DOCUMENT_TYPE_CODE_REF).HasMaxLength(3);

                entity.Property(e => e.DT_EXPIRATION).HasColumnType("date");

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_PRESCRIPTION).HasColumnType("date");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE_STATUS).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE_VALIDATION_STATUS).HasColumnType("datetime");

                entity.Property(e => e.EMPLOYEE_CODE).HasMaxLength(8);

                entity.Property(e => e.INVOICE_TO_CODE).HasMaxLength(8);

                entity.Property(e => e.JOURNEY_DATE).HasColumnType("date");

                entity.Property(e => e.JOURNEY_NUMBER).HasMaxLength(8);

                entity.Property(e => e.LAPTOP_CODE).HasMaxLength(3);

                entity.Property(e => e.MARKET_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.NEXT_DOCUMENT_DATE).HasColumnType("date");

                entity.Property(e => e.NEXT_DOCUMENT_NUMBER).HasMaxLength(8);

                entity.Property(e => e.NEXT_DOCUMENT_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.PAYER_CODE).HasMaxLength(8);

                entity.Property(e => e.PAYMENT_METHOD_CODE).HasMaxLength(3);

                entity.Property(e => e.PAYMENT_MODE_CODE).HasMaxLength(3);

                entity.Property(e => e.PRESCRIPTION_LEVEL_CODE).HasMaxLength(3);

                entity.Property(e => e.PRESCRIPTION_NUMBER).HasMaxLength(6);

                entity.Property(e => e.PRESCRIPTION_SIDE_CODE).HasMaxLength(3);

                entity.Property(e => e.PREVIOUS_DOCUMENT_DATE).HasColumnType("date");

                entity.Property(e => e.PREVIOUS_DOCUMENT_NUMBER).HasMaxLength(8);

                entity.Property(e => e.PREVIOUS_DOCUMENT_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.REASON_CODE).HasMaxLength(3);

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SALE_CANCELLATION_DATE).HasColumnType("date");

                entity.Property(e => e.SALE_CANCELLATION_NUMBER).HasMaxLength(6);

                entity.Property(e => e.SHOP_CODE).HasMaxLength(3);

                entity.Property(e => e.STATUS_CODE).HasMaxLength(3);

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.Property(e => e.VALIDATION_STATUS_CODE).HasMaxLength(3);
            });

            modelBuilder.Entity<SA_B_SALES_HEADER_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_DATE, e.SALE_NUMBER });

                entity.HasIndex(e => e.DT_INSERT)
                    .HasName("missing_index_11055");

                entity.HasIndex(e => e.DT_UPDATE)
                    .HasName("missing_index_11053");

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("missing_index_10246");

                entity.HasIndex(e => e.SALE_NUMBER)
                    .HasName("missing_index_11860");

                entity.HasIndex(e => new { e.DT_INSERT, e.USERINSERT })
                    .HasName("missing_index_11037");

                entity.HasIndex(e => new { e.DT_UPDATE, e.USERINSERT })
                    .HasName("missing_index_11035");

                entity.HasIndex(e => new { e.SALE_DATE, e.SALE_NUMBER })
                    .HasName("missing_index_3811");

                entity.HasIndex(e => new { e.USERINSERT, e.DT_UPDATE })
                    .HasName("missing_index_11031");

                entity.HasIndex(e => new { e.VOUCHER_ID, e.SALE_NUMBER })
                    .HasName("missing_index_11858");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_NUMBER })
                    .HasName("missing_index_14373");

                entity.HasIndex(e => new { e.TRIAL_RETURN_DATE, e.TRIAL_EXTENSION_DATE, e.EXTENSION_STATUS, e.EXTENSION_REASON, e.DT_UPDATE, e.COMPANY_CODE, e.DIVISION_CODE, e.SALE_NUMBER })
                    .HasName("missing_index_14371");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.SALE_DATE).HasColumnType("date");

                entity.Property(e => e.SALE_NUMBER).HasMaxLength(6);

                entity.Property(e => e.CUSTOMER_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.DELIVERY_SHOP_CODE).HasMaxLength(3);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.DVA_APPROVAL_NUMBER).HasMaxLength(15);

                entity.Property(e => e.DVA_CLIENT_NUMBER).HasMaxLength(12);

                entity.Property(e => e.EXTENSION_REASON).HasColumnType("nvarchar(max)");

                entity.Property(e => e.EXTENSION_STATUS).HasMaxLength(3);

                entity.Property(e => e.FLG_BILLED).HasMaxLength(1);

                entity.Property(e => e.FLG_RB)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.FUNDING_TYPE_CREATED).HasMaxLength(50);

                entity.Property(e => e.GE_CREDIT_CARE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.INSURANCE_CODE).HasMaxLength(8);

                entity.Property(e => e.IS_TOPUP)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.MANUFACTURER_COMMENT).HasMaxLength(255);

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RaptorInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.SALE_NUMBER_VC).HasMaxLength(6);

                entity.Property(e => e.SALE_TYPE_CODE).HasMaxLength(3);

                entity.Property(e => e.SIDE_CODE_FOR_CLAIM).HasMaxLength(1);

                entity.Property(e => e.TRIAL_EXTENSION_DATE).HasColumnType("datetime");

                entity.Property(e => e.TRIAL_RETURN_DATE).HasColumnType("datetime");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.Property(e => e.VALIDATION_STATUS_CODE).HasMaxLength(3);

                entity.Property(e => e.VISITING_SHOP_CODE).HasMaxLength(8);

                entity.Property(e => e.VISITING_TYPE_CODE).HasMaxLength(2);

                entity.Property(e => e.VOUCHER_ID).HasMaxLength(19);
            });

            modelBuilder.HasSequence("NextFoxid").StartsAt(0);

            modelBuilder.HasSequence("GETNEXTBATCHNUMBER").StartsAt(200);

            modelBuilder.HasSequence("NextFoxCouponid").StartsAt(0);

            modelBuilder.HasSequence("NextFoxid").StartsAt(4000);

            modelBuilder.HasSequence("NextFoxVoucherId");
        }
    }
}
