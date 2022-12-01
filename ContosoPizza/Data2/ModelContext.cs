using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ContosoPizza.Models2;

namespace ContosoPizza.Data2
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Dmline> Dmlines { get; set; } = null!;
        public virtual DbSet<Dndasassort> Dndasassorts { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User ID=awc; Password=awc; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=DAS)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("AWC")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);
            });

            modelBuilder.Entity<Dmline>(entity =>
            {
                entity.HasKey(e => new { e.DasBlockNo, e.DasCellNo });

                entity.ToTable("DMLINE");

                entity.Property(e => e.DasBlockNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DAS_BLOCK_NO");

                entity.Property(e => e.DasCellNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DAS_CELL_NO");

                entity.Property(e => e.LastUpdateDate)
                    .HasPrecision(3)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSTIMESTAMP ");

                entity.Property(e => e.LastUpdatePname)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_PNAME");

                entity.Property(e => e.LineQty)
                    .HasPrecision(3)
                    .HasColumnName("LINE_QTY");

                entity.Property(e => e.PpsIndicatorNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PPS_INDICATOR_NO");

                entity.Property(e => e.RegistDate)
                    .HasPrecision(3)
                    .HasColumnName("REGIST_DATE")
                    .HasDefaultValueSql("SYSTIMESTAMP ");

                entity.Property(e => e.RegistPname)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("REGIST_PNAME");
            });

            modelBuilder.Entity<Dndasassort>(entity =>
            {
                entity.HasKey(e => e.InstructionOrder);

                entity.ToTable("DNDASASSORT");

                entity.HasIndex(e => new { e.DasBlockNo, e.SendEnableStatus, e.PpsSendStatus, e.PpsSendRetStatus, e.PpsResultReceiveStatus }, "IDX1_DNDASASSORT");

                entity.HasIndex(e => e.IndicatorNo, "IDX2_DNDASASSORT");

                entity.HasIndex(e => new { e.WmsSendStatus, e.PpsResultReceiveStatus, e.PpsSendStatus }, "IDX3_DNDASASSORT");

                entity.HasIndex(e => e.JobNo, "IDX4_DNDASASSORT");

                entity.HasIndex(e => new { e.PpsSendStatus, e.PpsSendRetStatus, e.PpsResultReceiveStatus }, "IDX5_DNDASASSORT");

                entity.HasIndex(e => new { e.PpsResultReceiveStatus, e.DasCellNo, e.DasBlockNo }, "IDX6_DNDASASSORT");

                entity.Property(e => e.InstructionOrder)
                    .HasPrecision(19)
                    .ValueGeneratedNever()
                    .HasColumnName("INSTRUCTION_ORDER");

                entity.Property(e => e.CountryType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_TYPE");

                entity.Property(e => e.DasBlockNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DAS_BLOCK_NO");

                entity.Property(e => e.DasCellNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DAS_CELL_NO");

                entity.Property(e => e.DasLoadNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DAS_LOAD_NO");

                entity.Property(e => e.DeliveryCode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_CODE");

                entity.Property(e => e.DeliveryCompanyName1)
                    .HasMaxLength(62)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_COMPANY_NAME1");

                entity.Property(e => e.DeliveryCompanyName2)
                    .HasMaxLength(62)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_COMPANY_NAME2");

                entity.Property(e => e.EndFlg)
                    .HasPrecision(1)
                    .HasColumnName("END_FLG")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IndicatorNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INDICATOR_NO");

                entity.Property(e => e.IndicatorRetStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INDICATOR_RET_STATUS");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("JOB_NO");

                entity.Property(e => e.LastUpdateDate)
                    .HasPrecision(3)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSTIMESTAMP ");

                entity.Property(e => e.LastUpdatePname)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_PNAME");

                entity.Property(e => e.LoadNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOAD_NO");

                entity.Property(e => e.MakeDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MAKE_DAY");

                entity.Property(e => e.PackingSummaryLine)
                    .HasPrecision(2)
                    .HasColumnName("PACKING_SUMMARY_LINE");

                entity.Property(e => e.PlanDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PLAN_DAY");

                entity.Property(e => e.PlanQty)
                    .HasPrecision(7)
                    .HasColumnName("PLAN_QTY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PpsResultQty)
                    .HasPrecision(7)
                    .HasColumnName("PPS_RESULT_QTY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PpsResultReceiveDate)
                    .HasPrecision(3)
                    .HasColumnName("PPS_RESULT_RECEIVE_DATE");

                entity.Property(e => e.PpsResultReceiveStatus)
                    .HasPrecision(1)
                    .HasColumnName("PPS_RESULT_RECEIVE_STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PpsRetrySendDate)
                    .HasPrecision(3)
                    .HasColumnName("PPS_RETRY_SEND_DATE");

                entity.Property(e => e.PpsSendDate)
                    .HasPrecision(3)
                    .HasColumnName("PPS_SEND_DATE");

                entity.Property(e => e.PpsSendRetDate)
                    .HasPrecision(3)
                    .HasColumnName("PPS_SEND_RET_DATE");

                entity.Property(e => e.PpsSendRetStatus)
                    .HasPrecision(1)
                    .HasColumnName("PPS_SEND_RET_STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PpsSendRetryStatus)
                    .HasPrecision(1)
                    .HasColumnName("PPS_SEND_RETRY_STATUS")
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.PpsSendStatus)
                    .HasPrecision(1)
                    .HasColumnName("PPS_SEND_STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ReceiveEndFlg)
                    .HasPrecision(1)
                    .HasColumnName("RECEIVE_END_FLG");

                entity.Property(e => e.RegistDate)
                    .HasPrecision(3)
                    .HasColumnName("REGIST_DATE")
                    .HasDefaultValueSql("SYSTIMESTAMP ");

                entity.Property(e => e.RegistPname)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("REGIST_PNAME");

                entity.Property(e => e.ResultQty)
                    .HasPrecision(7)
                    .HasColumnName("RESULT_QTY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RohsType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROHS_TYPE");

                entity.Property(e => e.SendCount)
                    .HasPrecision(2)
                    .HasColumnName("SEND_COUNT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SendEnableDate)
                    .HasPrecision(3)
                    .HasColumnName("SEND_ENABLE_DATE");

                entity.Property(e => e.SendEnableStatus)
                    .HasPrecision(1)
                    .HasColumnName("SEND_ENABLE_STATUS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SendRetryCount)
                    .HasPrecision(1)
                    .HasColumnName("SEND_RETRY_COUNT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShortageQty)
                    .HasPrecision(7)
                    .HasColumnName("SHORTAGE_QTY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TransportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRANSPORT_CODE");

                entity.Property(e => e.WcsSentDate)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WCS_SENT_DATE");

                entity.Property(e => e.WmsSendDate)
                    .HasPrecision(3)
                    .HasColumnName("WMS_SEND_DATE");

                entity.Property(e => e.WmsSendStatus)
                    .HasPrecision(1)
                    .HasColumnName("WMS_SEND_STATUS")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.CustomerId).HasPrecision(10);

                entity.Property(e => e.OrderFulFilled).HasPrecision(7);

                entity.Property(e => e.OrderPlaced).HasPrecision(7);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_OrderDetails_OrderId");

                entity.HasIndex(e => e.ProductId, "IX_OrderDetails_ProductId");

                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.OrderId).HasPrecision(10);

                entity.Property(e => e.ProductId).HasPrecision(10);

                entity.Property(e => e.Quantity).HasPrecision(10);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OD_Orders_OrderId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OD_Products_ProductId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(10);

                entity.Property(e => e.Price).HasColumnType("NUMBER(6,2)");
            });

            modelBuilder.HasSequence("ASSORT_UKEY_SEQ").IsCyclic();

            modelBuilder.HasSequence("INDICATOR_NO_SEQ").IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
