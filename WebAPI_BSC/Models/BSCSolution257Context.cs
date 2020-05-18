using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Xml;
using WebAPI_BSC.Controllers;
using WebAPI_BSC.Controllers.OperationSpecificModels;
namespace WebAPI_BSC.Models
{
    public partial class BSCSolution257Context : DbContext
    {
        public BSCSolution257Context()
        {
        }

        public BSCSolution257Context(DbContextOptions<BSCSolution257Context> options)
            : base(options)
        {
        }
       // public DbQuery<Object> GenericModel { get; set; }

        public DbQuery<StockSupplierModel> StockSupplierModels { get; set; }
        public DbQuery<GroupModel> GroupModels { get; set; }
        public virtual DbSet<CashEntryLineStatusTable> CashEntryLineStatusTable { get; set; }
        public virtual DbSet<CashEntryLineTable> CashEntryLineTable { get; set; }
        public virtual DbSet<CashEntryLineTypeTable> CashEntryLineTypeTable { get; set; }
        public virtual DbSet<CashEntryStatusTable> CashEntryStatusTable { get; set; }
        public virtual DbSet<CashEntryTable> CashEntryTable { get; set; }
        public virtual DbSet<CashEntryTypeTable> CashEntryTypeTable { get; set; }
        public virtual DbSet<CashLocationGlaccountTable> CashLocationGlaccountTable { get; set; }
        public virtual DbSet<CashLocationGroupTable> CashLocationGroupTable { get; set; }
        public virtual DbSet<CashLocationStatusTable> CashLocationStatusTable { get; set; }
        public virtual DbSet<CashLocationTable> CashLocationTable { get; set; }
        public virtual DbSet<CashLocationTypeTable> CashLocationTypeTable { get; set; }
        public virtual DbSet<CashWorkLiveTable> CashWorkLiveTable { get; set; }
        public virtual DbSet<CashWorkTable> CashWorkTable { get; set; }
        public virtual DbSet<DeliveryGraphTable> DeliveryGraphTable { get; set; }
        public virtual DbSet<RsWaybillConfirmationStatusTable> RsWaybillConfirmationStatusTable { get; set; }
        public virtual DbSet<RsWaybillLineTable> RsWaybillLineTable { get; set; }
        public virtual DbSet<RsWaybillStatusTable> RsWaybillStatusTable { get; set; }
        public virtual DbSet<RsWaybillTable> RsWaybillTable { get; set; }
        public virtual DbSet<RsWaybillTypeTable> RsWaybillTypeTable { get; set; }
        public virtual DbSet<RslogTable> RslogTable { get; set; }
        public virtual DbSet<RsmessageGroupTable> RsmessageGroupTable { get; set; }
        public virtual DbSet<RsmessageStatusTable> RsmessageStatusTable { get; set; }
        public virtual DbSet<RsmessageTable> RsmessageTable { get; set; }
        public virtual DbSet<RsmessageTypeTable> RsmessageTypeTable { get; set; }
        public virtual DbSet<RssyncProcessTable> RssyncProcessTable { get; set; }
        public virtual DbSet<RswaybillWorkTable> RswaybillWorkTable { get; set; }
        public virtual DbSet<ShellComputerGroupTable> ShellComputerGroupTable { get; set; }
        public virtual DbSet<ShellComputerStatusTable> ShellComputerStatusTable { get; set; }
        public virtual DbSet<ShellComputerTable> ShellComputerTable { get; set; }
        public virtual DbSet<ShellComputerTypeTable> ShellComputerTypeTable { get; set; }
        public virtual DbSet<ShellComputerUserTable> ShellComputerUserTable { get; set; }
        public virtual DbSet<ShellDataGroupTable> ShellDataGroupTable { get; set; }
        public virtual DbSet<ShellDataRightTable> ShellDataRightTable { get; set; }
        public virtual DbSet<ShellDataSearchTable> ShellDataSearchTable { get; set; }
        public virtual DbSet<ShellDataSortTable> ShellDataSortTable { get; set; }
        public virtual DbSet<ShellDataStatusTable> ShellDataStatusTable { get; set; }
        public virtual DbSet<ShellDataTable> ShellDataTable { get; set; }
        public virtual DbSet<ShellDataTypeTable> ShellDataTypeTable { get; set; }
        public virtual DbSet<ShellDiagnoseGroupTable> ShellDiagnoseGroupTable { get; set; }
        public virtual DbSet<ShellDiagnoseStatusTable> ShellDiagnoseStatusTable { get; set; }
        public virtual DbSet<ShellDiagnoseTable> ShellDiagnoseTable { get; set; }
        public virtual DbSet<ShellDiagnoseTypeTable> ShellDiagnoseTypeTable { get; set; }
        public virtual DbSet<ShellDllgroupTable> ShellDllgroupTable { get; set; }
        public virtual DbSet<ShellDlllanguageTable> ShellDlllanguageTable { get; set; }
        public virtual DbSet<ShellDllstatusTable> ShellDllstatusTable { get; set; }
        public virtual DbSet<ShellDlltable> ShellDlltable { get; set; }
        public virtual DbSet<ShellDlltypeTable> ShellDlltypeTable { get; set; }
        public virtual DbSet<ShellImportExcelTable> ShellImportExcelTable { get; set; }
        public virtual DbSet<ShellLanguageStatusTable> ShellLanguageStatusTable { get; set; }
        public virtual DbSet<ShellLanguageTable> ShellLanguageTable { get; set; }
        public virtual DbSet<ShellLanguageTypeTable> ShellLanguageTypeTable { get; set; }
        public virtual DbSet<ShellLogTable> ShellLogTable { get; set; }
        public virtual DbSet<ShellMessageGroupTable> ShellMessageGroupTable { get; set; }
        public virtual DbSet<ShellMessageStatusTable> ShellMessageStatusTable { get; set; }
        public virtual DbSet<ShellMessageTable> ShellMessageTable { get; set; }
        public virtual DbSet<ShellMessageTypeTable> ShellMessageTypeTable { get; set; }
        public virtual DbSet<ShellOperationGroupTable> ShellOperationGroupTable { get; set; }
        public virtual DbSet<ShellOperationLineTable> ShellOperationLineTable { get; set; }
        public virtual DbSet<ShellOperationStatusTable> ShellOperationStatusTable { get; set; }
        public virtual DbSet<ShellOperationTable> ShellOperationTable { get; set; }
        public virtual DbSet<ShellOperationTypeTable> ShellOperationTypeTable { get; set; }
        public virtual DbSet<ShellReportFilterStatusTable> ShellReportFilterStatusTable { get; set; }
        public virtual DbSet<ShellReportFilterTable> ShellReportFilterTable { get; set; }
        public virtual DbSet<ShellReportFilterTypeTable> ShellReportFilterTypeTable { get; set; }
        public virtual DbSet<ShellReportFilterValueTable> ShellReportFilterValueTable { get; set; }
        public virtual DbSet<ShellReportFormTable> ShellReportFormTable { get; set; }
        public virtual DbSet<ShellReportGroupTable> ShellReportGroupTable { get; set; }
        public virtual DbSet<ShellReportStatusTable> ShellReportStatusTable { get; set; }
        public virtual DbSet<ShellReportTable> ShellReportTable { get; set; }
        public virtual DbSet<ShellReportTypeTable> ShellReportTypeTable { get; set; }
        public virtual DbSet<ShellSchedulerGroupTable> ShellSchedulerGroupTable { get; set; }
        public virtual DbSet<ShellSchedulerLanguageTable> ShellSchedulerLanguageTable { get; set; }
        public virtual DbSet<ShellSchedulerStatusTable> ShellSchedulerStatusTable { get; set; }
        public virtual DbSet<ShellSchedulerTable> ShellSchedulerTable { get; set; }
        public virtual DbSet<ShellSchedulerTypeTable> ShellSchedulerTypeTable { get; set; }
        public virtual DbSet<ShellSettingGroupTable> ShellSettingGroupTable { get; set; }
        public virtual DbSet<ShellSettingStatusTable> ShellSettingStatusTable { get; set; }
        public virtual DbSet<ShellSettingTable> ShellSettingTable { get; set; }
        public virtual DbSet<ShellSettingTypeTable> ShellSettingTypeTable { get; set; }
        public virtual DbSet<ShellSettingValueTable> ShellSettingValueTable { get; set; }
        public virtual DbSet<ShellTermGroupTable> ShellTermGroupTable { get; set; }
        public virtual DbSet<ShellTermNameTable> ShellTermNameTable { get; set; }
        public virtual DbSet<ShellTermStatusTable> ShellTermStatusTable { get; set; }
        public virtual DbSet<ShellTermTable> ShellTermTable { get; set; }
        public virtual DbSet<ShellTermTypeTable> ShellTermTypeTable { get; set; }
        public virtual DbSet<ShellUserGroupTable> ShellUserGroupTable { get; set; }
        public virtual DbSet<ShellUserStatusTable> ShellUserStatusTable { get; set; }
        public virtual DbSet<ShellUserTable> ShellUserTable { get; set; }
        public virtual DbSet<ShellUserTypeTable> ShellUserTypeTable { get; set; }
        public virtual DbSet<ShellWorkStatusTable> ShellWorkStatusTable { get; set; }
        public virtual DbSet<StockAgingGraphTable> StockAgingGraphTable { get; set; }
        public virtual DbSet<StockAllocationBaseTable> StockAllocationBaseTable { get; set; }
        public virtual DbSet<StockBomplanGroupTable> StockBomplanGroupTable { get; set; }
        public virtual DbSet<StockBomplanLineStatusTable> StockBomplanLineStatusTable { get; set; }
        public virtual DbSet<StockBomplanLineTable> StockBomplanLineTable { get; set; }
        public virtual DbSet<StockBomplanLineTypeTable> StockBomplanLineTypeTable { get; set; }
        public virtual DbSet<StockBomplanStatusTable> StockBomplanStatusTable { get; set; }
        public virtual DbSet<StockBomplanTable> StockBomplanTable { get; set; }
        public virtual DbSet<StockBomplanTypeTable> StockBomplanTypeTable { get; set; }
        public virtual DbSet<StockBudgetTypeTable> StockBudgetTypeTable { get; set; }
        public virtual DbSet<StockCarGroupTable> StockCarGroupTable { get; set; }
        public virtual DbSet<StockCarStatusTable> StockCarStatusTable { get; set; }
        public virtual DbSet<StockCarTable> StockCarTable { get; set; }
        public virtual DbSet<StockCarTypeTable> StockCarTypeTable { get; set; }
        public virtual DbSet<StockCompanyCardGroupTable> StockCompanyCardGroupTable { get; set; }
        public virtual DbSet<StockCompanyCardStatusTable> StockCompanyCardStatusTable { get; set; }
        public virtual DbSet<StockCompanyCardTable> StockCompanyCardTable { get; set; }
        public virtual DbSet<StockCompanyCardTypeTable> StockCompanyCardTypeTable { get; set; }
        public virtual DbSet<StockCompanyGroupTable> StockCompanyGroupTable { get; set; }
        public virtual DbSet<StockCompanyStatusTable> StockCompanyStatusTable { get; set; }
        public virtual DbSet<StockCompanyTable> StockCompanyTable { get; set; }
        public virtual DbSet<StockCompanyTypeTable> StockCompanyTypeTable { get; set; }
        public virtual DbSet<StockCustomerStatusTable> StockCustomerStatusTable { get; set; }
        public virtual DbSet<StockCustomerTypeTable> StockCustomerTypeTable { get; set; }
        public virtual DbSet<StockDeliveryGraphTable> StockDeliveryGraphTable { get; set; }
        public virtual DbSet<StockDeliveryGroupTable> StockDeliveryGroupTable { get; set; }
        public virtual DbSet<StockDeliveryStatusTable> StockDeliveryStatusTable { get; set; }
        public virtual DbSet<StockDeliveryTable> StockDeliveryTable { get; set; }
        public virtual DbSet<StockDeliveryTypeTable> StockDeliveryTypeTable { get; set; }
        public virtual DbSet<StockDiscountGroupTable> StockDiscountGroupTable { get; set; }
        public virtual DbSet<StockDiscountLineStatusTable> StockDiscountLineStatusTable { get; set; }
        public virtual DbSet<StockDiscountLineTable> StockDiscountLineTable { get; set; }
        public virtual DbSet<StockDiscountLineTypeTable> StockDiscountLineTypeTable { get; set; }
        public virtual DbSet<StockDiscountMethodTable> StockDiscountMethodTable { get; set; }
        public virtual DbSet<StockDiscountStatusTable> StockDiscountStatusTable { get; set; }
        public virtual DbSet<StockDiscountTable> StockDiscountTable { get; set; }
        public virtual DbSet<StockDiscountTypeTable> StockDiscountTypeTable { get; set; }
        public virtual DbSet<StockEntryLineStatusTable> StockEntryLineStatusTable { get; set; }
        public virtual DbSet<StockEntryLineTable> StockEntryLineTable { get; set; }
        public virtual DbSet<StockEntryLineTypeTable> StockEntryLineTypeTable { get; set; }
        public virtual DbSet<StockEntryStatusTable> StockEntryStatusTable { get; set; }
        public virtual DbSet<StockEntryTable> StockEntryTable { get; set; }
        public virtual DbSet<StockEntryTypeTable> StockEntryTypeTable { get; set; }
        public virtual DbSet<StockItemBarcodeTable> StockItemBarcodeTable { get; set; }
        public virtual DbSet<StockItemByLocationTable> StockItemByLocationTable { get; set; }
        public virtual DbSet<StockItemGroupTable> StockItemGroupTable { get; set; }
        public virtual DbSet<StockItemKindTable> StockItemKindTable { get; set; }
        public virtual DbSet<StockItemStatusTable> StockItemStatusTable { get; set; }
        public virtual DbSet<StockItemTable> StockItemTable { get; set; }
        public virtual DbSet<StockItemTypeTable> StockItemTypeTable { get; set; }
        public virtual DbSet<StockItemUnitGroupTable> StockItemUnitGroupTable { get; set; }
        public virtual DbSet<StockItemUnitStatusTable> StockItemUnitStatusTable { get; set; }
        public virtual DbSet<StockItemUnitTable> StockItemUnitTable { get; set; }
        public virtual DbSet<StockItemUnitTypeTable> StockItemUnitTypeTable { get; set; }
        public virtual DbSet<StockLocationAddressTable> StockLocationAddressTable { get; set; }
        public virtual DbSet<StockLocationGroupTable> StockLocationGroupTable { get; set; }
        public virtual DbSet<StockLocationItemStatusTable> StockLocationItemStatusTable { get; set; }
        public virtual DbSet<StockLocationItemTable> StockLocationItemTable { get; set; }
        public virtual DbSet<StockLocationRightTable> StockLocationRightTable { get; set; }
        public virtual DbSet<StockLocationShelfStatusTable> StockLocationShelfStatusTable { get; set; }
        public virtual DbSet<StockLocationShelfTable> StockLocationShelfTable { get; set; }
        public virtual DbSet<StockLocationShelfTypeTable> StockLocationShelfTypeTable { get; set; }
        public virtual DbSet<StockLocationStatusTable> StockLocationStatusTable { get; set; }
        public virtual DbSet<StockLocationTable> StockLocationTable { get; set; }
        public virtual DbSet<StockLocationTypeTable> StockLocationTypeTable { get; set; }
        public virtual DbSet<StockLocationZoneTable> StockLocationZoneTable { get; set; }
        public virtual DbSet<StockMarkupGroupTable> StockMarkupGroupTable { get; set; }
        public virtual DbSet<StockMarkupStatusTable> StockMarkupStatusTable { get; set; }
        public virtual DbSet<StockMarkupTable> StockMarkupTable { get; set; }
        public virtual DbSet<StockMarkupTypeTable> StockMarkupTypeTable { get; set; }
        public virtual DbSet<StockPayMethodTable> StockPayMethodTable { get; set; }
        public virtual DbSet<StockPayPeriodTable> StockPayPeriodTable { get; set; }
        public virtual DbSet<StockPersonGroupTable> StockPersonGroupTable { get; set; }
        public virtual DbSet<StockPersonStatusTable> StockPersonStatusTable { get; set; }
        public virtual DbSet<StockPersonTable> StockPersonTable { get; set; }
        public virtual DbSet<StockPersonTypeTable> StockPersonTypeTable { get; set; }
        public virtual DbSet<StockPriceLineStatusTable> StockPriceLineStatusTable { get; set; }
        public virtual DbSet<StockPriceLineTable> StockPriceLineTable { get; set; }
        public virtual DbSet<StockPriceLineTypeTable> StockPriceLineTypeTable { get; set; }
        public virtual DbSet<StockPriceStatusTable> StockPriceStatusTable { get; set; }
        public virtual DbSet<StockPriceTable> StockPriceTable { get; set; }
        public virtual DbSet<StockPriceTypeTable> StockPriceTypeTable { get; set; }
        public virtual DbSet<StockRecipeStatusTable> StockRecipeStatusTable { get; set; }
        public virtual DbSet<StockRecipeTable> StockRecipeTable { get; set; }
        public virtual DbSet<StockRecipeTypeTable> StockRecipeTypeTable { get; set; }
        public virtual DbSet<StockSalesItemGroupNameTable> StockSalesItemGroupNameTable { get; set; }
        public virtual DbSet<StockSalesItemGroupTable> StockSalesItemGroupTable { get; set; }
        public virtual DbSet<StockSalesUserGroupTable> StockSalesUserGroupTable { get; set; }
        public virtual DbSet<StockScaleTable> StockScaleTable { get; set; }
        public virtual DbSet<StockSupplierStatusTable> StockSupplierStatusTable { get; set; }
        public virtual DbSet<StockSupplierTypeTable> StockSupplierTypeTable { get; set; }
        public virtual DbSet<StockTaxMethodTable> StockTaxMethodTable { get; set; }
        public virtual DbSet<StockTaxStatusTable> StockTaxStatusTable { get; set; }
        public virtual DbSet<StockTaxTable> StockTaxTable { get; set; }
        public virtual DbSet<StockTaxTypeTable> StockTaxTypeTable { get; set; }
        public virtual DbSet<StockUsageTypeTable> StockUsageTypeTable { get; set; }
        public virtual DbSet<StockValuationTable> StockValuationTable { get; set; }
        public virtual DbSet<StockWork2110Table> StockWork2110Table { get; set; }
        public virtual DbSet<StockWork2120Table> StockWork2120Table { get; set; }
        public virtual DbSet<StockWork2130Table> StockWork2130Table { get; set; }
        public virtual DbSet<StockWork2140Table> StockWork2140Table { get; set; }
        public virtual DbSet<StockWork21xZtable> StockWork21xZtable { get; set; }
        public virtual DbSet<StockWorkBudgetTable> StockWorkBudgetTable { get; set; }
        public virtual DbSet<StockWorkLiveTable> StockWorkLiveTable { get; set; }
        public virtual DbSet<StockWorkTable> StockWorkTable { get; set; }
        public virtual DbSet<StockWorkValuationTable> StockWorkValuationTable { get; set; }
        public virtual DbSet<SyncEntryStatusTable> SyncEntryStatusTable { get; set; }
        public virtual DbSet<SyncEntryTable> SyncEntryTable { get; set; }
        public virtual DbSet<SyncEntryTypeTable> SyncEntryTypeTable { get; set; }
        public virtual DbSet<ZGlaccountTable> ZGlaccountTable { get; set; }
        public virtual DbSet<ZGlaccountTable11> ZGlaccountTable11 { get; set; }
        public virtual DbSet<ZPosworkTable> ZPosworkTable { get; set; }
        public virtual DbSet<ZShellSyncStatusTable> ZShellSyncStatusTable { get; set; }
        public virtual DbSet<ZShellSyncTable> ZShellSyncTable { get; set; }
        public virtual DbSet<ZShellSyncTypeTable> ZShellSyncTypeTable { get; set; }
        public virtual DbSet<ZStockEntryProcessTable> ZStockEntryProcessTable { get; set; }
        public virtual DbSet<ZStockEntrySubTypeTable> ZStockEntrySubTypeTable { get; set; }
        public virtual DbSet<ZzShellSyncStatusTable> ZzShellSyncStatusTable { get; set; }
        public virtual DbSet<ZzShellSyncTable> ZzShellSyncTable { get; set; }
        public virtual DbSet<ZzShellSyncTypeTable> ZzShellSyncTypeTable { get; set; }

        // Unable to generate entity type for table 'dbo.StockPlanningMethodTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzShellSyncTable_MGroup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StockCompanyCardTableLog'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CHQQ077\\MSSQLSERVER01;Database=BSC.Solution.257;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CashEntryLineStatusTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryLineStatusId)
                    .HasName("PK_CashEntryLineStatusID");

                entity.HasIndex(e => e.CashEntryLineStatusKey)
                    .HasName("IX_CashEntryLineStatusKey")
                    .IsUnique();

                entity.Property(e => e.CashEntryLineStatusId)
                    .HasColumnName("CashEntryLineStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashEntryLineStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryLineStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashEntryLineStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashEntryLineTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryLineId)
                    .HasName("PK_CashEntryLineID");

                entity.Property(e => e.CashEntryLineId)
                    .HasColumnName("CashEntryLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashCompanyId).HasColumnName("CashCompanyID");

                entity.Property(e => e.CashEntryId).HasColumnName("CashEntryID");

                entity.Property(e => e.CashEntryLineDate).HasColumnType("datetime");

                entity.Property(e => e.CashEntryLineKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryLineName).HasMaxLength(200);

                entity.Property(e => e.CashEntryLineNote).HasColumnType("ntext");

                entity.Property(e => e.CashEntryLineSortId).HasColumnName("CashEntryLineSortID");

                entity.Property(e => e.CashEntryLineStatusId).HasColumnName("CashEntryLineStatusID");

                entity.Property(e => e.CashEntryLineTypeId).HasColumnName("CashEntryLineTypeID");

                entity.Property(e => e.CashItemId).HasColumnName("CashItemID");

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");

                entity.Property(e => e.CashLocationId2).HasColumnName("CashLocationID2");

                entity.Property(e => e.CashPersonId).HasColumnName("CashPersonID");

                entity.HasOne(d => d.CashEntryLineStatus)
                    .WithMany(p => p.CashEntryLineTable)
                    .HasForeignKey(d => d.CashEntryLineStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashEntryLine<-CashEntryLineStatus");

                entity.HasOne(d => d.CashEntryLineType)
                    .WithMany(p => p.CashEntryLineTable)
                    .HasForeignKey(d => d.CashEntryLineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashEntryLine<-CashEntryLineType");
            });

            modelBuilder.Entity<CashEntryLineTypeTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryLineTypeId)
                    .HasName("PK_CashEntryLineTypeID");

                entity.HasIndex(e => e.CashEntryLineTypeKey)
                    .HasName("IX_CashEntryLineTypeKey")
                    .IsUnique();

                entity.Property(e => e.CashEntryLineTypeId)
                    .HasColumnName("CashEntryLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashEntryLineTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryLineTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashEntryLineTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashEntryStatusTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryStatusId)
                    .HasName("PK_CashEntryStatusID");

                entity.HasIndex(e => e.CashEntryStatusKey)
                    .HasName("IX_CashEntryStatusKey")
                    .IsUnique();

                entity.Property(e => e.CashEntryStatusId)
                    .HasColumnName("CashEntryStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashEntryStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashEntryStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashEntryTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryId)
                    .HasName("PK_CashEntryID");

                entity.Property(e => e.CashEntryId)
                    .HasColumnName("CashEntryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CashEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashEntryNote).HasColumnType("ntext");

                entity.Property(e => e.CashEntryProcessId).HasColumnName("CashEntryProcessID");

                entity.Property(e => e.CashEntrySortId).HasColumnName("CashEntrySortID");

                entity.Property(e => e.CashEntryStatusId).HasColumnName("CashEntryStatusID");

                entity.Property(e => e.CashEntryTypeId).HasColumnName("CashEntryTypeID");

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");

                entity.Property(e => e.ShellAcceptorUserId).HasColumnName("ShellAcceptorUserID");

                entity.Property(e => e.ShellCreationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellModifierUserId).HasColumnName("ShellModifierUserID");

                entity.Property(e => e.ShellRejectorUserId).HasColumnName("ShellRejectorUserID");

                entity.Property(e => e.ShellRejectorUserId1).HasColumnName("ShellRejectorUserID1");

                entity.Property(e => e.ShellRejectorUserId2).HasColumnName("ShellRejectorUserID2");

                entity.Property(e => e.ShellRejectorUserId3).HasColumnName("ShellRejectorUserID3");

                entity.Property(e => e.ShellRejectorUserId4).HasColumnName("ShellRejectorUserID4");

                entity.Property(e => e.ShellRejectorUserId5).HasColumnName("ShellRejectorUserID5");

                entity.Property(e => e.ShellRejectorUserId6).HasColumnName("ShellRejectorUserID6");

                entity.Property(e => e.ShellRejectorUserId7).HasColumnName("ShellRejectorUserID7");

                entity.Property(e => e.ShellRejectorUserId8).HasColumnName("ShellRejectorUserID8");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.HasOne(d => d.CashEntryStatus)
                    .WithMany(p => p.CashEntryTable)
                    .HasForeignKey(d => d.CashEntryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashEntry<-CashEntryStatus");

                entity.HasOne(d => d.CashEntryType)
                    .WithMany(p => p.CashEntryTable)
                    .HasForeignKey(d => d.CashEntryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashEntry<-CashEntryType");
            });

            modelBuilder.Entity<CashEntryTypeTable>(entity =>
            {
                entity.HasKey(e => e.CashEntryTypeId)
                    .HasName("PK_CashEntryTypeID");

                entity.HasIndex(e => e.CashEntryTypeKey)
                    .HasName("IX_CashEntryTypeKey")
                    .IsUnique();

                entity.Property(e => e.CashEntryTypeId)
                    .HasColumnName("CashEntryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashEntryTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashEntryTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashEntryTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashLocationGlaccountTable>(entity =>
            {
                entity.HasKey(e => new { e.CashJournalId, e.CashGlaccountId });

                entity.ToTable("CashLocationGLAccountTable");

                entity.Property(e => e.CashJournalId).HasColumnName("CashJournalID");

                entity.Property(e => e.CashGlaccountId).HasColumnName("CashGLAccountID");

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");
            });

            modelBuilder.Entity<CashLocationGroupTable>(entity =>
            {
                entity.HasKey(e => e.CashLocationGroupId)
                    .HasName("PK_CashLocationGroupID");

                entity.HasIndex(e => e.CashLocationGroupKey)
                    .HasName("IX_CashLocationGroupKey")
                    .IsUnique();

                entity.Property(e => e.CashLocationGroupId).HasColumnName("CashLocationGroupID");

                entity.Property(e => e.CashLocationGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashLocationGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashLocationGroupNote).HasColumnType("ntext");

                entity.Property(e => e.CashLocationGroupParentId).HasColumnName("CashLocationGroupParentID");

                entity.HasOne(d => d.CashLocationGroupParent)
                    .WithMany(p => p.InverseCashLocationGroupParent)
                    .HasForeignKey(d => d.CashLocationGroupParentId)
                    .HasConstraintName("FK_CashLocationGroup<-CashLocationGroupParent");
            });

            modelBuilder.Entity<CashLocationStatusTable>(entity =>
            {
                entity.HasKey(e => e.CashLocationStatusId)
                    .HasName("PK_CashLocationStatusID");

                entity.HasIndex(e => e.CashLocationStatusKey)
                    .HasName("IX_CashLocationStatusKey")
                    .IsUnique();

                entity.Property(e => e.CashLocationStatusId)
                    .HasColumnName("CashLocationStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashLocationStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashLocationStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashLocationStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashLocationTable>(entity =>
            {
                entity.HasKey(e => e.CashLocationId)
                    .HasName("PK_CashLocationID");

                entity.HasIndex(e => e.CashLocationKey)
                    .HasName("IX_CashLocationKey")
                    .IsUnique();

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");

                entity.Property(e => e.CashLocationGroupId).HasColumnName("CashLocationGroupID");

                entity.Property(e => e.CashLocationKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashLocationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashLocationNote).HasColumnType("ntext");

                entity.Property(e => e.CashLocationStatusId).HasColumnName("CashLocationStatusID");

                entity.Property(e => e.CashLocationTypeId).HasColumnName("CashLocationTypeID");

                entity.HasOne(d => d.CashLocationGroup)
                    .WithMany(p => p.CashLocationTable)
                    .HasForeignKey(d => d.CashLocationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashLocation<-CashLocationGroup");

                entity.HasOne(d => d.CashLocationStatus)
                    .WithMany(p => p.CashLocationTable)
                    .HasForeignKey(d => d.CashLocationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashLocation<-CashLocationStatus");

                entity.HasOne(d => d.CashLocationType)
                    .WithMany(p => p.CashLocationTable)
                    .HasForeignKey(d => d.CashLocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CashLocation<-CashLocationType");
            });

            modelBuilder.Entity<CashLocationTypeTable>(entity =>
            {
                entity.HasKey(e => e.CashLocationTypeId)
                    .HasName("PK_CashLocationTypeID");

                entity.HasIndex(e => e.CashLocationTypeKey)
                    .HasName("IX_CashLocationTypeKey")
                    .IsUnique();

                entity.Property(e => e.CashLocationTypeId)
                    .HasColumnName("CashLocationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashLocationTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashLocationTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CashLocationTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<CashWorkLiveTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId })
                    .HasName("PK_CashWorkLiveTable_1");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.CashAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashAmount2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashAmount3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashAmount4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashCompanyGroupId).HasColumnName("CashCompanyGroupID");

                entity.Property(e => e.CashCompanyId).HasColumnName("CashCompanyID");

                entity.Property(e => e.CashEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CashEntryId).HasColumnName("CashEntryID");

                entity.Property(e => e.CashEntryKey).HasMaxLength(50);

                entity.Property(e => e.CashEntryLineId).HasColumnName("CashEntryLineID");

                entity.Property(e => e.CashEntryLineSortId).HasColumnName("CashEntryLineSortID");

                entity.Property(e => e.CashEntryLineTypeId).HasColumnName("CashEntryLineTypeID");

                entity.Property(e => e.CashEntryName).HasMaxLength(200);

                entity.Property(e => e.CashEntryStatusId).HasColumnName("CashEntryStatusID");

                entity.Property(e => e.CashEntryTypeId).HasColumnName("CashEntryTypeID");

                entity.Property(e => e.CashItemGroupId).HasColumnName("CashItemGroupID");

                entity.Property(e => e.CashItemId).HasColumnName("CashItemID");

                entity.Property(e => e.CashLocationGroupId).HasColumnName("CashLocationGroupID");

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");

                entity.Property(e => e.CashPersonId).HasColumnName("CashPersonID");

                entity.Property(e => e.CashUserId).HasColumnName("CashUserID");

                entity.Property(e => e.ShellDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellYesNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellYesNo1).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellYesNo2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellYesNo3).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellYesNo4).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellYesNo5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockEntryDate).HasColumnType("datetime");

                entity.Property(e => e.StockEntryTypeId2).HasColumnName("StockEntryTypeID2");
            });

            modelBuilder.Entity<CashWorkTable>(entity =>
            {
                entity.HasKey(e => e.ShellWorkId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ShellWorkId).HasColumnName("ShellWorkID");

                entity.Property(e => e.CashCompanyId).HasColumnName("CashCompanyID");

                entity.Property(e => e.CashEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CashEntryId).HasColumnName("CashEntryID");

                entity.Property(e => e.CashEntryKey).HasMaxLength(50);

                entity.Property(e => e.CashEntryLineId).HasColumnName("CashEntryLineID");

                entity.Property(e => e.CashEntryLineParentId).HasColumnName("CashEntryLineParentID");

                entity.Property(e => e.CashEntryName).HasMaxLength(200);

                entity.Property(e => e.CashEntryParentId).HasColumnName("CashEntryParentID");

                entity.Property(e => e.CashEntrySortId).HasColumnName("CashEntrySortID");

                entity.Property(e => e.CashEntryStatusId).HasColumnName("CashEntryStatusID");

                entity.Property(e => e.CashEntryTypeId).HasColumnName("CashEntryTypeID");

                entity.Property(e => e.CashItemId).HasColumnName("CashItemID");

                entity.Property(e => e.CashLocationId).HasColumnName("CashLocationID");

                entity.Property(e => e.CashLocationId2).HasColumnName("CashLocationID2");

                entity.Property(e => e.CashPersonId)
                    .HasColumnName("CashPersonID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShellAcceptorUserId).HasColumnName("ShellAcceptorUserID");

                entity.Property(e => e.ShellCreationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellModifierUserId).HasColumnName("ShellModifierUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellRejectorUserId).HasColumnName("ShellRejectorUserID");

                entity.Property(e => e.ShellRejectorUserId1).HasColumnName("ShellRejectorUserID1");

                entity.Property(e => e.ShellRejectorUserId2).HasColumnName("ShellRejectorUserID2");

                entity.Property(e => e.ShellRejectorUserId3).HasColumnName("ShellRejectorUserID3");

                entity.Property(e => e.ShellRejectorUserId4).HasColumnName("ShellRejectorUserID4");

                entity.Property(e => e.ShellRejectorUserId5).HasColumnName("ShellRejectorUserID5");

                entity.Property(e => e.ShellRejectorUserId6).HasColumnName("ShellRejectorUserID6");

                entity.Property(e => e.ShellRejectorUserId7).HasColumnName("ShellRejectorUserID7");

                entity.Property(e => e.ShellRejectorUserId8).HasColumnName("ShellRejectorUserID8");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellWorkPageLineParentId)
                    .HasColumnName("ShellWorkPageLineParentID")
                    .HasMaxLength(10);

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");
            });

            modelBuilder.Entity<DeliveryGraphTable>(entity =>
            {
                entity.HasKey(e => e.DeliveryGraphId);

                entity.Property(e => e.DeliveryGraphId)
                    .HasColumnName("DeliveryGraphID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeliveryGraphKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryGraphName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DeliveryGraphTypeId).HasColumnName("DeliveryGraphTypeID");
            });

            modelBuilder.Entity<RsWaybillConfirmationStatusTable>(entity =>
            {
                entity.HasKey(e => e.RsWaybillConfirmationStatusId)
                    .HasName("PK_RsWaybillConfirmationStatusStatusID");

                entity.Property(e => e.RsWaybillConfirmationStatusId)
                    .HasColumnName("RsWaybillConfirmationStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsWaybillConfirmationStatusKey)
                    .IsRequired()
                    .HasColumnName("RsWaybillConfirmationStatusKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillConfirmationStatusName)
                    .IsRequired()
                    .HasColumnName("RsWaybillConfirmationStatusNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsWaybillConfirmationStatusNote)
                    .IsRequired()
                    .HasColumnName("RsWaybillConfirmationStatusNOTE")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<RsWaybillLineTable>(entity =>
            {
                entity.HasKey(e => e.RswaybillLineId);

                entity.Property(e => e.RswaybillLineId)
                    .HasColumnName("RSWaybillLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rsamount).HasColumnName("RSAmount");

                entity.Property(e => e.RsitemKey)
                    .IsRequired()
                    .HasColumnName("RSItemKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsitemName)
                    .IsRequired()
                    .HasColumnName("RSItemName")
                    .HasMaxLength(100);

                entity.Property(e => e.Rsprice).HasColumnName("RSPrice");

                entity.Property(e => e.Rsquantity).HasColumnName("RSQuantity");

                entity.Property(e => e.RstaxId).HasColumnName("RSTaxID");

                entity.Property(e => e.RstaxId2).HasColumnName("RSTaxID2");

                entity.Property(e => e.RsunitId).HasColumnName("RSUnitID");

                entity.Property(e => e.RsunitName)
                    .HasColumnName("RSUnitName")
                    .HasMaxLength(100);

                entity.Property(e => e.RswaybillId).HasColumnName("RSWaybillID");

                entity.Property(e => e.RswaybillLineStatusId).HasColumnName("RSWaybillLineStatusID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellProcessId)
                    .HasColumnName("ShellProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemUnitId).HasColumnName("StockItemUnitID");

                entity.Property(e => e.StockMarkupGroupId).HasColumnName("StockMarkupGroupID");

                entity.Property(e => e.StockMarkupId).HasColumnName("StockMarkupID");

                entity.Property(e => e.StockPriceLineTypeId).HasColumnName("StockPriceLineTypeID");

                entity.Property(e => e.StockPriceTaxId).HasColumnName("StockPriceTaxID");

                entity.Property(e => e.TransPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransTaxFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxId)
                    .HasColumnName("TransTaxID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RsWaybillStatusTable>(entity =>
            {
                entity.HasKey(e => e.RsWaybillStatusId)
                    .HasName("PK_RsWaybillStatusStatusID");

                entity.Property(e => e.RsWaybillStatusId)
                    .HasColumnName("RsWaybillStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsWaybillStatusKey)
                    .IsRequired()
                    .HasColumnName("RsWaybillStatusKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillStatusName)
                    .IsRequired()
                    .HasColumnName("RsWaybillStatusNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsWaybillStatusNote)
                    .IsRequired()
                    .HasColumnName("RsWaybillStatusNOTE")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<RsWaybillTable>(entity =>
            {
                entity.HasKey(e => e.RswaybillId);

                entity.Property(e => e.RswaybillId)
                    .HasColumnName("RSWaybillID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsActivateDate).HasColumnType("datetime");

                entity.Property(e => e.RsBeginDate).HasColumnType("datetime");

                entity.Property(e => e.RsCloseDate).HasColumnType("datetime");

                entity.Property(e => e.RsCompanyKey)
                    .HasColumnName("RsCompanyKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsCompanyName)
                    .HasColumnName("RsCompanyNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RsConfirmationStatusId).HasColumnName("RsConfirmationStatusID");

                entity.Property(e => e.RsCreateDate).HasColumnType("datetime");

                entity.Property(e => e.RsDeliveriDate).HasColumnType("datetime");

                entity.Property(e => e.RsEndAddress).HasMaxLength(100);

                entity.Property(e => e.RsMyCompanyKey)
                    .HasColumnName("RsMyCompanyKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsMyCompanyName)
                    .HasColumnName("RsMyCompanyNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RsPersonKey)
                    .HasColumnName("RsPersonKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsPersonName)
                    .HasColumnName("RsPersonNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.RsStartAddress).HasMaxLength(100);

                entity.Property(e => e.RsTransportKey)
                    .HasColumnName("RsTransportKEY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillStatusId).HasColumnName("RsWaybillStatusID");

                entity.Property(e => e.RsWaybillTypeId).HasColumnName("RsWaybillTypeID");

                entity.Property(e => e.Rsamount).HasColumnName("RSAmount");

                entity.Property(e => e.RscorrectionStatusId).HasColumnName("RSCorrectionStatusID");

                entity.Property(e => e.RswaybillKey)
                    .HasColumnName("RSWaybillKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RswaybillName)
                    .HasColumnName("RSWaybillName")
                    .HasMaxLength(100);

                entity.Property(e => e.ShellCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellProcessId)
                    .HasColumnName("ShellProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.ShellUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockCarId).HasColumnName("StockCarID");

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryName).HasMaxLength(100);

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockPersonId).HasColumnName("StockPersonID");

                entity.Property(e => e.StockSupplierId).HasColumnName("StockSupplierID");
            });

            modelBuilder.Entity<RsWaybillTypeTable>(entity =>
            {
                entity.HasKey(e => e.RsWaybillTypeId)
                    .HasName("PK_RsWaybillTypeTypeID");

                entity.Property(e => e.RsWaybillTypeId)
                    .HasColumnName("RsWaybillTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsWaybillTypeKey)
                    .IsRequired()
                    .HasColumnName("RsWaybillTypeKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillTypeName)
                    .IsRequired()
                    .HasColumnName("RsWaybillTypeNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsWaybillTypeNote)
                    .IsRequired()
                    .HasColumnName("RsWaybillTypeNOTE")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<RslogTable>(entity =>
            {
                entity.HasKey(e => e.RslogId);

                entity.ToTable("RSLogTable");

                entity.Property(e => e.RslogId).HasColumnName("RSLogID");

                entity.Property(e => e.RslogDate)
                    .HasColumnName("RSLogDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RslogKey)
                    .IsRequired()
                    .HasColumnName("RSLogKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RslogName).HasColumnName("RSLogName");

                entity.Property(e => e.SyncProcessId)
                    .HasColumnName("SyncProcessID")
                    .HasDefaultValueSql("((255))");
            });

            modelBuilder.Entity<RsmessageGroupTable>(entity =>
            {
                entity.HasKey(e => e.RsmessageGroupId)
                    .HasName("PK_RSMessageGroupID");

                entity.ToTable("RSMessageGroupTable");

                entity.HasIndex(e => e.RsmessageGroupKey)
                    .HasName("IX_RSMessageGroupKey")
                    .IsUnique();

                entity.Property(e => e.RsmessageGroupId)
                    .HasColumnName("RSMessageGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsmessageGroupKey)
                    .IsRequired()
                    .HasColumnName("RSMessageGroupKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsmessageGroupName)
                    .IsRequired()
                    .HasColumnName("RSMessageGroupNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsmessageGroupNote)
                    .IsRequired()
                    .HasColumnName("RSMessageGroupNOTE")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.RsmessageGroupParentId).HasColumnName("RSMessageGroupParentID");

                entity.Property(e => e.RsmessageGroupSort).HasColumnName("RSMessageGroupSORT");

                entity.HasOne(d => d.RsmessageGroupParent)
                    .WithMany(p => p.InverseRsmessageGroupParent)
                    .HasForeignKey(d => d.RsmessageGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSMessageGroup<-RSMessageGroupParent");
            });

            modelBuilder.Entity<RsmessageStatusTable>(entity =>
            {
                entity.HasKey(e => e.RsmessageStatusId)
                    .HasName("PK_RSMessageStatusID");

                entity.ToTable("RSMessageStatusTable");

                entity.HasIndex(e => e.RsmessageStatusKey)
                    .HasName("IX_RSMessageStatusKey")
                    .IsUnique();

                entity.Property(e => e.RsmessageStatusId)
                    .HasColumnName("RSMessageStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsmessageStatusKey)
                    .IsRequired()
                    .HasColumnName("RSMessageStatusKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsmessageStatusName)
                    .IsRequired()
                    .HasColumnName("RSMessageStatusNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsmessageStatusNote)
                    .IsRequired()
                    .HasColumnName("RSMessageStatusNOTE")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<RsmessageTable>(entity =>
            {
                entity.HasKey(e => e.RsmessageId)
                    .HasName("PK_RSMessageID");

                entity.ToTable("RSMessageTable");

                entity.HasIndex(e => e.RsmessageKey)
                    .HasName("IX_RSMessageKey")
                    .IsUnique();

                entity.Property(e => e.RsmessageId)
                    .HasColumnName("RSMessageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsmessageGroupId).HasColumnName("RSMessageGroupID");

                entity.Property(e => e.RsmessageKey)
                    .IsRequired()
                    .HasColumnName("RSMessageKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsmessageName)
                    .IsRequired()
                    .HasColumnName("RSMessageNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsmessageNote)
                    .IsRequired()
                    .HasColumnName("RSMessageNOTE")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.RsmessageSort).HasColumnName("RSMessageSORT");

                entity.Property(e => e.RsmessageStatusId).HasColumnName("RSMessageStatusID");

                entity.Property(e => e.RsmessageTypeId).HasColumnName("RSMessageTypeID");

                entity.Property(e => e.RsmessageValidFrom)
                    .HasColumnName("RSMessageValidFROM")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RsmessageValidTo)
                    .HasColumnName("RSMessageValidTO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RsmessageGroup)
                    .WithMany(p => p.RsmessageTable)
                    .HasForeignKey(d => d.RsmessageGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSMessage<-RSMessageGroup");

                entity.HasOne(d => d.RsmessageStatus)
                    .WithMany(p => p.RsmessageTable)
                    .HasForeignKey(d => d.RsmessageStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSMessage<-RSMessageStatus");

                entity.HasOne(d => d.RsmessageType)
                    .WithMany(p => p.RsmessageTable)
                    .HasForeignKey(d => d.RsmessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSMessage<-RSMessageType");
            });

            modelBuilder.Entity<RsmessageTypeTable>(entity =>
            {
                entity.HasKey(e => e.RsmessageTypeId)
                    .HasName("PK_RSMessageTypeID");

                entity.ToTable("RSMessageTypeTable");

                entity.HasIndex(e => e.RsmessageTypeKey)
                    .HasName("IX_RSMessageTypeKey")
                    .IsUnique();

                entity.Property(e => e.RsmessageTypeId)
                    .HasColumnName("RSMessageTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsmessageTypeKey)
                    .IsRequired()
                    .HasColumnName("RSMessageTypeKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsmessageTypeName)
                    .IsRequired()
                    .HasColumnName("RSMessageTypeNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.RsmessageTypeNote)
                    .IsRequired()
                    .HasColumnName("RSMessageTypeNOTE")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<RssyncProcessTable>(entity =>
            {
                entity.HasKey(e => e.RssyncProcessId);

                entity.ToTable("RSSyncProcessTable");

                entity.Property(e => e.RssyncProcessId)
                    .HasColumnName("RSSyncProcessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RssyncProcessKey)
                    .IsRequired()
                    .HasColumnName("RSSyncProcessKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RssyncProcessName)
                    .IsRequired()
                    .HasColumnName("RSSyncProcessName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RswaybillWorkTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId })
                    .HasName("PK_RSWayBillWorkTable");

                entity.ToTable("RSWaybillWorkTable");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.RsActivateDate).HasColumnType("datetime");

                entity.Property(e => e.RsBeginDate).HasColumnType("datetime");

                entity.Property(e => e.RsCloseDate).HasColumnType("datetime");

                entity.Property(e => e.RsCompanyKey)
                    .HasColumnName("RsCompanyKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsCompanyName)
                    .HasColumnName("RsCompanyNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RsConfirmationStatusId).HasColumnName("RsConfirmationStatusID");

                entity.Property(e => e.RsCreateDate).HasColumnType("datetime");

                entity.Property(e => e.RsDeliveriDate).HasColumnType("datetime");

                entity.Property(e => e.RsEndAddress).HasMaxLength(100);

                entity.Property(e => e.RsItemKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsPersonKey)
                    .HasColumnName("RsPersonKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsPersonName)
                    .HasColumnName("RsPersonNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.RsStartAddress).HasMaxLength(100);

                entity.Property(e => e.RsTransportKey)
                    .HasColumnName("RsTransportKEY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillId).HasColumnName("RsWaybillID");

                entity.Property(e => e.RsWaybillKey)
                    .HasColumnName("RsWaybillKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RsWaybillLineId).HasColumnName("RsWaybillLineID");

                entity.Property(e => e.RsWaybillLineStatusId).HasColumnName("RsWaybillLineStatusID");

                entity.Property(e => e.RsWaybillStatusId).HasColumnName("RsWaybillStatusID");

                entity.Property(e => e.RsWaybillTypeId).HasColumnName("RsWaybillTypeID");

                entity.Property(e => e.Rsamount).HasColumnName("RSAmount");

                entity.Property(e => e.RscorrectionStatusId).HasColumnName("RSCorrectionStatusID");

                entity.Property(e => e.RsitemName)
                    .HasColumnName("RSItemName")
                    .HasMaxLength(100);

                entity.Property(e => e.Rsprice).HasColumnName("RSPrice");

                entity.Property(e => e.Rsquantity).HasColumnName("RSQuantity");

                entity.Property(e => e.RstaxId).HasColumnName("RSTaxId");

                entity.Property(e => e.RstaxId2).HasColumnName("RSTaxId2");

                entity.Property(e => e.RsunitId).HasColumnName("RSUnitID");

                entity.Property(e => e.RsunitName)
                    .HasColumnName("RSUnitNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RswaybillName)
                    .HasColumnName("RSWaybillName")
                    .HasMaxLength(100);

                entity.Property(e => e.ShellCreated).HasColumnType("datetime");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellUpdated).HasColumnType("datetime");

                entity.Property(e => e.ShellWorkPageLineParentId)
                    .HasColumnName("ShellWorkPageLineParentID")
                    .HasMaxLength(10);

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockCarId)
                    .HasColumnName("StockCarID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryLineId)
                    .HasColumnName("StockEntryLineID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockEntryName).HasMaxLength(100);

                entity.Property(e => e.StockItemId)
                    .HasColumnName("StockItemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockItemUnitId)
                    .HasColumnName("StockItemUnitID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockLocationId)
                    .HasColumnName("StockLocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockMarkupGroupId).HasColumnName("StockMarkupGroupID");

                entity.Property(e => e.StockMarkupId).HasColumnName("StockMarkupID");

                entity.Property(e => e.StockPersonId)
                    .HasColumnName("StockPersonID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockPriceLineTypeId).HasColumnName("StockPriceLineTypeID");

                entity.Property(e => e.StockPriceTaxId).HasColumnName("StockPriceTaxID");

                entity.Property(e => e.StockSupplierId).HasColumnName("StockSupplierID");

                entity.Property(e => e.StockSupplierName).HasMaxLength(100);

                entity.Property(e => e.TransPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransTaxFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxId)
                    .HasColumnName("TransTaxID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShellComputerGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellComputerGroupId)
                    .HasName("PK_ShellComputerGroupID");

                entity.HasIndex(e => e.ShellComputerGroupKey)
                    .HasName("IX_ShellComputerGroupKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellComputerGroupName)
                    .HasName("IX_ShellComputerGroupName")
                    .IsUnique();

                entity.Property(e => e.ShellComputerGroupId)
                    .HasColumnName("ShellComputerGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellComputerGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellComputerGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellComputerGroupParentId).HasColumnName("ShellComputerGroupParentID");

                entity.HasOne(d => d.ShellComputerGroupParent)
                    .WithMany(p => p.InverseShellComputerGroupParent)
                    .HasForeignKey(d => d.ShellComputerGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellComputerGroupTable_ShellComputerGroupTable");
            });

            modelBuilder.Entity<ShellComputerStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellComputerStatusId)
                    .HasName("PK_StockComputerStatusID");

                entity.HasIndex(e => e.ShellComputerStatusKey)
                    .HasName("IX_ShellComputerStatusKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellComputerStatusName)
                    .HasName("IX_ShellComputerStatusTable")
                    .IsUnique();

                entity.Property(e => e.ShellComputerStatusId)
                    .HasColumnName("ShellComputerStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellComputerStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellComputerStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellComputerTable>(entity =>
            {
                entity.HasKey(e => e.ShellComputerId)
                    .HasName("PK_ShellComputerID");

                entity.HasIndex(e => e.ShellComputerKey)
                    .HasName("IX_ShellComputerKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellComputerName)
                    .HasName("IX_ShellComputerName")
                    .IsUnique();

                entity.Property(e => e.ShellComputerId)
                    .HasColumnName("ShellComputerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellComputerGroupId).HasColumnName("ShellComputerGroupID");

                entity.Property(e => e.ShellComputerKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellComputerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellComputerSortId).HasColumnName("ShellComputerSortID");

                entity.Property(e => e.ShellComputerStatusId).HasColumnName("ShellComputerStatusID");

                entity.Property(e => e.ShellComputerTypeId).HasColumnName("ShellComputerTypeID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.HasOne(d => d.ShellComputerGroup)
                    .WithMany(p => p.ShellComputerTable)
                    .HasForeignKey(d => d.ShellComputerGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellComputerTable_ShellComputerGroupTable");

                entity.HasOne(d => d.ShellComputerStatus)
                    .WithMany(p => p.ShellComputerTable)
                    .HasForeignKey(d => d.ShellComputerStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellComputerTable_ShellComputerStatusTable");

                entity.HasOne(d => d.ShellComputerType)
                    .WithMany(p => p.ShellComputerTable)
                    .HasForeignKey(d => d.ShellComputerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellComputerTable_ShellComputerTypeTable");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.ShellComputerTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellComputerTable_StockLocationTable");
            });

            modelBuilder.Entity<ShellComputerTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellComputerTypeId)
                    .HasName("PK_StockComputerTypeID");

                entity.HasIndex(e => e.ShellComputerTypeKey)
                    .HasName("IX_ShellComputerTypeKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellComputerTypeName)
                    .HasName("IX_ShellComputerTypeName")
                    .IsUnique();

                entity.Property(e => e.ShellComputerTypeId)
                    .HasColumnName("ShellComputerTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellComputerTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellComputerTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellComputerUserTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellComputerId, e.ShellUserId });

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellUserGroupId).HasColumnName("ShellUserGroupID");

                entity.HasOne(d => d.ShellComputer)
                    .WithMany(p => p.ShellComputerUserTable)
                    .HasForeignKey(d => d.ShellComputerId)
                    .HasConstraintName("FK_ShellComputerUserTable_ShellComputerTable");

                entity.HasOne(d => d.ShellUser)
                    .WithMany(p => p.ShellComputerUserTable)
                    .HasForeignKey(d => d.ShellUserId)
                    .HasConstraintName("FK_ShellComputerUserTable_ShellUserTable");
            });

            modelBuilder.Entity<ShellDataGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellDataGroupId)
                    .HasName("PK_ShellDataGroupID");

                entity.HasIndex(e => e.ShellDataGroupKey)
                    .HasName("IX_ShellDataGroupKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellDataGroupName)
                    .HasName("IX_ShellDataGroupName")
                    .IsUnique();

                entity.Property(e => e.ShellDataGroupId)
                    .HasColumnName("ShellDataGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDataGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellDataGroupParentId).HasColumnName("ShellDataGroupParentID");

                entity.HasOne(d => d.ShellDataGroupParent)
                    .WithMany(p => p.InverseShellDataGroupParent)
                    .HasForeignKey(d => d.ShellDataGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDataGroup<-ShellDataGroupParent");
            });

            modelBuilder.Entity<ShellDataRightTable>(entity =>
            {
                entity.HasKey(e => new { e.ParentDataId, e.ParentId, e.ChildDataId, e.ChildId });

                entity.Property(e => e.ParentDataId).HasColumnName("ParentDataID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ChildDataId).HasColumnName("ChildDataID");

                entity.Property(e => e.ChildId).HasColumnName("ChildID");

                entity.HasOne(d => d.ParentData)
                    .WithMany(p => p.ShellDataRightTable)
                    .HasForeignKey(d => d.ParentDataId)
                    .HasConstraintName("FK_DataRight<-ParentData");
            });

            modelBuilder.Entity<ShellDataSearchTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellDataId, e.ShellDataSearchId });

                entity.Property(e => e.ShellDataId).HasColumnName("ShellDataID");

                entity.Property(e => e.ShellDataSearchId).HasColumnName("ShellDataSearchID");

                entity.Property(e => e.ShellDataSearchFormat).IsRequired();

                entity.Property(e => e.ShellDataSearchKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataSearchName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ShellData)
                    .WithMany(p => p.ShellDataSearchTable)
                    .HasForeignKey(d => d.ShellDataId)
                    .HasConstraintName("FK_ShellDataSearchTable_ShellDataTable");
            });

            modelBuilder.Entity<ShellDataSortTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellDataId, e.ShellDataSortId });

                entity.Property(e => e.ShellDataId).HasColumnName("ShellDataID");

                entity.Property(e => e.ShellDataSortId).HasColumnName("ShellDataSortID");

                entity.Property(e => e.ShellDataSortFormat).IsRequired();

                entity.Property(e => e.ShellDataSortKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataSortName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ShellData)
                    .WithMany(p => p.ShellDataSortTable)
                    .HasForeignKey(d => d.ShellDataId)
                    .HasConstraintName("FK_ShellDataSortTable_ShellDataTable");
            });

            modelBuilder.Entity<ShellDataStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellDataStatusId)
                    .HasName("PK_ShellDataStatusID");

                entity.HasIndex(e => e.ShellDataStatusKey)
                    .HasName("IX_ShellDataStatusKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellDataStatusName)
                    .HasName("IX_ShellDataStatusName")
                    .IsUnique();

                entity.Property(e => e.ShellDataStatusId)
                    .HasColumnName("ShellDataStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDataStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellDataTable>(entity =>
            {
                entity.HasKey(e => e.ShellDataId)
                    .HasName("PK_ShellDataID");

                entity.HasIndex(e => e.ShellDataKey)
                    .HasName("IX_ShellDataKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellDataName)
                    .HasName("IX_ShellDataName")
                    .IsUnique();

                entity.Property(e => e.ShellDataId)
                    .HasColumnName("ShellDataID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDataFlagHasGroup).HasColumnName("ShellDataFlag_HasGroup");

                entity.Property(e => e.ShellDataFlagHasGroupHierarchy).HasColumnName("ShellDataFlag_HasGroupHierarchy");

                entity.Property(e => e.ShellDataFlagHasHierarchy).HasColumnName("ShellDataFlag_HasHierarchy");

                entity.Property(e => e.ShellDataFlagIsGroupReadOnly).HasColumnName("ShellDataFlag_IsGroupReadOnly");

                entity.Property(e => e.ShellDataFlagIsReadOnly).HasColumnName("ShellDataFlag_IsReadOnly");

                entity.Property(e => e.ShellDataGroupId).HasColumnName("ShellDataGroupID");

                entity.Property(e => e.ShellDataKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellDataSortId).HasColumnName("ShellDataSortID");

                entity.Property(e => e.ShellDataStatusId).HasColumnName("ShellDataStatusID");

                entity.Property(e => e.ShellDataTypeId).HasColumnName("ShellDataTypeID");

                entity.Property(e => e.ShellDataValueGroupId).HasColumnName("ShellDataValueGroupID");

                entity.Property(e => e.ShellDataValueId).HasColumnName("ShellDataValueID");

                entity.HasOne(d => d.ShellDataGroup)
                    .WithMany(p => p.ShellDataTable)
                    .HasForeignKey(d => d.ShellDataGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellData<-ShellDataGroup");

                entity.HasOne(d => d.ShellDataStatus)
                    .WithMany(p => p.ShellDataTable)
                    .HasForeignKey(d => d.ShellDataStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellData<-ShellDataStatus");

                entity.HasOne(d => d.ShellDataType)
                    .WithMany(p => p.ShellDataTable)
                    .HasForeignKey(d => d.ShellDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellData<-ShellDataType");
            });

            modelBuilder.Entity<ShellDataTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellDataTypeId)
                    .HasName("PK_ShellDataTypeID");

                entity.HasIndex(e => e.ShellDataTypeKey)
                    .HasName("IX_ShellDataTypeKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellDataTypeName)
                    .HasName("IX_ShellDataTypeName")
                    .IsUnique();

                entity.Property(e => e.ShellDataTypeId)
                    .HasColumnName("ShellDataTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDataTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDataTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellDiagnoseGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellDiagnoseGroupId)
                    .HasName("PK_ShellDiagnoseGroupID");

                entity.Property(e => e.ShellDiagnoseGroupId).HasColumnName("ShellDiagnoseGroupID");

                entity.Property(e => e.ShellDiagnoseGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDiagnoseGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellDiagnoseGroupParentId).HasColumnName("ShellDiagnoseGroupParentID");

                entity.HasOne(d => d.ShellDiagnoseGroupParent)
                    .WithMany(p => p.InverseShellDiagnoseGroupParent)
                    .HasForeignKey(d => d.ShellDiagnoseGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDiagnoseGroup<-ShellDiagnoseGroupParent");
            });

            modelBuilder.Entity<ShellDiagnoseStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellDiagnoseStatusId)
                    .HasName("PK_ShellDiagnoseStatusID");

                entity.Property(e => e.ShellDiagnoseStatusId)
                    .HasColumnName("ShellDiagnoseStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDiagnoseStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDiagnoseStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellDiagnoseTable>(entity =>
            {
                entity.HasKey(e => e.ShellDiagnoseId)
                    .HasName("PK_ShellDiagnoseID");

                entity.Property(e => e.ShellDiagnoseId)
                    .HasColumnName("ShellDiagnoseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDiagnoseCommand)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellDiagnoseGroupId).HasColumnName("ShellDiagnoseGroupID");

                entity.Property(e => e.ShellDiagnoseKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDiagnoseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellDiagnoseSortId).HasColumnName("ShellDiagnoseSortID");

                entity.Property(e => e.ShellDiagnoseStatusId).HasColumnName("ShellDiagnoseStatusID");

                entity.Property(e => e.ShellDiagnoseTypeId).HasColumnName("ShellDiagnoseTypeID");

                entity.HasOne(d => d.ShellDiagnoseGroup)
                    .WithMany(p => p.ShellDiagnoseTable)
                    .HasForeignKey(d => d.ShellDiagnoseGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDiagnose<-ShellDiagnoseGroup");

                entity.HasOne(d => d.ShellDiagnoseStatus)
                    .WithMany(p => p.ShellDiagnoseTable)
                    .HasForeignKey(d => d.ShellDiagnoseStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDiagnose<-ShellDiagnoseStatus");

                entity.HasOne(d => d.ShellDiagnoseType)
                    .WithMany(p => p.ShellDiagnoseTable)
                    .HasForeignKey(d => d.ShellDiagnoseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDiagnose<-ShellDiagnoseType");
            });

            modelBuilder.Entity<ShellDiagnoseTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellDiagnoseTypeId)
                    .HasName("PK_ShellDiagnoseTypeID");

                entity.Property(e => e.ShellDiagnoseTypeId)
                    .HasColumnName("ShellDiagnoseTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDiagnoseTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDiagnoseTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellDllgroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellDllgroupId)
                    .HasName("PK_ShellDLLGroupID");

                entity.ToTable("ShellDLLGroupTable");

                entity.Property(e => e.ShellDllgroupId)
                    .HasColumnName("ShellDLLGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDllgroupKey)
                    .IsRequired()
                    .HasColumnName("ShellDLLGroupKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDllgroupName)
                    .IsRequired()
                    .HasColumnName("ShellDLLGroupNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellDllgroupNote)
                    .IsRequired()
                    .HasColumnName("ShellDLLGroupNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ShellDllgroupParentId).HasColumnName("ShellDLLGroupParentID");

                entity.Property(e => e.ShellDllgroupSort).HasColumnName("ShellDLLGroupSORT");

                entity.HasOne(d => d.ShellDllgroupParent)
                    .WithMany(p => p.InverseShellDllgroupParent)
                    .HasForeignKey(d => d.ShellDllgroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLLGroup<-ShellDLLGroupParent");
            });

            modelBuilder.Entity<ShellDlllanguageTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellDllid, e.ShellDlllanguageId });

                entity.ToTable("ShellDLLLanguageTable");

                entity.Property(e => e.ShellDllid).HasColumnName("ShellDLLID");

                entity.Property(e => e.ShellDlllanguageId).HasColumnName("ShellDLLLanguageID");

                entity.Property(e => e.ShellDllname)
                    .IsRequired()
                    .HasColumnName("ShellDLLNAME")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ShellDll)
                    .WithMany(p => p.ShellDlllanguageTable)
                    .HasForeignKey(d => d.ShellDllid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLLLanguage<-ShellDLL");

                entity.HasOne(d => d.ShellDlllanguage)
                    .WithMany(p => p.ShellDlllanguageTable)
                    .HasForeignKey(d => d.ShellDlllanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLLLanguage<-ShellLanguageTable");
            });

            modelBuilder.Entity<ShellDllstatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellDllstatusId)
                    .HasName("PK_ShellDLLStatusID");

                entity.ToTable("ShellDLLStatusTable");

                entity.Property(e => e.ShellDllstatusId)
                    .HasColumnName("ShellDLLStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDllstatusKey)
                    .IsRequired()
                    .HasColumnName("ShellDLLStatusKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDllstatusName)
                    .IsRequired()
                    .HasColumnName("ShellDLLStatusNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellDllstatusNote)
                    .IsRequired()
                    .HasColumnName("ShellDLLStatusNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<ShellDlltable>(entity =>
            {
                entity.HasKey(e => e.ShellDllid)
                    .HasName("PK_ShellDLLID");

                entity.ToTable("ShellDLLTable");

                entity.Property(e => e.ShellDllid)
                    .HasColumnName("ShellDLLID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDllgroupId).HasColumnName("ShellDLLGroupID");

                entity.Property(e => e.ShellDllkey)
                    .IsRequired()
                    .HasColumnName("ShellDLLKEY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDllname)
                    .IsRequired()
                    .HasColumnName("ShellDLLNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellDllnote)
                    .IsRequired()
                    .HasColumnName("ShellDLLNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ShellDllpath)
                    .IsRequired()
                    .HasColumnName("ShellDLLPATH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShellDllsort).HasColumnName("ShellDLLSORT");

                entity.Property(e => e.ShellDllstatusId).HasColumnName("ShellDLLStatusID");

                entity.Property(e => e.ShellDlltypeId).HasColumnName("ShellDLLTypeID");

                entity.Property(e => e.ShellDllvalidFrom)
                    .HasColumnName("ShellDLLValidFROM")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellDllvalidTo)
                    .HasColumnName("ShellDLLValidTO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ShellDllgroup)
                    .WithMany(p => p.ShellDlltable)
                    .HasForeignKey(d => d.ShellDllgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLL<-ShellDLLGroup");

                entity.HasOne(d => d.ShellDllstatus)
                    .WithMany(p => p.ShellDlltable)
                    .HasForeignKey(d => d.ShellDllstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLL<-ShellDLLStatus");

                entity.HasOne(d => d.ShellDlltype)
                    .WithMany(p => p.ShellDlltable)
                    .HasForeignKey(d => d.ShellDlltypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellDLL<-ShellDLLType");
            });

            modelBuilder.Entity<ShellDlltypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellDlltypeId)
                    .HasName("PK_ShellDLLTypeID");

                entity.ToTable("ShellDLLTypeTable");

                entity.Property(e => e.ShellDlltypeId)
                    .HasColumnName("ShellDLLTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDlltypeKey)
                    .IsRequired()
                    .HasColumnName("ShellDLLTypeKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellDlltypeName)
                    .IsRequired()
                    .HasColumnName("ShellDLLTypeNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellDlltypeNote)
                    .IsRequired()
                    .HasColumnName("ShellDLLTypeNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<ShellImportExcelTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellPageId, e.ShellPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellPageId).HasColumnName("ShellPageID");

                entity.Property(e => e.ShellPageLineId).HasColumnName("ShellPageLineID");

                entity.Property(e => e.F01).HasMaxLength(200);

                entity.Property(e => e.F02).HasMaxLength(200);

                entity.Property(e => e.F03).HasMaxLength(200);

                entity.Property(e => e.F04).HasMaxLength(200);

                entity.Property(e => e.F05).HasMaxLength(200);

                entity.Property(e => e.F06).HasMaxLength(200);

                entity.Property(e => e.F07).HasMaxLength(200);

                entity.Property(e => e.F08).HasMaxLength(200);

                entity.Property(e => e.F09).HasMaxLength(200);

                entity.Property(e => e.F10).HasMaxLength(200);

                entity.Property(e => e.F11).HasMaxLength(200);

                entity.Property(e => e.F12).HasMaxLength(200);

                entity.Property(e => e.F13).HasMaxLength(200);

                entity.Property(e => e.F14).HasMaxLength(200);

                entity.Property(e => e.F15).HasMaxLength(200);

                entity.Property(e => e.F16).HasMaxLength(200);

                entity.Property(e => e.F17).HasMaxLength(200);

                entity.Property(e => e.F18).HasMaxLength(200);

                entity.Property(e => e.F19).HasMaxLength(200);

                entity.Property(e => e.F20).HasMaxLength(200);

                entity.Property(e => e.F21).HasMaxLength(200);

                entity.Property(e => e.F22).HasMaxLength(200);

                entity.Property(e => e.F23).HasMaxLength(200);

                entity.Property(e => e.F24).HasMaxLength(200);

                entity.Property(e => e.F25).HasMaxLength(200);

                entity.Property(e => e.F26).HasMaxLength(200);

                entity.Property(e => e.F27).HasMaxLength(200);

                entity.Property(e => e.F28).HasMaxLength(200);

                entity.Property(e => e.F29).HasMaxLength(200);

                entity.Property(e => e.F30).HasMaxLength(200);

                entity.Property(e => e.F31).HasMaxLength(200);

                entity.Property(e => e.F32).HasMaxLength(200);

                entity.Property(e => e.F33).HasMaxLength(200);

                entity.Property(e => e.F34).HasMaxLength(200);

                entity.Property(e => e.F35).HasMaxLength(200);

                entity.Property(e => e.F36).HasMaxLength(200);

                entity.Property(e => e.F37).HasMaxLength(200);

                entity.Property(e => e.F38).HasMaxLength(200);

                entity.Property(e => e.F39).HasMaxLength(200);

                entity.Property(e => e.F40).HasMaxLength(200);

                entity.Property(e => e.F41).HasMaxLength(200);

                entity.Property(e => e.F42).HasMaxLength(200);

                entity.Property(e => e.F43).HasMaxLength(200);

                entity.Property(e => e.F44).HasMaxLength(200);

                entity.Property(e => e.F45).HasMaxLength(200);

                entity.Property(e => e.F46).HasMaxLength(200);

                entity.Property(e => e.F47).HasMaxLength(200);

                entity.Property(e => e.F48).HasMaxLength(200);

                entity.Property(e => e.F49).HasMaxLength(200);

                entity.Property(e => e.F50).HasMaxLength(200);
            });

            modelBuilder.Entity<ShellLanguageStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellLanguageStatusId)
                    .HasName("PK_ShellLanguageStatusID");

                entity.HasIndex(e => e.ShellLanguageStatusKey)
                    .HasName("IX_ShellLanguageStatusKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellLanguageStatusName)
                    .HasName("IX_ShellLanguageStatusName")
                    .IsUnique();

                entity.Property(e => e.ShellLanguageStatusId)
                    .HasColumnName("ShellLanguageStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellLanguageStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellLanguageStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellLanguageTable>(entity =>
            {
                entity.HasKey(e => e.ShellLanguageId)
                    .HasName("PK_ShellLanguageID");

                entity.HasIndex(e => e.ShellLanguageKey)
                    .HasName("IX_ShellLanguageKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellLanguageName)
                    .HasName("IX_ShellLanguageName")
                    .IsUnique();

                entity.Property(e => e.ShellLanguageId)
                    .HasColumnName("ShellLanguageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellLanguageKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellLanguageName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellLanguageStatusId).HasColumnName("ShellLanguageStatusID");

                entity.Property(e => e.ShellLanguageTypeId).HasColumnName("ShellLanguageTypeID");

                entity.HasOne(d => d.ShellLanguageStatus)
                    .WithMany(p => p.ShellLanguageTable)
                    .HasForeignKey(d => d.ShellLanguageStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellLanguageTable_ShellLanguageStatusTable");

                entity.HasOne(d => d.ShellLanguageType)
                    .WithMany(p => p.ShellLanguageTable)
                    .HasForeignKey(d => d.ShellLanguageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellLanguageTable_ShellLanguageTypeTable");
            });

            modelBuilder.Entity<ShellLanguageTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellLanguageTypeId)
                    .HasName("PK_ShellLanguageTypeID");

                entity.HasIndex(e => e.ShellLanguageTypeKey)
                    .HasName("IX_ShellLanguageTypeKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellLanguageTypeName)
                    .HasName("IX_ShellLanguageTypeName")
                    .IsUnique();

                entity.Property(e => e.ShellLanguageTypeId)
                    .HasColumnName("ShellLanguageTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellLanguageTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellLanguageTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellLogTable>(entity =>
            {
                entity.HasKey(e => e.ShellLogId);

                entity.Property(e => e.ShellLogId).HasColumnName("ShellLogID");

                entity.Property(e => e.ShellLogDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ShellLogKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ShellLogName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ShellLogSortId).HasColumnName("ShellLogSortID");

                entity.Property(e => e.ShellLogTime)
                    .HasColumnType("time(3)")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ShellLogValue)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ShellLogXml)
                    .HasColumnName("ShellLogXML")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<ShellMessageGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellMessageGroupId)
                    .HasName("PK_ShellMessageGroupID");

                entity.HasIndex(e => e.ShellMessageGroupKey)
                    .HasName("IX_ShellMessageGroupKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellMessageGroupName)
                    .HasName("IX_ShellMessageGroupName")
                    .IsUnique();

                entity.Property(e => e.ShellMessageGroupId)
                    .HasColumnName("ShellMessageGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellMessageGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellMessageGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellMessageGroupParentId).HasColumnName("ShellMessageGroupParentID");

                entity.HasOne(d => d.ShellMessageGroupParent)
                    .WithMany(p => p.InverseShellMessageGroupParent)
                    .HasForeignKey(d => d.ShellMessageGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellMessageGroupTable_ShellMessageGroupTable");
            });

            modelBuilder.Entity<ShellMessageStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellMessageStatusId)
                    .HasName("PK_ShellMessageStatusID");

                entity.HasIndex(e => e.ShellMessageStatusKey)
                    .HasName("IX_ShellMessageStatusKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellMessageStatusName)
                    .HasName("IX_ShellMessageStatusName")
                    .IsUnique();

                entity.Property(e => e.ShellMessageStatusId)
                    .HasColumnName("ShellMessageStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellMessageStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellMessageStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellMessageTable>(entity =>
            {
                entity.HasKey(e => e.ShellMessageId)
                    .HasName("PK_ShellMessageID");

                entity.HasIndex(e => e.ShellMessageKey)
                    .HasName("IX_ShellMessageKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellMessageName)
                    .HasName("IX_ShellMessageName")
                    .IsUnique();

                entity.Property(e => e.ShellMessageId)
                    .HasColumnName("ShellMessageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellMessageGroupId).HasColumnName("ShellMessageGroupID");

                entity.Property(e => e.ShellMessageKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellMessageName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellMessageSortId).HasColumnName("ShellMessageSortID");

                entity.Property(e => e.ShellMessageStatusId).HasColumnName("ShellMessageStatusID");

                entity.Property(e => e.ShellMessageTypeId).HasColumnName("ShellMessageTypeID");

                entity.HasOne(d => d.ShellMessageGroup)
                    .WithMany(p => p.ShellMessageTable)
                    .HasForeignKey(d => d.ShellMessageGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellMessageTable_ShellMessageGroupTable");

                entity.HasOne(d => d.ShellMessageStatus)
                    .WithMany(p => p.ShellMessageTable)
                    .HasForeignKey(d => d.ShellMessageStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellMessage<-ShellMessageStatus");

                entity.HasOne(d => d.ShellMessageType)
                    .WithMany(p => p.ShellMessageTable)
                    .HasForeignKey(d => d.ShellMessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellMessage<-ShellMessageType");
            });

            modelBuilder.Entity<ShellMessageTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellMessageTypeId)
                    .HasName("PK_ShellMessageTypeID");

                entity.HasIndex(e => e.ShellMessageTypeKey)
                    .HasName("IX_ShellMessageTypeKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellMessageTypeName)
                    .HasName("IX_ShellMessageTypeName")
                    .IsUnique();

                entity.Property(e => e.ShellMessageTypeId)
                    .HasColumnName("ShellMessageTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellMessageTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellMessageTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellOperationGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellOperationGroupId)
                    .HasName("PK_ShellOperationGroupID");

                entity.HasIndex(e => e.ShellOperationGroupKey)
                    .HasName("IX_ShellOperationGroupKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellOperationGroupName)
                    .HasName("IX_ShellOperationGroupName")
                    .IsUnique();

                entity.Property(e => e.ShellOperationGroupId)
                    .HasColumnName("ShellOperationGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellOperationGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellOperationGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellOperationGroupParentId).HasColumnName("ShellOperationGroupParentID");

                entity.HasOne(d => d.ShellOperationGroupParent)
                    .WithMany(p => p.InverseShellOperationGroupParent)
                    .HasForeignKey(d => d.ShellOperationGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellOperationGroup<-ShellOperationGroupParent");
            });

            modelBuilder.Entity<ShellOperationLineTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellOperationId, e.ShellOperationLineId });

                entity.HasIndex(e => new { e.ShellOperationId, e.ShellEntryLineTypeId })
                    .HasName("IX_ShellOperationLineKey")
                    .IsUnique();

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellOperationLineId).HasColumnName("ShellOperationLineID");

                entity.Property(e => e.ShellEntryLineStatusId).HasColumnName("ShellEntryLineStatusID");

                entity.Property(e => e.ShellEntryLineTypeId).HasColumnName("ShellEntryLineTypeID");

                entity.HasOne(d => d.ShellOperation)
                    .WithMany(p => p.ShellOperationLineTable)
                    .HasForeignKey(d => d.ShellOperationId)
                    .HasConstraintName("FK_ShellOperationLineTable_ShellOperationTable");
            });

            modelBuilder.Entity<ShellOperationStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellOperationStatusId)
                    .HasName("PK_ShellOperationStatusID");

                entity.HasIndex(e => e.ShellOperationStatusKey)
                    .HasName("IX_ShellOperationStatusKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellOperationStatusName)
                    .HasName("IX_ShellOperationStatusName")
                    .IsUnique();

                entity.Property(e => e.ShellOperationStatusId)
                    .HasColumnName("ShellOperationStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellOperationStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellOperationStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellOperationTable>(entity =>
            {
                entity.HasKey(e => e.ShellOperationId)
                    .HasName("PK_ShellOperationID");

                entity.HasIndex(e => e.ShellOperationKey)
                    .HasName("IX_ShellOperationKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellOperationName)
                    .HasName("IX_ShellOperationName")
                    .IsUnique();

                entity.Property(e => e.ShellOperationId)
                    .HasColumnName("ShellOperationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellDataId).HasColumnName("ShellDataID");

                entity.Property(e => e.ShellDataValueStatusId).HasColumnName("ShellDataValueStatusID");

                entity.Property(e => e.ShellDataValueTypeId).HasColumnName("ShellDataValueTypeID");

                entity.Property(e => e.ShellEntryAcceptedStatusId).HasColumnName("ShellEntryAcceptedStatusID");

                entity.Property(e => e.ShellEntryAccessId).HasColumnName("ShellEntryAccessID");

                entity.Property(e => e.ShellEntryRejectedStatusId).HasColumnName("ShellEntryRejectedStatusID");

                entity.Property(e => e.ShellEntryStatusId).HasColumnName("ShellEntryStatusID");

                entity.Property(e => e.ShellEntryTypeId).HasColumnName("ShellEntryTypeID");

                entity.Property(e => e.ShellEntryVoidStatusId).HasColumnName("ShellEntryVoidStatusID");

                entity.Property(e => e.ShellOperationGroupId).HasColumnName("ShellOperationGroupID");

                entity.Property(e => e.ShellOperationKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellOperationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellOperationSortId).HasColumnName("ShellOperationSortID");

                entity.Property(e => e.ShellOperationStatusId).HasColumnName("ShellOperationStatusID");

                entity.Property(e => e.ShellOperationTypeId).HasColumnName("ShellOperationTypeID");

                entity.HasOne(d => d.ShellOperationGroup)
                    .WithMany(p => p.ShellOperationTable)
                    .HasForeignKey(d => d.ShellOperationGroupId)
                    .HasConstraintName("FK_ShellOperation<-ShellOperationGroup");

                entity.HasOne(d => d.ShellOperationStatus)
                    .WithMany(p => p.ShellOperationTable)
                    .HasForeignKey(d => d.ShellOperationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellOperation<-ShellOperationStatus");

                entity.HasOne(d => d.ShellOperationType)
                    .WithMany(p => p.ShellOperationTable)
                    .HasForeignKey(d => d.ShellOperationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellOperation<-ShellOperationType");
            });

            modelBuilder.Entity<ShellOperationTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellOperationTypeId)
                    .HasName("PK_ShellOperationTypeID");

                entity.HasIndex(e => e.ShellOperationTypeKey)
                    .HasName("IX_ShellOperationTypeKey")
                    .IsUnique();

                entity.HasIndex(e => e.ShellOperationTypeName)
                    .HasName("IX_ShellOperationTypeName")
                    .IsUnique();

                entity.Property(e => e.ShellOperationTypeId)
                    .HasColumnName("ShellOperationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellOperationTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellOperationTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellReportFilterStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportFilterStatusId)
                    .HasName("PK_ShellReportFilterStatusID");

                entity.Property(e => e.ShellReportFilterStatusId)
                    .HasColumnName("ShellReportFilterStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellReportFilterStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportFilterStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellReportFilterTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportFilterId)
                    .HasName("PK_ShellReportFilterTable_1");

                entity.Property(e => e.ShellReportFilterId).HasColumnName("ShellReportFilterID");

                entity.Property(e => e.ShellReportFilterKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportFilterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellReportFilterSortId).HasColumnName("ShellReportFilterSortID");

                entity.Property(e => e.ShellReportFilterStatusId).HasColumnName("ShellReportFilterStatusID");

                entity.Property(e => e.ShellReportFilterTypeId).HasColumnName("ShellReportFilterTypeID");

                entity.Property(e => e.ShellReportId).HasColumnName("ShellReportID");

                entity.HasOne(d => d.ShellReportFilterStatus)
                    .WithMany(p => p.ShellReportFilterTable)
                    .HasForeignKey(d => d.ShellReportFilterStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReportFilterTable_ShellReportFilterStatusTable");

                entity.HasOne(d => d.ShellReportFilterType)
                    .WithMany(p => p.ShellReportFilterTable)
                    .HasForeignKey(d => d.ShellReportFilterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReportFilterTable_ShellReportFilterTypeTable");

                entity.HasOne(d => d.ShellReport)
                    .WithMany(p => p.ShellReportFilterTable)
                    .HasForeignKey(d => d.ShellReportId)
                    .HasConstraintName("FK_ShellReportFilterTable_ShellReportTable");
            });

            modelBuilder.Entity<ShellReportFilterTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportFilterTypeId)
                    .HasName("PK_Assets_ReportFilterTypes");

                entity.Property(e => e.ShellReportFilterTypeId)
                    .HasColumnName("ShellReportFilterTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellControlKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellReportFilterTypeKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportFilterTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sqlprefix)
                    .IsRequired()
                    .HasColumnName("SQLPrefix")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Sqlsuffix)
                    .IsRequired()
                    .HasColumnName("SQLSuffix")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Sqltype)
                    .IsRequired()
                    .HasColumnName("SQLType")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ShellReportFilterValueTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportFilterValueId)
                    .HasName("PK_ShellReportWorkTable");

                entity.Property(e => e.ShellReportFilterValueId).HasColumnName("ShellReportFilterValueID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellReportFilterId).HasColumnName("ShellReportFilterID");

                entity.Property(e => e.ShellReportFilterValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.HasOne(d => d.ShellReportFilter)
                    .WithMany(p => p.ShellReportFilterValueTable)
                    .HasForeignKey(d => d.ShellReportFilterId)
                    .HasConstraintName("FK_ShellReportWorkTable_ShellReportFilterTable");

                entity.HasOne(d => d.ShellUser)
                    .WithMany(p => p.ShellReportFilterValueTable)
                    .HasForeignKey(d => d.ShellUserId)
                    .HasConstraintName("FK_ShellReportFilterValueTable_ShellUserTable");
            });

            modelBuilder.Entity<ShellReportFormTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportFormId);

                entity.Property(e => e.ShellReportFormId).HasColumnName("ShellReportFormID");

                entity.Property(e => e.ShellReportFormKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportFormName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellReportFormSortId).HasColumnName("ShellReportFormSortID");

                entity.Property(e => e.ShellReportId).HasColumnName("ShellReportID");

                entity.HasOne(d => d.ShellReport)
                    .WithMany(p => p.ShellReportFormTable)
                    .HasForeignKey(d => d.ShellReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReportFormTable_ShellReportTable");
            });

            modelBuilder.Entity<ShellReportGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportGroupId)
                    .HasName("PK_ShellReportGroupID");

                entity.HasIndex(e => e.ShellReportGroupKey)
                    .HasName("IX_ShellReportGroupKey")
                    .IsUnique();

                entity.Property(e => e.ShellReportGroupId)
                    .HasColumnName("ShellReportGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellReportGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellReportGroupParentId).HasColumnName("ShellReportGroupParentID");

                entity.HasOne(d => d.ShellReportGroupParent)
                    .WithMany(p => p.InverseShellReportGroupParent)
                    .HasForeignKey(d => d.ShellReportGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReportGroup<-ShellReportGroupParent");
            });

            modelBuilder.Entity<ShellReportStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportStatusId)
                    .HasName("PK_ShellReportStatusID");

                entity.Property(e => e.ShellReportStatusId)
                    .HasColumnName("ShellReportStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellReportStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellReportTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportId)
                    .HasName("PK_ShellReportID");

                entity.HasIndex(e => e.ShellReportKey)
                    .HasName("IX_ShellReportKey")
                    .IsUnique();

                entity.Property(e => e.ShellReportId).HasColumnName("ShellReportID");

                entity.Property(e => e.ShellReportFilter)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellReportGroupId).HasColumnName("ShellReportGroupID");

                entity.Property(e => e.ShellReportKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellReportSource).IsRequired();

                entity.Property(e => e.ShellReportStatusId).HasColumnName("ShellReportStatusID");

                entity.Property(e => e.ShellReportTypeId).HasColumnName("ShellReportTypeID");

                entity.HasOne(d => d.ShellReportGroup)
                    .WithMany(p => p.ShellReportTable)
                    .HasForeignKey(d => d.ShellReportGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReport<-ShellReportGroup");

                entity.HasOne(d => d.ShellReportStatus)
                    .WithMany(p => p.ShellReportTable)
                    .HasForeignKey(d => d.ShellReportStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReport<-ShellReportStatus");

                entity.HasOne(d => d.ShellReportType)
                    .WithMany(p => p.ShellReportTable)
                    .HasForeignKey(d => d.ShellReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellReport<-ShellReportType");
            });

            modelBuilder.Entity<ShellReportTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellReportTypeId)
                    .HasName("PK_ShellReportTypeID");

                entity.Property(e => e.ShellReportTypeId)
                    .HasColumnName("ShellReportTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellReportTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellReportTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellSchedulerGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellSchedulerGroupId)
                    .HasName("PK_ShellSchedulerGroupID");

                entity.Property(e => e.ShellSchedulerGroupId)
                    .HasColumnName("ShellSchedulerGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSchedulerGroupKey)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerGroupKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSchedulerGroupName)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerGroupNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSchedulerGroupNote)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerGroupNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ShellSchedulerGroupParentId).HasColumnName("ShellSchedulerGroupParentID");

                entity.Property(e => e.ShellSchedulerGroupSort).HasColumnName("ShellSchedulerGroupSORT");

                entity.HasOne(d => d.ShellSchedulerGroupParent)
                    .WithMany(p => p.InverseShellSchedulerGroupParent)
                    .HasForeignKey(d => d.ShellSchedulerGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSchedulerGroup<-ShellSchedulerGroupParent");
            });

            modelBuilder.Entity<ShellSchedulerLanguageTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellSchedulerId, e.ShellSchedulerLanguageId });

                entity.Property(e => e.ShellSchedulerId).HasColumnName("ShellSchedulerID");

                entity.Property(e => e.ShellSchedulerLanguageId).HasColumnName("ShellSchedulerLanguageID");

                entity.Property(e => e.ShellSchedulerName)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerNAME")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ShellScheduler)
                    .WithMany(p => p.ShellSchedulerLanguageTable)
                    .HasForeignKey(d => d.ShellSchedulerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSchedulerLanguage<-ShellScheduler");

                entity.HasOne(d => d.ShellSchedulerLanguage)
                    .WithMany(p => p.ShellSchedulerLanguageTable)
                    .HasForeignKey(d => d.ShellSchedulerLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSchedulerLanguage<-ShellLanguageTable");
            });

            modelBuilder.Entity<ShellSchedulerStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellSchedulerStatusId)
                    .HasName("PK_ShellSchedulerStatusID");

                entity.Property(e => e.ShellSchedulerStatusId)
                    .HasColumnName("ShellSchedulerStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSchedulerStatusKey)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerStatusKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSchedulerStatusName)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerStatusNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSchedulerStatusNote)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerStatusNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<ShellSchedulerTable>(entity =>
            {
                entity.HasKey(e => e.ShellSchedulerId)
                    .HasName("PK_ShellSchedulerID");

                entity.Property(e => e.ShellSchedulerId)
                    .HasColumnName("ShellSchedulerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellCollectorId).HasColumnName("ShellCollectorID");

                entity.Property(e => e.ShellMessangerId).HasColumnName("ShellMessangerID");

                entity.Property(e => e.ShellProccessorId).HasColumnName("ShellProccessorID");

                entity.Property(e => e.ShellScedulerDestination).IsRequired();

                entity.Property(e => e.ShellScedulerSource).IsRequired();

                entity.Property(e => e.ShellSchedulerGroupId).HasColumnName("ShellSchedulerGroupID");

                entity.Property(e => e.ShellSchedulerKey)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerKEY")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSchedulerName)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSchedulerNote)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ShellSchedulerSort).HasColumnName("ShellSchedulerSORT");

                entity.Property(e => e.ShellSchedulerStatusId).HasColumnName("ShellSchedulerStatusID");

                entity.Property(e => e.ShellSchedulerTypeId).HasColumnName("ShellSchedulerTypeID");

                entity.Property(e => e.ShellSchedulerValidFrom)
                    .HasColumnName("ShellSchedulerValidFROM")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellSchedulerValidTo)
                    .HasColumnName("ShellSchedulerValidTO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellSynchronizerId).HasColumnName("ShellSynchronizerID");

                entity.Property(e => e.ShellWorkingEndHour).HasDefaultValueSql("((19))");

                entity.Property(e => e.ShellWorkingStartHour).HasDefaultValueSql("((9))");

                entity.Property(e => e.ShellWorkingWeekDays)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('2,3,4,5,6')");

                entity.HasOne(d => d.ShellSchedulerGroup)
                    .WithMany(p => p.ShellSchedulerTable)
                    .HasForeignKey(d => d.ShellSchedulerGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellScheduler<-ShellSchedulerGroup");

                entity.HasOne(d => d.ShellSchedulerStatus)
                    .WithMany(p => p.ShellSchedulerTable)
                    .HasForeignKey(d => d.ShellSchedulerStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellScheduler<-ShellSchedulerStatus");

                entity.HasOne(d => d.ShellSchedulerType)
                    .WithMany(p => p.ShellSchedulerTable)
                    .HasForeignKey(d => d.ShellSchedulerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellScheduler<-ShellSchedulerType");
            });

            modelBuilder.Entity<ShellSchedulerTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellSchedulerTypeId)
                    .HasName("PK_ShellSchedulerTypeID");

                entity.Property(e => e.ShellSchedulerTypeId)
                    .HasColumnName("ShellSchedulerTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSchedulerTypeKey)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerTypeKEY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSchedulerTypeName)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerTypeNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSchedulerTypeNote)
                    .IsRequired()
                    .HasColumnName("ShellSchedulerTypeNOTE")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<ShellSettingGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellSettingGroupId)
                    .HasName("PK_ShellSettingGroupID");

                entity.HasIndex(e => e.ShellSettingGroupKey)
                    .HasName("IX_ShellSettingGroupKey")
                    .IsUnique();

                entity.Property(e => e.ShellSettingGroupId)
                    .HasColumnName("ShellSettingGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSettingGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSettingGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellSettingGroupParentId).HasColumnName("ShellSettingGroupParentID");

                entity.HasOne(d => d.ShellSettingGroupParent)
                    .WithMany(p => p.InverseShellSettingGroupParent)
                    .HasForeignKey(d => d.ShellSettingGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSettingGroup<-ShellSettingGroupParent");
            });

            modelBuilder.Entity<ShellSettingStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellSettingStatusId)
                    .HasName("PK_ShellSettingStatusID");

                entity.Property(e => e.ShellSettingStatusId)
                    .HasColumnName("ShellSettingStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSettingStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSettingStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellSettingTable>(entity =>
            {
                entity.HasKey(e => e.ShellSettingId)
                    .HasName("PK_ShellSettingID");

                entity.HasIndex(e => e.ShellSettingKey)
                    .HasName("IX_ShellSettingKey")
                    .IsUnique();

                entity.Property(e => e.ShellSettingId).HasColumnName("ShellSettingID");

                entity.Property(e => e.ShellSettingGroupId).HasColumnName("ShellSettingGroupID");

                entity.Property(e => e.ShellSettingKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSettingName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellSettingSortId).HasColumnName("ShellSettingSortID");

                entity.Property(e => e.ShellSettingStatusId).HasColumnName("ShellSettingStatusID");

                entity.Property(e => e.ShellSettingTypeId).HasColumnName("ShellSettingTypeID");

                entity.Property(e => e.ShellSettingValue).IsRequired();

                entity.HasOne(d => d.ShellSettingGroup)
                    .WithMany(p => p.ShellSettingTable)
                    .HasForeignKey(d => d.ShellSettingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSetting<-ShellSettingGroup");

                entity.HasOne(d => d.ShellSettingStatus)
                    .WithMany(p => p.ShellSettingTable)
                    .HasForeignKey(d => d.ShellSettingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSetting<-ShellSettingStatus");

                entity.HasOne(d => d.ShellSettingType)
                    .WithMany(p => p.ShellSettingTable)
                    .HasForeignKey(d => d.ShellSettingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellSetting<-ShellSettingType");
            });

            modelBuilder.Entity<ShellSettingTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellSettingTypeId)
                    .HasName("PK_ShellSettingTypeID");

                entity.Property(e => e.ShellSettingTypeId)
                    .HasColumnName("ShellSettingTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSettingTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSettingTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellSettingValueTable>(entity =>
            {
                entity.HasKey(e => e.ShellSettingValueId)
                    .HasName("PK_ShellSettingValueID");

                entity.Property(e => e.ShellSettingValueId).HasColumnName("ShellSettingValueID");

                entity.Property(e => e.ShellSettingId).HasColumnName("ShellSettingID");

                entity.Property(e => e.ShellSettingValue).IsRequired();

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.HasOne(d => d.ShellSetting)
                    .WithMany(p => p.ShellSettingValueTable)
                    .HasForeignKey(d => d.ShellSettingId)
                    .HasConstraintName("FK_ShellSettingValue<-ShellSetting");

                entity.HasOne(d => d.ShellUser)
                    .WithMany(p => p.ShellSettingValueTable)
                    .HasForeignKey(d => d.ShellUserId)
                    .HasConstraintName("FK_ShellSettingValue<-ShellUser");
            });

            modelBuilder.Entity<ShellTermGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellTermGroupId)
                    .HasName("PK_ShellTermGroupID");

                entity.HasIndex(e => e.ShellTermGroupKey)
                    .HasName("IX_ShellTermGroupKey")
                    .IsUnique();

                entity.Property(e => e.ShellTermGroupId)
                    .HasColumnName("ShellTermGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellTermGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellTermGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellTermGroupParentId).HasColumnName("ShellTermGroupParentID");

                entity.HasOne(d => d.ShellTermGroupParent)
                    .WithMany(p => p.InverseShellTermGroupParent)
                    .HasForeignKey(d => d.ShellTermGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellTermGroup<-ShellTermGroupParent");
            });

            modelBuilder.Entity<ShellTermNameTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellLanguageId, e.ShellTermId });

                entity.Property(e => e.ShellLanguageId).HasColumnName("ShellLanguageID");

                entity.Property(e => e.ShellTermId).HasColumnName("ShellTermID");

                entity.Property(e => e.ShellTermName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ShellLanguage)
                    .WithMany(p => p.ShellTermNameTable)
                    .HasForeignKey(d => d.ShellLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellTermName<-ShellLanguage");

                entity.HasOne(d => d.ShellTerm)
                    .WithMany(p => p.ShellTermNameTable)
                    .HasForeignKey(d => d.ShellTermId)
                    .HasConstraintName("FK_ShellTermName<-ShellTerm");
            });

            modelBuilder.Entity<ShellTermStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellTermStatusId)
                    .HasName("PK_ShellTermStatusID");

                entity.Property(e => e.ShellTermStatusId)
                    .HasColumnName("ShellTermStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellTermStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellTermStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellTermTable>(entity =>
            {
                entity.HasKey(e => e.ShellTermId)
                    .HasName("PK_ShellTermID");

                entity.HasIndex(e => e.ShellTermKey)
                    .HasName("IX_ShellTermKey")
                    .IsUnique();

                entity.Property(e => e.ShellTermId)
                    .HasColumnName("ShellTermID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellTermFormat).IsRequired();

                entity.Property(e => e.ShellTermGroupId).HasColumnName("ShellTermGroupID");

                entity.Property(e => e.ShellTermKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellTermName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellTermSortId).HasColumnName("ShellTermSortID");

                entity.Property(e => e.ShellTermStatusId).HasColumnName("ShellTermStatusID");

                entity.Property(e => e.ShellTermTypeId).HasColumnName("ShellTermTypeID");

                entity.HasOne(d => d.ShellTermGroup)
                    .WithMany(p => p.ShellTermTable)
                    .HasForeignKey(d => d.ShellTermGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellTerm<-ShellTermGroup");

                entity.HasOne(d => d.ShellTermStatus)
                    .WithMany(p => p.ShellTermTable)
                    .HasForeignKey(d => d.ShellTermStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellTerm<-ShellTermStatus");

                entity.HasOne(d => d.ShellTermType)
                    .WithMany(p => p.ShellTermTable)
                    .HasForeignKey(d => d.ShellTermTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellTerm<-ShellTermType");
            });

            modelBuilder.Entity<ShellTermTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellTermTypeId)
                    .HasName("PK_ShellTermTypeID");

                entity.Property(e => e.ShellTermTypeId)
                    .HasColumnName("ShellTermTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellTermTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellTermTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellUserGroupTable>(entity =>
            {
                entity.HasKey(e => e.ShellUserGroupId)
                    .HasName("PK_ShellUserGroupID");

                entity.HasIndex(e => e.ShellUserGroupKey)
                    .HasName("IX_ShellUserGroupKey")
                    .IsUnique();

                entity.Property(e => e.ShellUserGroupId)
                    .HasColumnName("ShellUserGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellUserGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellUserGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellUserGroupParentId).HasColumnName("ShellUserGroupParentID");

                entity.HasOne(d => d.ShellUserGroupParent)
                    .WithMany(p => p.InverseShellUserGroupParent)
                    .HasForeignKey(d => d.ShellUserGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellUserGroup<-ShellUserGroupParent");
            });

            modelBuilder.Entity<ShellUserStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellUserStatusId)
                    .HasName("PK_ShellUserStatusID");

                entity.Property(e => e.ShellUserStatusId)
                    .HasColumnName("ShellUserStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellUserStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellUserStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShellUserTable>(entity =>
            {
                entity.HasKey(e => e.ShellUserId)
                    .HasName("PK_ShellUserID");

                entity.HasIndex(e => e.ShellUserKey)
                    .HasName("IX_ShellUserKey")
                    .IsUnique();

                entity.Property(e => e.ShellUserId)
                    .HasColumnName("ShellUserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellLanguageId).HasColumnName("ShellLanguageID");

                entity.Property(e => e.ShellLogOffTime)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.ShellLogOnTime)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellNtcomputerName)
                    .IsRequired()
                    .HasColumnName("ShellNTComputerName")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellNtuserName)
                    .IsRequired()
                    .HasColumnName("ShellNTUserName")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellUserCard)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellUserGroupId).HasColumnName("ShellUserGroupID");

                entity.Property(e => e.ShellUserKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShellUserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShellUserPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShellUserSortId).HasColumnName("ShellUserSortID");

                entity.Property(e => e.ShellUserStatusId).HasColumnName("ShellUserStatusID");

                entity.Property(e => e.ShellUserTypeId).HasColumnName("ShellUserTypeID");

                entity.Property(e => e.ShellUserValidFrom)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellUserValidTo)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ShellLanguage)
                    .WithMany(p => p.ShellUserTable)
                    .HasForeignKey(d => d.ShellLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellUserTable_ShellLanguageTable");

                entity.HasOne(d => d.ShellUserGroup)
                    .WithMany(p => p.ShellUserTable)
                    .HasForeignKey(d => d.ShellUserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellUser<-ShellUserGroup");

                entity.HasOne(d => d.ShellUserStatus)
                    .WithMany(p => p.ShellUserTable)
                    .HasForeignKey(d => d.ShellUserStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellUser<-ShellUserStatus");

                entity.HasOne(d => d.ShellUserType)
                    .WithMany(p => p.ShellUserTable)
                    .HasForeignKey(d => d.ShellUserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShellUser<-ShellUserType");
            });

            modelBuilder.Entity<ShellUserTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellUserTypeId)
                    .HasName("PK_ShellUserTypeID");

                entity.Property(e => e.ShellUserTypeId)
                    .HasColumnName("ShellUserTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellUserTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellUserTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellUserTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ShellWorkStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellWorkStatusId)
                    .HasName("PK_ShellWorkStatusID");

                entity.Property(e => e.ShellWorkStatusId)
                    .HasColumnName("ShellWorkStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellWorkStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellWorkStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellWorkStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockAgingGraphTable>(entity =>
            {
                entity.HasKey(e => e.StockAgingGraphId)
                    .HasName("PK_StockAgingGraphic");

                entity.Property(e => e.StockAgingGraphId)
                    .HasColumnName("StockAgingGraphID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockAgingGraphKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockAgingGraphName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<StockAllocationBaseTable>(entity =>
            {
                entity.HasKey(e => e.StockAllocationBaseId);

                entity.Property(e => e.StockAllocationBaseId)
                    .HasColumnName("StockAllocationBaseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockAllocationBaseKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockAllocationBaseName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockAllocationBaseNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockBomplanGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanGroupId)
                    .HasName("PK_StockBOMPlanGroupID");

                entity.ToTable("StockBOMPlanGroupTable");

                entity.HasIndex(e => e.StockBomplanGroupKey)
                    .HasName("IX_StockBOMPlanGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockBomplanGroupId).HasColumnName("StockBOMPlanGroupID");

                entity.Property(e => e.StockBomplanGroupKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanGroupKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBomplanGroupName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanGroupName")
                    .HasMaxLength(200);

                entity.Property(e => e.StockBomplanGroupNote)
                    .HasColumnName("StockBOMPlanGroupNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.StockBomplanGroupParentId).HasColumnName("StockBOMPlanGroupParentID");

                entity.HasOne(d => d.StockBomplanGroupParent)
                    .WithMany(p => p.InverseStockBomplanGroupParent)
                    .HasForeignKey(d => d.StockBomplanGroupParentId)
                    .HasConstraintName("FK_StockBOMPlanGroup<-StockBOMPlanGroupParent");
            });

            modelBuilder.Entity<StockBomplanLineStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanLineStatusId)
                    .HasName("PK_StockBOMPlanLineStatusID");

                entity.ToTable("StockBOMPlanLineStatusTable");

                entity.Property(e => e.StockBomplanLineStatusId)
                    .HasColumnName("StockBOMPlanLineStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockBomplanLineStatusKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineStatusKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBomplanLineStatusName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineStatusName")
                    .HasMaxLength(200);

                entity.Property(e => e.StockBomplanLineStatusNote)
                    .HasColumnName("StockBOMPlanLineStatusNote")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<StockBomplanLineTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanLineId);

                entity.ToTable("StockBOMPlanLineTable");

                entity.HasIndex(e => new { e.StockBomplanId, e.StockBomplanLineStatusId, e.StockBomplanLineTypeId, e.StockItemId })
                    .HasName("IX_StockBOMPlanLineTable")
                    .IsUnique();

                entity.Property(e => e.StockBomplanLineId).HasColumnName("StockBOMPlanLineID");

                entity.Property(e => e.StockBomplanId).HasColumnName("StockBOMPlanID");

                entity.Property(e => e.StockBomplanLineKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineKey")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockBomplanLineName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockBomplanLineStatusId).HasColumnName("StockBOMPlanLineStatusID");

                entity.Property(e => e.StockBomplanLineTypeId).HasColumnName("StockBOMPlanLineTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.HasOne(d => d.StockBomplan)
                    .WithMany(p => p.StockBomplanLineTable)
                    .HasForeignKey(d => d.StockBomplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlanLineTable_StockBOMPlanTable");

                entity.HasOne(d => d.StockBomplanLineStatus)
                    .WithMany(p => p.StockBomplanLineTable)
                    .HasForeignKey(d => d.StockBomplanLineStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlanLineTable_StockBOMPlanLineStatusTable");

                entity.HasOne(d => d.StockBomplanLineType)
                    .WithMany(p => p.StockBomplanLineTable)
                    .HasForeignKey(d => d.StockBomplanLineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlanLineTable_StockBOMPlanLineTypeTable");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockBomplanLineTable)
                    .HasForeignKey(d => d.StockItemId)
                    .HasConstraintName("FK_StockBOMPlanLineTable_StockItemTable");
            });

            modelBuilder.Entity<StockBomplanLineTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanLineTypeId)
                    .HasName("PK_StockBOMPlanLineTypeID");

                entity.ToTable("StockBOMPlanLineTypeTable");

                entity.Property(e => e.StockBomplanLineTypeId)
                    .HasColumnName("StockBOMPlanLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockBomplanLineTypeKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineTypeKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBomplanLineTypeName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanLineTypeName")
                    .HasMaxLength(200);

                entity.Property(e => e.StockBomplanLineTypeNote)
                    .HasColumnName("StockBOMPlanLineTypeNote")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<StockBomplanStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanStatusId)
                    .HasName("PK_StockBOMPlanStatusID");

                entity.ToTable("StockBOMPlanStatusTable");

                entity.HasIndex(e => e.StockBomplanStatusKey)
                    .HasName("IX_StockBOMPlanStatusKey")
                    .IsUnique();

                entity.Property(e => e.StockBomplanStatusId)
                    .HasColumnName("StockBOMPlanStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockBomplanStatusKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanStatusKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBomplanStatusName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanStatusName")
                    .HasMaxLength(200);

                entity.Property(e => e.StockBomplanStatusNote)
                    .HasColumnName("StockBOMPlanStatusNote")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<StockBomplanTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanId)
                    .HasName("PK_StockBOMPlanID");

                entity.ToTable("StockBOMPlanTable");

                entity.HasIndex(e => new { e.StockBomplanDate, e.StockItemId, e.StockLocationId })
                    .HasName("IX_StockBOMPlanKey")
                    .IsUnique();

                entity.Property(e => e.StockBomplanId).HasColumnName("StockBOMPlanID");

                entity.Property(e => e.StockBomplanDate)
                    .HasColumnName("StockBOMPlanDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockBomplanGroupId).HasColumnName("StockBOMPlanGroupID");

                entity.Property(e => e.StockBomplanKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanKey")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockBomplanName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockBomplanNote)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanNote")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockBomplanStatusId).HasColumnName("StockBOMPlanStatusID");

                entity.Property(e => e.StockBomplanTypeId).HasColumnName("StockBOMPlanTypeID");

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockCompanyId2).HasColumnName("StockCompanyID2");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.HasOne(d => d.StockBomplanGroup)
                    .WithMany(p => p.StockBomplanTable)
                    .HasForeignKey(d => d.StockBomplanGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlan<-StockBOMPlanGroup");

                entity.HasOne(d => d.StockBomplanStatus)
                    .WithMany(p => p.StockBomplanTable)
                    .HasForeignKey(d => d.StockBomplanStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlan<-StockBOMPlanStatus");

                entity.HasOne(d => d.StockBomplanType)
                    .WithMany(p => p.StockBomplanTable)
                    .HasForeignKey(d => d.StockBomplanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBOMPlan<-StockBOMPlanType");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockBomplanTable)
                    .HasForeignKey(d => d.StockItemId)
                    .HasConstraintName("FK_StockBOMPlanTable_StockItemTable");
            });

            modelBuilder.Entity<StockBomplanTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockBomplanTypeId)
                    .HasName("PK_StockBOMPlanTypeID");

                entity.ToTable("StockBOMPlanTypeTable");

                entity.HasIndex(e => e.StockBomplanTypeKey)
                    .HasName("IX_StockBOMPlanTypeKey")
                    .IsUnique();

                entity.Property(e => e.StockBomplanTypeId)
                    .HasColumnName("StockBOMPlanTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockBomplanTypeKey)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanTypeKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBomplanTypeName)
                    .IsRequired()
                    .HasColumnName("StockBOMPlanTypeName")
                    .HasMaxLength(200);

                entity.Property(e => e.StockBomplanTypeNote)
                    .HasColumnName("StockBOMPlanTypeNote")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<StockBudgetTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockBudgetTypeId);

                entity.Property(e => e.StockBudgetTypeId)
                    .HasColumnName("StockBudgetTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockBudgetTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockBudgetTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockBudgetTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCarGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockCarGroupId)
                    .HasName("PK_StockCarGroupID");

                entity.HasIndex(e => e.StockCarGroupKey)
                    .HasName("IX_StockCarGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockCarGroupId)
                    .HasColumnName("StockCarGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCarGroupKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCarGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCarGroupNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCarGroupParentId).HasColumnName("StockCarGroupParentID");

                entity.HasOne(d => d.StockCarGroupParent)
                    .WithMany(p => p.InverseStockCarGroupParent)
                    .HasForeignKey(d => d.StockCarGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockCarGroup<-StockCarGroupParent");
            });

            modelBuilder.Entity<StockCarStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockCarStatusId)
                    .HasName("PK_StockCarStatusID");

                entity.Property(e => e.StockCarStatusId)
                    .HasColumnName("StockCarStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCarStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCarStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCarStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCarTable>(entity =>
            {
                entity.HasKey(e => e.StockCarId)
                    .HasName("PK_StockCarID");

                entity.HasIndex(e => e.StockCarKey)
                    .HasName("IX_StockCarKey")
                    .IsUnique();

                entity.Property(e => e.StockCarId)
                    .HasColumnName("StockCarID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCarGroupId).HasColumnName("StockCarGroupID");

                entity.Property(e => e.StockCarKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCarName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCarNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCarStatusId).HasColumnName("StockCarStatusID");

                entity.Property(e => e.StockCarTypeId).HasColumnName("StockCarTypeID");

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockPersonId).HasColumnName("StockPersonID");

                entity.HasOne(d => d.StockCarGroup)
                    .WithMany(p => p.StockCarTable)
                    .HasForeignKey(d => d.StockCarGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockCar<-StockCarGroup");

                entity.HasOne(d => d.StockCarStatus)
                    .WithMany(p => p.StockCarTable)
                    .HasForeignKey(d => d.StockCarStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockCar<-StockCarStatus");

                entity.HasOne(d => d.StockCarType)
                    .WithMany(p => p.StockCarTable)
                    .HasForeignKey(d => d.StockCarTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockCar<-StockCarType");
            });

            modelBuilder.Entity<StockCarTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockCarTypeId)
                    .HasName("PK_StockCarTypeID");

                entity.Property(e => e.StockCarTypeId)
                    .HasColumnName("StockCarTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCarTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCarTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCarTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCompanyCardGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyCardGroupId)
                    .HasName("PK_StockCompanyCardGroupID");

                entity.Property(e => e.StockCompanyCardGroupId)
                    .HasColumnName("StockCompanyCardGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyCardGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyCardGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCompanyCardGroupNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyCardGroupParentId).HasColumnName("StockCompanyCardGroupParentID");
            });

            modelBuilder.Entity<StockCompanyCardStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyCardStatusId)
                    .HasName("PK_CompanyCardStatusID");

                entity.Property(e => e.StockCompanyCardStatusId)
                    .HasColumnName("StockCompanyCardStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyCardStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyCardStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCompanyCardStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCompanyCardTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyCardId)
                    .HasName("PK_CompanyCardID");

                entity.HasIndex(e => e.StockCompanyCardKey)
                    .HasName("IX_StockCompanyCardKey")
                    .IsUnique();

                entity.Property(e => e.StockCompanyCardId)
                    .HasColumnName("StockCompanyCardID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyCardGroupId).HasColumnName("StockCompanyCardGroupID");

                entity.Property(e => e.StockCompanyCardKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyCardName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyCardNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyCardStatusId).HasColumnName("StockCompanyCardStatusID");

                entity.Property(e => e.StockCompanyCardTypeId).HasColumnName("StockCompanyCardTypeID");

                entity.Property(e => e.StockCompanyCardValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockCompanyCardValidTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate()+(30))");

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockQuantity).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<StockCompanyCardTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyCardTypeId)
                    .HasName("PK_StockCompanyCardTypeID");

                entity.Property(e => e.StockCompanyCardTypeId)
                    .HasColumnName("StockCompanyCardTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyCardTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyCardTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCompanyCardTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCompanyGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyGroupId)
                    .HasName("PK_CompanyGroupID");

                entity.HasIndex(e => e.StockCompanyGroupKey)
                    .HasName("IX_StockCompanyGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockCompanyGroupId)
                    .HasColumnName("StockCompanyGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCompanyGroupNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyGroupParentId).HasColumnName("StockCompanyGroupParentID");

                entity.Property(e => e.StockCompanyTypeId).HasColumnName("StockCompanyTypeID");

                entity.HasOne(d => d.StockCompanyGroupParent)
                    .WithMany(p => p.InverseStockCompanyGroupParent)
                    .HasForeignKey(d => d.StockCompanyGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyGroup<-CompanyGroupParent");
            });

            modelBuilder.Entity<StockCompanyStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyStatusId)
                    .HasName("PK_CompanyStatusID");

                entity.Property(e => e.StockCompanyStatusId)
                    .HasColumnName("StockCompanyStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCompanyStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCompanyTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyId)
                    .HasName("PK_StockCompanyID");

                entity.HasIndex(e => e.StockCompanyKey)
                    .HasName("IX_StockCompanyKey")
                    .IsUnique();

                entity.Property(e => e.StockCompanyId)
                    .HasColumnName("StockCompanyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyAddress3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyBankAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyBankCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyBankName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyCountry)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyFax)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyGroupId).HasColumnName("StockCompanyGroupID");

                entity.Property(e => e.StockCompanyKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyMail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCompanyNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyParentId).HasColumnName("StockCompanyParentID");

                entity.Property(e => e.StockCompanyPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanySortId).HasColumnName("StockCompanySortID");

                entity.Property(e => e.StockCompanyStatusId).HasColumnName("StockCompanyStatusID");

                entity.Property(e => e.StockCompanyTaxNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyTypeId).HasColumnName("StockCompanyTypeID");

                entity.Property(e => e.StockCompanyWeb)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockPlanningMethodId).HasColumnName("StockPlanningMethodID");

                entity.Property(e => e.StockPriceId).HasColumnName("StockPriceID");

                entity.Property(e => e.StockTaxId)
                    .HasColumnName("StockTaxID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StockTaxMethodId).HasColumnName("StockTaxMethodID");

                entity.HasOne(d => d.StockCompanyGroup)
                    .WithMany(p => p.StockCompanyTable)
                    .HasForeignKey(d => d.StockCompanyGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company<-CompanyGroup");

                entity.HasOne(d => d.StockCompanyStatus)
                    .WithMany(p => p.StockCompanyTable)
                    .HasForeignKey(d => d.StockCompanyStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company<-CompanyStatus");

                entity.HasOne(d => d.StockCompanyType)
                    .WithMany(p => p.StockCompanyTable)
                    .HasForeignKey(d => d.StockCompanyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company<-CompanyType");

                entity.HasOne(d => d.StockPrice)
                    .WithMany(p => p.StockCompanyTable)
                    .HasForeignKey(d => d.StockPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyTable_StockPriceTable");

                entity.HasOne(d => d.StockTax)
                    .WithMany(p => p.StockCompanyTable)
                    .HasForeignKey(d => d.StockTaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockCompanyTable_StockTaxTable");
            });

            modelBuilder.Entity<StockCompanyTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockCompanyTypeId)
                    .HasName("PK_CompanyTypeID");

                entity.Property(e => e.StockCompanyTypeId)
                    .HasColumnName("StockCompanyTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCompanyTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCompanyTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockCompanyTypeNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");
            });

            modelBuilder.Entity<StockCustomerStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockCustomerStatusId)
                    .HasName("PK_StockCustomerStatusID");

                entity.Property(e => e.StockCustomerStatusId)
                    .HasColumnName("StockCustomerStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCustomerStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCustomerStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCustomerStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockCustomerTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockCustomerTypeId)
                    .HasName("PK_StockCustomerTypeID");

                entity.Property(e => e.StockCustomerTypeId)
                    .HasColumnName("StockCustomerTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockCustomerTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCustomerTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockCustomerTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDeliveryGraphTable>(entity =>
            {
                entity.HasKey(e => e.StockDeliveryGraphId)
                    .HasName("PK_DeliveryGraphxTable");

                entity.Property(e => e.StockDeliveryGraphId)
                    .HasColumnName("StockDeliveryGraphID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDeliveryGraphKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryGraphName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDeliveryGraphTypeId).HasColumnName("StockDeliveryGraphTypeID");
            });

            modelBuilder.Entity<StockDeliveryGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockDeliveryGroupId)
                    .HasName("PK_StockDeliveryGroupID");

                entity.Property(e => e.StockDeliveryGroupId).HasColumnName("StockDeliveryGroupID");

                entity.Property(e => e.StockDeliveryGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDeliveryGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockDeliveryGroupParentId).HasColumnName("StockDeliveryGroupParentID");
            });

            modelBuilder.Entity<StockDeliveryStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockDeliveryStatusId)
                    .HasName("PK_StockDeliveryStatusID");

                entity.Property(e => e.StockDeliveryStatusId)
                    .HasColumnName("StockDeliveryStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDeliveryStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDeliveryStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDeliveryTable>(entity =>
            {
                entity.HasKey(e => e.StockDeliveryId)
                    .HasName("PK_StockDeliveryID");

                entity.Property(e => e.StockDeliveryId)
                    .HasColumnName("StockDeliveryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDeliveryGroupId).HasColumnName("StockDeliveryGroupID");

                entity.Property(e => e.StockDeliveryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDeliveryNote).HasColumnType("ntext");

                entity.Property(e => e.StockDeliveryStatusId).HasColumnName("StockDeliveryStatusID");

                entity.Property(e => e.StockDeliveryTypeId).HasColumnName("StockDeliveryTypeID");
            });

            modelBuilder.Entity<StockDeliveryTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockDeliveryTypeId)
                    .HasName("PK_StockDeliveryTypeID");

                entity.Property(e => e.StockDeliveryTypeId)
                    .HasColumnName("StockDeliveryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDeliveryTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDeliveryTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDiscountGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountGroupId)
                    .HasName("PK_StockDiscountGroupID");

                entity.Property(e => e.StockDiscountGroupId)
                    .HasColumnName("StockDiscountGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountGroupNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockDiscountGroupParentId).HasColumnName("StockDiscountGroupParentID");
            });

            modelBuilder.Entity<StockDiscountLineStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountLineStatusId)
                    .HasName("PK_StockDiscountLineStatusID");

                entity.Property(e => e.StockDiscountLineStatusId)
                    .HasColumnName("StockDiscountLineStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountLineStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountLineStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountLineStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDiscountLineTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountLineId);

                entity.Property(e => e.StockDiscountLineId)
                    .HasColumnName("StockDiscountLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountId).HasColumnName("StockDiscountID");

                entity.Property(e => e.StockDiscountLineKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockDiscountLineName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockDiscountLineSortId).HasColumnName("StockDiscountLineSortID");

                entity.Property(e => e.StockDiscountLineStatusId).HasColumnName("StockDiscountLineStatusID");

                entity.Property(e => e.StockDiscountLineTypeId).HasColumnName("StockDiscountLineTypeID");

                entity.Property(e => e.StockDiscountLineValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.StockDiscountLineValidTo).HasColumnType("datetime");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");
            });

            modelBuilder.Entity<StockDiscountLineTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountLineTypeId)
                    .HasName("PK_StockDiscountLineTypeID");

                entity.Property(e => e.StockDiscountLineTypeId)
                    .HasColumnName("StockDiscountLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountLineTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountLineTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountLineTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDiscountMethodTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountMethodId);

                entity.Property(e => e.StockDiscountMethodId)
                    .HasColumnName("StockDiscountMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountMethodKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountMethodName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountMethodNote).HasColumnType("ntext");

                entity.Property(e => e.StockDiscountMethodStatusId).HasColumnName("StockDiscountMethodStatusID");

                entity.Property(e => e.StockDiscountMethodTypeId).HasColumnName("StockDiscountMethodTypeID");

                entity.Property(e => e.StockDiscountMethodValidFrom).HasColumnType("datetime");

                entity.Property(e => e.StockDiscountMethodValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<StockDiscountStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountStatusId)
                    .HasName("PK_StockDiscountStatusID");

                entity.Property(e => e.StockDiscountStatusId)
                    .HasColumnName("StockDiscountStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockDiscountTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountId)
                    .HasName("PK_StockDiscountID");

                entity.Property(e => e.StockDiscountId)
                    .HasColumnName("StockDiscountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountGroupId).HasColumnName("StockDiscountGroupID");

                entity.Property(e => e.StockDiscountKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockDiscountNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockDiscountStatusId).HasColumnName("StockDiscountStatusID");

                entity.Property(e => e.StockDiscountTypeId)
                    .HasColumnName("StockDiscountTypeID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.StockDiscountValidFrom).HasColumnType("datetime");

                entity.Property(e => e.StockDiscountValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.StockDiscountStatus)
                    .WithMany(p => p.StockDiscountTable)
                    .HasForeignKey(d => d.StockDiscountStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDiscount<-StockDiscountStatus");

                entity.HasOne(d => d.StockDiscountType)
                    .WithMany(p => p.StockDiscountTable)
                    .HasForeignKey(d => d.StockDiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockDiscount<-StockDiscountType");
            });

            modelBuilder.Entity<StockDiscountTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockDiscountTypeId)
                    .HasName("PK_StockDiscountTypeID");

                entity.Property(e => e.StockDiscountTypeId)
                    .HasColumnName("StockDiscountTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockDiscountTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDiscountTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockDiscountTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockEntryLineStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryLineStatusId)
                    .HasName("PK_StockEntryLineStatusID");

                entity.Property(e => e.StockEntryLineStatusId)
                    .HasColumnName("StockEntryLineStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntryLineStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntryLineStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockEntryLineStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockEntryLineTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryLineId)
                    .HasName("PK_StockEntryLineID");

                entity.HasIndex(e => e.StockEntryId)
                    .HasName("IX_StockEntryID");

                entity.HasIndex(e => new { e.StockAmount, e.StockEntryLineStatusId, e.StockEntryLineTypeId, e.StockQuantity, e.StockLocationId, e.StockEntryId, e.StockItemId, e.StockEntryLineId })
                    .HasName("VALUATION_dta_index_StockEntryLineTable_7_268580045__K7_K6_K14_K10_K3_K12_K1_15");

                entity.HasIndex(e => new { e.StockAmount, e.TransTotalTaxAmount, e.TransTotalBaseAmount, e.StockEntryLineStatusId, e.StockLocationId, e.StockEntryId, e.StockItemId, e.StockEntryLineId, e.StockEntryLineParentId, e.StockEntryLineTypeId, e.StockQuantity })
                    .HasName("VALUATION_dta_index_StockEntryLineTable_7_268580045__K7_K10_K3_K12_K1_K8_K6_K14_15_48_49");

                entity.Property(e => e.StockEntryLineId)
                    .HasColumnName("StockEntryLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsentryId).HasColumnName("RSEntryID");

                entity.Property(e => e.RsentryLineId).HasColumnName("RSEntryLineID");

                entity.Property(e => e.RsentryLineParentId).HasColumnName("RSEntryLineParentID");

                entity.Property(e => e.RsentryParentId).HasColumnName("RSEntryParentID");

                entity.Property(e => e.ShellSyncDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellSyncProcessId)
                    .HasColumnName("ShellSyncProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.StockBomplanLineStatusId).HasColumnName("StockBOMPlanLineStatusID");

                entity.Property(e => e.StockBomplanLineTypeId).HasColumnName("StockBOMPlanLineTypeID");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryId2).HasColumnName("StockEntryID2");

                entity.Property(e => e.StockEntryLineDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryLineDate2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryLineId2).HasColumnName("StockEntryLineID2");

                entity.Property(e => e.StockEntryLineKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryLineParentId2).HasColumnName("StockEntryLineParentID2");

                entity.Property(e => e.StockEntryLineSortId).HasColumnName("StockEntryLineSortID");

                entity.Property(e => e.StockEntryLineStatusId).HasColumnName("StockEntryLineStatusID");

                entity.Property(e => e.StockEntryLineTypeId).HasColumnName("StockEntryLineTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemId2).HasColumnName("StockItemID2");

                entity.Property(e => e.StockItemKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemBomid).HasColumnName("TransItemBOMID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransQuantityAllowChange).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransQuantityFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransServiceId).HasColumnName("TransServiceID");

                entity.HasOne(d => d.StockEntry)
                    .WithMany(p => p.StockEntryLineTable)
                    .HasForeignKey(d => d.StockEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryLineTable_StockEntryTable");

                entity.HasOne(d => d.StockEntryLineStatus)
                    .WithMany(p => p.StockEntryLineTable)
                    .HasForeignKey(d => d.StockEntryLineStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryLineTable_StockEntryLineStatusTable");

                entity.HasOne(d => d.StockEntryLineType)
                    .WithMany(p => p.StockEntryLineTable)
                    .HasForeignKey(d => d.StockEntryLineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryLineTable_StockEntryLineTypeTable");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockEntryLineTable)
                    .HasForeignKey(d => d.StockItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryLineTable_StockItemTable");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.StockEntryLineTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryLineTable_StockLocationTable");
            });

            modelBuilder.Entity<StockEntryLineTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryLineTypeId)
                    .HasName("PK_StockEntryLineTypeID");

                entity.Property(e => e.StockEntryLineTypeId)
                    .HasColumnName("StockEntryLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntryLineTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntryLineTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockEntryLineTypeNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");
            });

            modelBuilder.Entity<StockEntryStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryStatusId)
                    .HasName("PK_StockEntryStatusID");

                entity.Property(e => e.StockEntryStatusId)
                    .HasColumnName("StockEntryStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntryStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntryStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockEntryStatusNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockR0flag).HasColumnName("StockR0Flag");

                entity.Property(e => e.StockR2flag).HasColumnName("StockR2Flag");

                entity.Property(e => e.StockR3flag).HasColumnName("StockR3Flag");

                entity.Property(e => e.StockR5flag).HasColumnName("StockR5Flag");

                entity.Property(e => e.StockR9flag).HasColumnName("StockR9Flag");
            });

            modelBuilder.Entity<StockEntryTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryId)
                    .HasName("PK_StockEntryID");

                entity.HasIndex(e => new { e.StockEntryId, e.StockEntryDate, e.StockEntryStatusId })
                    .HasName("VALUATION_dta_index_StockEntryTable_7_1052582838__K10_K8_1");

                entity.Property(e => e.StockEntryId)
                    .HasColumnName("StockEntryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RsmessageCounterId).HasColumnName("RSMessageCounterID");

                entity.Property(e => e.RsmessageId).HasColumnName("RSMessageID");

                entity.Property(e => e.RssyncDate)
                    .HasColumnName("RSSyncDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RssyncProcessId)
                    .HasColumnName("RSSyncProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.RswaybillConfirmId).HasColumnName("RSWaybillConfirmID");

                entity.Property(e => e.RswaybillId).HasColumnName("RSWaybillID");

                entity.Property(e => e.RswaybillKey)
                    .IsRequired()
                    .HasColumnName("RSWaybillKey")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.RswaybillParentId).HasColumnName("RSWaybillParentID");

                entity.Property(e => e.RswaybillParentKey)
                    .IsRequired()
                    .HasColumnName("RSWaybillParentKey")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.RswaybillTypeId).HasColumnName("RSWaybillTypeID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellModifierUserId).HasColumnName("ShellModifierUserID");

                entity.Property(e => e.ShellSyncDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellSyncProcessId)
                    .HasColumnName("ShellSyncProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.StockAllocationBaseId).HasColumnName("StockAllocationBaseID");

                entity.Property(e => e.StockCarId).HasColumnName("StockCarID");

                entity.Property(e => e.StockDeliveryId).HasColumnName("StockDeliveryID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDate2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId2).HasColumnName("StockEntryID2");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryParentId2).HasColumnName("StockEntryParentID2");

                entity.Property(e => e.StockEntrySortId).HasColumnName("StockEntrySortID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemGroupId).HasColumnName("StockItemGroupID");

                entity.Property(e => e.StockItemGroupId2).HasColumnName("StockItemGroupID2");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockPayPeriodId).HasColumnName("StockPayPeriodID");

                entity.Property(e => e.StockPersonId).HasColumnName("StockPersonID");

                entity.Property(e => e.TextCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextCompanyKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockCarKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockCarName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockPersonKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockPersonName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransCompanyId2).HasColumnName("TransCompanyID2");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransLocationShelfId).HasColumnName("TransLocationShelfID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransServiceId).HasColumnName("TransServiceID");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");

                entity.HasOne(d => d.ShellCustomer)
                    .WithMany(p => p.StockEntryTableShellCustomer)
                    .HasForeignKey(d => d.ShellCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockCompanyTable1");

                entity.HasOne(d => d.ShellUser)
                    .WithMany(p => p.StockEntryTable)
                    .HasForeignKey(d => d.ShellUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_ShellUserTable");

                entity.HasOne(d => d.StockCar)
                    .WithMany(p => p.StockEntryTable)
                    .HasForeignKey(d => d.StockCarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockCarTable");

                entity.HasOne(d => d.StockEntryStatus)
                    .WithMany(p => p.StockEntryTable)
                    .HasForeignKey(d => d.StockEntryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockEntryStatusTable");

                entity.HasOne(d => d.StockEntryType)
                    .WithMany(p => p.StockEntryTable)
                    .HasForeignKey(d => d.StockEntryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockEntryTypeTable");

                entity.HasOne(d => d.StockPerson)
                    .WithMany(p => p.StockEntryTable)
                    .HasForeignKey(d => d.StockPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockPersonTable");

                entity.HasOne(d => d.TransCompany)
                    .WithMany(p => p.StockEntryTableTransCompany)
                    .HasForeignKey(d => d.TransCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockEntryTable_StockCompanyTable");
            });

            modelBuilder.Entity<StockEntryTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryTypeId)
                    .HasName("PK_StockEntryTypeID");

                entity.Property(e => e.StockEntryTypeId)
                    .HasColumnName("StockEntryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntryTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntryTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockEntryTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockItemBarcodeTable>(entity =>
            {
                entity.HasKey(e => new { e.StockItemId, e.StockItemBarcodeKey })
                    .HasName("PK_StockItemBarcodeXX");

                entity.HasIndex(e => e.StockItemBarcodeKey)
                    .HasName("IX_StockItemBarcodeKey")
                    .IsUnique();

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemBarcodeKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemBarcodeId).HasColumnName("StockItemBarcodeID");

                entity.Property(e => e.StockItemBarcodeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockItemBarcodeTable)
                    .HasForeignKey(d => d.StockItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemBarcodeTable_StockItemTable");
            });

            modelBuilder.Entity<StockItemByLocationTable>(entity =>
            {
                entity.HasKey(e => new { e.StockLocationId, e.StockItemId })
                    .HasName("PK_Stock");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.SalesItemId).HasColumnName("SalesItemID");

                entity.Property(e => e.SalesItemUnitId).HasColumnName("SalesItemUnitID");

                entity.Property(e => e.SalesTaxId).HasColumnName("SalesTaxID");
            });

            modelBuilder.Entity<StockItemGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockItemGroupId)
                    .HasName("PK_StockItemGroupID");

                entity.HasIndex(e => e.StockItemGroupKey)
                    .HasName("IX_StockItemGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockItemGroupId)
                    .HasColumnName("StockItemGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemGroupDiscountId).HasColumnName("StockItemGroupDiscountID");

                entity.Property(e => e.StockItemGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StockItemGroupNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockItemGroupParentId).HasColumnName("StockItemGroupParentID");

                entity.Property(e => e.StockItemGroupSortId).HasColumnName("StockItemGroupSortID");

                entity.Property(e => e.StockItemTypeId).HasColumnName("StockItemTypeID");

                entity.HasOne(d => d.StockItemGroupParent)
                    .WithMany(p => p.InverseStockItemGroupParent)
                    .HasForeignKey(d => d.StockItemGroupParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemGroup<-StockItemGroupParent");
            });

            modelBuilder.Entity<StockItemKindTable>(entity =>
            {
                entity.HasKey(e => new { e.StockItemId, e.StockItemKindKey });

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemKindKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemKindId)
                    .HasColumnName("StockItemKindID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockItemKindName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemKindStatusId).HasColumnName("StockItemKindStatusID");
            });

            modelBuilder.Entity<StockItemStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockItemStatusId)
                    .HasName("PK_StockItemStatusID");

                entity.Property(e => e.StockItemStatusId)
                    .HasColumnName("StockItemStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockItemTable>(entity =>
            {
                entity.HasKey(e => e.StockItemId)
                    .HasName("PK_StockItemID");

                entity.HasIndex(e => e.StockItemKey)
                    .HasName("IX_StockItemKey")
                    .IsUnique();

                entity.Property(e => e.StockItemId)
                    .HasColumnName("StockItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemBarcodeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockItemGroupId).HasColumnName("StockItemGroupID");

                entity.Property(e => e.StockItemGweight).HasColumnName("StockItemGWeight");

                entity.Property(e => e.StockItemId2).HasColumnName("StockItemID2");

                entity.Property(e => e.StockItemKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemNote)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockItemNote2)
                    .IsRequired()
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockItemNweight).HasColumnName("StockItemNWeight");

                entity.Property(e => e.StockItemSortId).HasColumnName("StockItemSortID");

                entity.Property(e => e.StockItemStatusId).HasColumnName("StockItemStatusID");

                entity.Property(e => e.StockItemTypeId).HasColumnName("StockItemTypeID");

                entity.Property(e => e.StockItemUnitId).HasColumnName("StockItemUnitID");

                entity.Property(e => e.StockMarkupGroupId).HasColumnName("StockMarkupGroupID");

                entity.Property(e => e.StockQuantity2).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockQuantity3).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockTaxId).HasColumnName("StockTaxID");

                entity.HasOne(d => d.StockItemGroup)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockItemGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockItemGroupTable");

                entity.HasOne(d => d.StockItemStatus)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockItemStatusTable");

                entity.HasOne(d => d.StockItemType)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockItemTypeTable");

                entity.HasOne(d => d.StockItemUnit)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockItemUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockItemUnitTable");

                entity.HasOne(d => d.StockMarkupGroup)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockMarkupGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockMarkupGroupTable");

                entity.HasOne(d => d.StockTax)
                    .WithMany(p => p.StockItemTable)
                    .HasForeignKey(d => d.StockTaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemTable_StockTaxTable");
            });

            modelBuilder.Entity<StockItemTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockItemTypeId)
                    .HasName("PK_StockItemTypeID");

                entity.Property(e => e.StockItemTypeId)
                    .HasColumnName("StockItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockItemUnitGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockItemUnitGroupId)
                    .HasName("PK_StockItemUnitGroupID");

                entity.Property(e => e.StockItemUnitGroupId).HasColumnName("StockItemUnitGroupID");

                entity.Property(e => e.StockItemUnitGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemUnitGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemUnitGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockItemUnitGroupParentId).HasColumnName("StockItemUnitGroupParentID");

                entity.HasOne(d => d.StockItemUnitGroupParent)
                    .WithMany(p => p.InverseStockItemUnitGroupParent)
                    .HasForeignKey(d => d.StockItemUnitGroupParentId)
                    .HasConstraintName("FK_StockItemUnitGroup<-StockItemUnitGroupParent");
            });

            modelBuilder.Entity<StockItemUnitStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockItemUnitStatusId)
                    .HasName("PK_StockItemUnitStatusID");

                entity.Property(e => e.StockItemUnitStatusId)
                    .HasColumnName("StockItemUnitStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemUnitStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemUnitStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemUnitStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockItemUnitTable>(entity =>
            {
                entity.HasKey(e => e.StockItemUnitId)
                    .HasName("PK_StockItemUnitID");

                entity.HasIndex(e => e.StockItemUnitKey)
                    .HasName("IX_StockItemUnitKey")
                    .IsUnique();

                entity.Property(e => e.StockItemUnitId)
                    .HasColumnName("StockItemUnitID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemUnitGroupId).HasColumnName("StockItemUnitGroupID");

                entity.Property(e => e.StockItemUnitKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemUnitName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemUnitSortId).HasColumnName("StockItemUnitSortID");

                entity.Property(e => e.StockItemUnitStatusId).HasColumnName("StockItemUnitStatusID");

                entity.Property(e => e.StockItemUnitTypeId).HasColumnName("StockItemUnitTypeID");

                entity.HasOne(d => d.StockItemUnitGroup)
                    .WithMany(p => p.StockItemUnitTable)
                    .HasForeignKey(d => d.StockItemUnitGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemUnit<-StockItemUnitGroup");

                entity.HasOne(d => d.StockItemUnitStatus)
                    .WithMany(p => p.StockItemUnitTable)
                    .HasForeignKey(d => d.StockItemUnitStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemUnit<-StockItemUnitStatus");

                entity.HasOne(d => d.StockItemUnitType)
                    .WithMany(p => p.StockItemUnitTable)
                    .HasForeignKey(d => d.StockItemUnitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemUnit<-StockItemUnitType");
            });

            modelBuilder.Entity<StockItemUnitTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockItemUnitTypeId)
                    .HasName("PK_StockItemUnitTypeID");

                entity.Property(e => e.StockItemUnitTypeId)
                    .HasColumnName("StockItemUnitTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemUnitTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockItemUnitTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockItemUnitTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationAddressTable>(entity =>
            {
                entity.HasKey(e => new { e.StockCompanyId, e.StockLocationAddress });

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockLocationAddress).HasMaxLength(100);

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.HasOne(d => d.StockCompany)
                    .WithMany(p => p.StockLocationAddressTable)
                    .HasForeignKey(d => d.StockCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationAddressTable_StockCompanyTable");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.StockLocationAddressTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .HasConstraintName("FK_StockLocationAddressTable_StockLocationTable");
            });

            modelBuilder.Entity<StockLocationGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationGroupId)
                    .HasName("PK_StockLocationGroupID");

                entity.HasIndex(e => e.StockLocationGroupKey)
                    .HasName("IX_StockLocationGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockLocationGroupId).HasColumnName("StockLocationGroupID");

                entity.Property(e => e.StockLocationGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockLocationGroupParentId).HasColumnName("StockLocationGroupParentID");

                entity.HasOne(d => d.StockLocationGroupParent)
                    .WithMany(p => p.InverseStockLocationGroupParent)
                    .HasForeignKey(d => d.StockLocationGroupParentId)
                    .HasConstraintName("FK_StockLocationGroup<-StockLocationGroupParent");
            });

            modelBuilder.Entity<StockLocationItemStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationItemStatusId)
                    .HasName("PK_StockLocationItemStatusID");

                entity.Property(e => e.StockLocationItemStatusId)
                    .HasColumnName("StockLocationItemStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationItemStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationItemStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationItemStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationItemTable>(entity =>
            {
                entity.HasKey(e => new { e.StockLocationId, e.StockItemId });

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.Dmquantity).HasColumnName("DMQuantity");

                entity.Property(e => e.OrderFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDays).HasDefaultValueSql("((30))");

                entity.Property(e => e.StockDeliveryGraphId).HasColumnName("StockDeliveryGraphID");

                entity.Property(e => e.StockDeliveryTypeId).HasColumnName("StockDeliveryTypeID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockLocationItemSortId).HasColumnName("StockLocationItemSortID");

                entity.Property(e => e.StockLocationItemStatusId).HasColumnName("StockLocationItemStatusID");

                entity.Property(e => e.StockQlimitFactor)
                    .HasColumnName("StockQLimitFactor")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StockRptypeId).HasColumnName("StockRPTypeID");

                entity.Property(e => e.StockSupplierId).HasColumnName("StockSupplierID");

                entity.Property(e => e.StockUsageTypeId).HasColumnName("StockUsageTypeID");

                entity.HasOne(d => d.StockDeliveryGraph)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockDeliveryGraphId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationItemTable_StockDeliveryGraphTable");

                entity.HasOne(d => d.StockDeliveryType)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockDeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationItemTable_StockDeliveryTypeTable");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationItemTable_StockItemTable");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .HasConstraintName("FK_StockLocationItemTable_StockLocationTable");

                entity.HasOne(d => d.StockLocationItemStatus)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockLocationItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationItemTable_StockLocationItemStatusTable");

                entity.HasOne(d => d.StockUsageType)
                    .WithMany(p => p.StockLocationItemTable)
                    .HasForeignKey(d => d.StockUsageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationItemTable_StockUsageTypeTable");
            });

            modelBuilder.Entity<StockLocationRightTable>(entity =>
            {
                entity.HasKey(e => new { e.StockLocationId, e.ShellUserId });

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.StockLocationRightId).HasColumnName("StockLocationRightID");

                entity.Property(e => e.StockLocationRightStatusId).HasColumnName("StockLocationRightStatusID");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.StockLocationRightTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .HasConstraintName("FK_StockLocationRightTable_StockLocationTable");
            });

            modelBuilder.Entity<StockLocationShelfStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationShelfStatusId)
                    .HasName("PK_StockLocationShelfStatusID");

                entity.Property(e => e.StockLocationShelfStatusId)
                    .HasColumnName("StockLocationShelfStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationShelfStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationShelfStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationShelfStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationShelfTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationShelfId);

                entity.HasIndex(e => new { e.StockLocationShelfKey, e.StockLocationId })
                    .HasName("IX_StockLocationShelfTable")
                    .IsUnique();

                entity.Property(e => e.StockLocationShelfId).HasColumnName("StockLocationShelfID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationShelfKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationShelfName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationShelfNote).HasColumnType("ntext");

                entity.Property(e => e.StockLocationShelfSortId).HasColumnName("StockLocationShelfSortID");

                entity.Property(e => e.StockLocationShelfStatusId).HasColumnName("StockLocationShelfStatusID");

                entity.Property(e => e.StockLocationShelfTypeId).HasColumnName("StockLocationShelfTypeID");

                entity.HasOne(d => d.StockLocation)
                    .WithMany(p => p.StockLocationShelfTable)
                    .HasForeignKey(d => d.StockLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationShelfTable_StockLocationTable");

                entity.HasOne(d => d.StockLocationShelfStatus)
                    .WithMany(p => p.StockLocationShelfTable)
                    .HasForeignKey(d => d.StockLocationShelfStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationShelfTable_StockLocationShelfStatusTable");

                entity.HasOne(d => d.StockLocationShelfType)
                    .WithMany(p => p.StockLocationShelfTable)
                    .HasForeignKey(d => d.StockLocationShelfTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocationShelfTable_StockLocationShelfTypeTable");
            });

            modelBuilder.Entity<StockLocationShelfTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationShelfTypeId)
                    .HasName("PK_StockLocationShelfTypeID");

                entity.Property(e => e.StockLocationShelfTypeId)
                    .HasColumnName("StockLocationShelfTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationShelfTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationShelfTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationShelfTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationStatusId)
                    .HasName("PK_StockLocationStatusID");

                entity.Property(e => e.StockLocationStatusId)
                    .HasColumnName("StockLocationStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationId)
                    .HasName("PK_StockLocationID");

                entity.HasIndex(e => e.StockLocationKey)
                    .HasName("IX_StockLocationKey")
                    .IsUnique();

                entity.Property(e => e.StockLocationId)
                    .HasColumnName("StockLocationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExactCostCenter)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExactId).HasColumnName("ExactID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonId2).HasColumnName("PersonID2");

                entity.Property(e => e.PersonId3).HasColumnName("PersonID3");

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockLocationAddress).HasMaxLength(200);

                entity.Property(e => e.StockLocationGroupId).HasColumnName("StockLocationGroupID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockLocationId3).HasColumnName("StockLocationID3");

                entity.Property(e => e.StockLocationKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationNameEn)
                    .HasColumnName("StockLocationName_EN")
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationNameRu)
                    .HasColumnName("StockLocationName_RU")
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationSortId).HasColumnName("StockLocationSortID");

                entity.Property(e => e.StockLocationStatusId).HasColumnName("StockLocationStatusID");

                entity.Property(e => e.StockLocationTypeId).HasColumnName("StockLocationTypeID");

                entity.Property(e => e.StockLocationValidFrom).HasColumnType("datetime");

                entity.Property(e => e.StockLocationValidTo).HasColumnType("datetime");

                entity.Property(e => e.StockPrinterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StockLocationGroup)
                    .WithMany(p => p.StockLocationTable)
                    .HasForeignKey(d => d.StockLocationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocation<-StockLocationGroup");

                entity.HasOne(d => d.StockLocationStatus)
                    .WithMany(p => p.StockLocationTable)
                    .HasForeignKey(d => d.StockLocationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocation<-StockLocationStatus");

                entity.HasOne(d => d.StockLocationType)
                    .WithMany(p => p.StockLocationTable)
                    .HasForeignKey(d => d.StockLocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockLocation<-StockLocationType");
            });

            modelBuilder.Entity<StockLocationTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationTypeId)
                    .HasName("PK_StockLocationTypeID");

                entity.Property(e => e.StockLocationTypeId)
                    .HasColumnName("StockLocationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockLocationZoneTable>(entity =>
            {
                entity.HasKey(e => e.StockLocationZoneId)
                    .HasName("PK_StockLocationZoneID");

                entity.Property(e => e.StockLocationZoneId)
                    .HasColumnName("StockLocationZoneID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockLocationZoneKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockLocationZoneName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockLocationZoneNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockMarkupGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockMarkupGroupId)
                    .HasName("PK_StockMarkupGroupID");

                entity.HasIndex(e => e.StockMarkupGroupKey)
                    .HasName("IX_StockMarkupGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockMarkupGroupId).HasColumnName("StockMarkupGroupID");

                entity.Property(e => e.StockMarkupGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockMarkupGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockMarkupGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockMarkupGroupParentId).HasColumnName("StockMarkupGroupParentID");

                entity.HasOne(d => d.StockMarkupGroupParent)
                    .WithMany(p => p.InverseStockMarkupGroupParent)
                    .HasForeignKey(d => d.StockMarkupGroupParentId)
                    .HasConstraintName("FK_StockMarkupGroup<-StockMarkupGroupParent");
            });

            modelBuilder.Entity<StockMarkupStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockMarkupStatusId)
                    .HasName("PK_StockMarkupStatusID");

                entity.HasIndex(e => e.StockMarkupStatusKey)
                    .HasName("IX_StockMarkupStatusKey")
                    .IsUnique();

                entity.Property(e => e.StockMarkupStatusId)
                    .HasColumnName("StockMarkupStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockMarkupStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockMarkupStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockMarkupStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockMarkupTable>(entity =>
            {
                entity.HasKey(e => e.StockMarkupId)
                    .HasName("PK_StockMarkupID");

                entity.HasIndex(e => e.StockMarkupKey)
                    .HasName("IX_StockMarkupKey")
                    .IsUnique();

                entity.Property(e => e.StockMarkupId).HasColumnName("StockMarkupID");

                entity.Property(e => e.StockCustomerId)
                    .HasColumnName("StockCustomerID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StockMarkupGroupId).HasColumnName("StockMarkupGroupID");

                entity.Property(e => e.StockMarkupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockMarkupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockMarkupRoundFactor).HasDefaultValueSql("((0.001))");

                entity.Property(e => e.StockMarkupStatusId).HasColumnName("StockMarkupStatusID");

                entity.Property(e => e.StockMarkupTypeId).HasColumnName("StockMarkupTypeID");

                entity.Property(e => e.StockSupplierId)
                    .HasColumnName("StockSupplierID")
                    .HasDefaultValueSql("((2))");

                entity.HasOne(d => d.StockMarkupGroup)
                    .WithMany(p => p.StockMarkupTable)
                    .HasForeignKey(d => d.StockMarkupGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockMarkup<-StockMarkupGroup");

                entity.HasOne(d => d.StockMarkupStatus)
                    .WithMany(p => p.StockMarkupTable)
                    .HasForeignKey(d => d.StockMarkupStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockMarkup<-StockMarkupStatus");

                entity.HasOne(d => d.StockMarkupType)
                    .WithMany(p => p.StockMarkupTable)
                    .HasForeignKey(d => d.StockMarkupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockMarkup<-StockMarkupType");
            });

            modelBuilder.Entity<StockMarkupTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockMarkupTypeId)
                    .HasName("PK_StockMarkupTypeID");

                entity.HasIndex(e => e.StockMarkupTypeKey)
                    .HasName("IX_StockMarkupTypeKey")
                    .IsUnique();

                entity.Property(e => e.StockMarkupTypeId)
                    .HasColumnName("StockMarkupTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockMarkupTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockMarkupTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockMarkupTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPayMethodTable>(entity =>
            {
                entity.HasKey(e => e.StockPayMethodId)
                    .HasName("PK_StockPaymentMethodTable");

                entity.Property(e => e.StockPayMethodId)
                    .HasColumnName("StockPayMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPayMethodKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPayMethodName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPayMethodNote).HasColumnType("ntext");

                entity.Property(e => e.StockPayMethodStatusId).HasColumnName("StockPayMethodStatusID");
            });

            modelBuilder.Entity<StockPayPeriodTable>(entity =>
            {
                entity.HasKey(e => e.StockPayPeriodId)
                    .HasName("PK_StockPayPeriodID");

                entity.Property(e => e.StockPayPeriodId)
                    .HasColumnName("StockPayPeriodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellSyncDate).HasColumnType("datetime");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockPayPeriodKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPayPeriodName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPayPeriodStatusId).HasColumnName("StockPayPeriodStatusID");

                entity.Property(e => e.StockPayPeriodValidFrom).HasColumnType("datetime");

                entity.Property(e => e.StockPayPeriodValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<StockPersonGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockPersonGroupId)
                    .HasName("PK_StockPersonGroupID");

                entity.HasIndex(e => e.StockPersonGroupKey)
                    .HasName("IX_StockPersonGroupKey")
                    .IsUnique();

                entity.Property(e => e.StockPersonGroupId)
                    .HasColumnName("StockPersonGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPersonGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPersonGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockPersonGroupParentId).HasColumnName("StockPersonGroupParentID");

                entity.HasOne(d => d.StockPersonGroupParent)
                    .WithMany(p => p.InverseStockPersonGroupParent)
                    .HasForeignKey(d => d.StockPersonGroupParentId)
                    .HasConstraintName("FK_StockPersonGroup<-StockPersonGroupParent");
            });

            modelBuilder.Entity<StockPersonStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockPersonStatusId)
                    .HasName("PK_StockPersonStatusID");

                entity.Property(e => e.StockPersonStatusId)
                    .HasColumnName("StockPersonStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPersonStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPersonStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPersonTable>(entity =>
            {
                entity.HasKey(e => e.StockPersonId)
                    .HasName("PK_StockPersonID");

                entity.HasIndex(e => e.StockPersonKey)
                    .HasName("IX_StockPersonKey")
                    .IsUnique();

                entity.Property(e => e.StockPersonId)
                    .HasColumnName("StockPersonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPersonAddress).HasMaxLength(200);

                entity.Property(e => e.StockPersonAddress2).HasMaxLength(200);

                entity.Property(e => e.StockPersonBirthAddress).HasMaxLength(200);

                entity.Property(e => e.StockPersonBirthDate).HasColumnType("datetime");

                entity.Property(e => e.StockPersonDriverLicense)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonGender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonGroupId).HasColumnName("StockPersonGroupID");

                entity.Property(e => e.StockPersonKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonMail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonMaritalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPersonNote).HasColumnType("ntext");

                entity.Property(e => e.StockPersonPersonalNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonStatusId).HasColumnName("StockPersonStatusID");

                entity.Property(e => e.StockPersonTypeId).HasColumnName("StockPersonTypeID");

                entity.Property(e => e.StockPersonValidFrom).HasColumnType("datetime");

                entity.Property(e => e.StockPersonValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.StockPersonGroup)
                    .WithMany(p => p.StockPersonTable)
                    .HasForeignKey(d => d.StockPersonGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPerson<-StockPersonGroup");

                entity.HasOne(d => d.StockPersonStatus)
                    .WithMany(p => p.StockPersonTable)
                    .HasForeignKey(d => d.StockPersonStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPerson<-StockPersonStatus");

                entity.HasOne(d => d.StockPersonType)
                    .WithMany(p => p.StockPersonTable)
                    .HasForeignKey(d => d.StockPersonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPerson<-StockPersonType");
            });

            modelBuilder.Entity<StockPersonTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockPersonTypeId)
                    .HasName("PK_StockPersonTypeID");

                entity.Property(e => e.StockPersonTypeId)
                    .HasColumnName("StockPersonTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPersonTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPersonTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPersonTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPriceLineStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceLineStatusId)
                    .HasName("PK_StockPriceLineStatusID");

                entity.Property(e => e.StockPriceLineStatusId)
                    .HasColumnName("StockPriceLineStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPriceLineStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPriceLineStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPriceLineStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPriceLineTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceLineId);

                entity.Property(e => e.StockPriceLineId)
                    .HasColumnName("StockPriceLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellCreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockCompanyItemKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockCompanyItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockCompanyItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockPriceId).HasColumnName("StockPriceID");

                entity.Property(e => e.StockPriceLineKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockPriceLineName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockPriceLineSortId).HasColumnName("StockPriceLineSortID");

                entity.Property(e => e.StockPriceLineSortId2).HasColumnName("StockPriceLineSortID2");

                entity.Property(e => e.StockPriceLineStatusId).HasColumnName("StockPriceLineStatusID");

                entity.Property(e => e.StockPriceLineTypeId).HasColumnName("StockPriceLineTypeID");

                entity.Property(e => e.StockPriceLineValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.StockPriceLineValidTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('9999-12-31 23:59:59')");

                entity.Property(e => e.StockPriceQuantityFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockPriceTaxId).HasColumnName("StockPriceTaxID");

                entity.Property(e => e.StockSalesItemGroupId).HasColumnName("StockSalesItemGroupID");

                entity.HasOne(d => d.StockEntry)
                    .WithMany(p => p.StockPriceLineTable)
                    .HasForeignKey(d => d.StockEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPriceLineTable_StockEntryTable");

                entity.HasOne(d => d.StockPriceNavigation)
                    .WithMany(p => p.StockPriceLineTable)
                    .HasForeignKey(d => d.StockPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPriceLineTable_StockPriceTable");
            });

            modelBuilder.Entity<StockPriceLineTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceLineTypeId)
                    .HasName("PK_StockPriceLineTypeID");

                entity.Property(e => e.StockPriceLineTypeId)
                    .HasColumnName("StockPriceLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPriceLineTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPriceLineTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPriceLineTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPriceStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceStatusId)
                    .HasName("PK_StockPriceStatusID");

                entity.Property(e => e.StockPriceStatusId)
                    .HasColumnName("StockPriceStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPriceStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPriceStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPriceStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockPriceTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceId)
                    .HasName("PK_StockPriceID");

                entity.HasIndex(e => e.StockPriceKey)
                    .HasName("IX_StockPriceKey")
                    .IsUnique();

                entity.Property(e => e.StockPriceId).HasColumnName("StockPriceID");

                entity.Property(e => e.StockPriceKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPriceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPriceNote).HasColumnType("ntext");

                entity.Property(e => e.StockPriceStatusId).HasColumnName("StockPriceStatusID");

                entity.Property(e => e.StockPriceTypeId)
                    .HasColumnName("StockPriceTypeID")
                    .HasDefaultValueSql("((3))");

                entity.HasOne(d => d.StockPriceStatus)
                    .WithMany(p => p.StockPriceTable)
                    .HasForeignKey(d => d.StockPriceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPrice<-StockPriceStatus");

                entity.HasOne(d => d.StockPriceType)
                    .WithMany(p => p.StockPriceTable)
                    .HasForeignKey(d => d.StockPriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockPrice<-StockPriceType");
            });

            modelBuilder.Entity<StockPriceTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockPriceTypeId)
                    .HasName("PK_StockPriceTypeID");

                entity.Property(e => e.StockPriceTypeId)
                    .HasColumnName("StockPriceTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockPriceTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockPriceTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockPriceTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockRecipeStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockRecipeStatusId)
                    .HasName("PK_StockRecipeStatusID");

                entity.Property(e => e.StockRecipeStatusId)
                    .HasColumnName("StockRecipeStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockRecipeStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRecipeStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockRecipeStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockRecipeTable>(entity =>
            {
                entity.HasKey(e => e.StockRecipeId)
                    .HasName("PK_StockRecipeID");

                entity.HasIndex(e => new { e.StockRecipeStatusId, e.StockItemId })
                    .HasName("StockRecipeIndex1");

                entity.HasIndex(e => new { e.StockRecipeTypeId, e.StockItemId, e.StockRecipeQuantity, e.StockRecipeItemId, e.StockRecipeValidFrom, e.StockRecipeValidTo, e.StockRecipeStatusId })
                    .HasName("StockRecipeIndex");

                entity.Property(e => e.StockRecipeId)
                    .HasColumnName("StockRecipeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockRecipeItemId).HasColumnName("StockRecipeItemID");

                entity.Property(e => e.StockRecipeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockRecipeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockRecipeNote).HasColumnType("ntext");

                entity.Property(e => e.StockRecipeSortId).HasColumnName("StockRecipeSortID");

                entity.Property(e => e.StockRecipeStatusId).HasColumnName("StockRecipeStatusID");

                entity.Property(e => e.StockRecipeTypeId).HasColumnName("StockRecipeTypeID");

                entity.Property(e => e.StockRecipeValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.StockRecipeValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.StockRecipeStatus)
                    .WithMany(p => p.StockRecipeTable)
                    .HasForeignKey(d => d.StockRecipeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockRecipe<-StockRecipeStatus");
            });

            modelBuilder.Entity<StockRecipeTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockRecipeTypeId)
                    .HasName("PK_StockRecipeTypeID");

                entity.Property(e => e.StockRecipeTypeId)
                    .HasColumnName("StockRecipeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockRecipeTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRecipeTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockRecipeTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockSalesItemGroupNameTable>(entity =>
            {
                entity.HasKey(e => new { e.StockCustomerId, e.StockSalesItemGroupId });

                entity.Property(e => e.StockCustomerId).HasColumnName("StockCustomerID");

                entity.Property(e => e.StockSalesItemGroupId).HasColumnName("StockSalesItemGroupID");

                entity.Property(e => e.StockItemGroupDiscountId).HasColumnName("StockItemGroupDiscountID");

                entity.Property(e => e.StockSalesItemGroupName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockSalesItemGroupNameId)
                    .HasColumnName("StockSalesItemGroupNameID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockSalesItemGroupNameStatusId).HasColumnName("StockSalesItemGroupNameStatusID");

                entity.HasOne(d => d.StockCustomer)
                    .WithMany(p => p.StockSalesItemGroupNameTable)
                    .HasForeignKey(d => d.StockCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockSalesItemGroupNameTable_StockCompanyTable");

                entity.HasOne(d => d.StockSalesItemGroup)
                    .WithMany(p => p.StockSalesItemGroupNameTable)
                    .HasForeignKey(d => d.StockSalesItemGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockSalesItemGroupNameTable_StockSalesItemGroupTable");
            });

            modelBuilder.Entity<StockSalesItemGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockSalesItemGroupId)
                    .HasName("PK_StockSalesItemGroupID");

                entity.Property(e => e.StockSalesItemGroupId)
                    .HasColumnName("StockSalesItemGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockSalesItemGroupKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockSalesItemGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockSalesItemGroupNote).HasColumnType("ntext");

                entity.Property(e => e.StockSalesItemGroupParentId).HasColumnName("StockSalesItemGroupParentID");

                entity.HasOne(d => d.StockSalesItemGroupParent)
                    .WithMany(p => p.InverseStockSalesItemGroupParent)
                    .HasForeignKey(d => d.StockSalesItemGroupParentId)
                    .HasConstraintName("FK_StockSalesItemGroup<-StockSalesItemGroupParent");
            });

            modelBuilder.Entity<StockSalesUserGroupTable>(entity =>
            {
                entity.HasKey(e => e.StockSalesUserGroupId)
                    .HasName("PK_POSUserGroupTable");

                entity.Property(e => e.StockSalesUserGroupId)
                    .HasColumnName("StockSalesUserGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosflagCash).HasColumnName("POSFlag_Cash");

                entity.Property(e => e.PosflagCashIn).HasColumnName("POSFlag_CashIn");

                entity.Property(e => e.PosflagCashOut).HasColumnName("POSFlag_CashOut");

                entity.Property(e => e.PosflagCashX).HasColumnName("POSFlag_CashX");

                entity.Property(e => e.PosflagCashZ).HasColumnName("POSFlag_CashZ");

                entity.Property(e => e.PosflagSales).HasColumnName("POSFlag_Sales");

                entity.Property(e => e.PosflagSalesCustomerChange).HasColumnName("POSFlag_SalesCustomerChange");

                entity.Property(e => e.PosflagSalesQuantityChange).HasColumnName("POSFlag_SalesQuantityChange");

                entity.Property(e => e.PosflagSalesReturn).HasColumnName("POSFlag_SalesReturn");

                entity.Property(e => e.PosflagSalesTaxMethodChange).HasColumnName("POSFlag_SalesTaxMethodChange");

                entity.Property(e => e.PosflagSync).HasColumnName("POSFlag_Sync");

                entity.Property(e => e.StockSalesUserGroupKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockSalesUserGroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StockScaleTable>(entity =>
            {
                entity.HasKey(e => e.StockScaleId)
                    .HasName("PK_StockScaleID");

                entity.Property(e => e.StockScaleId)
                    .HasColumnName("StockScaleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockScaleKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockScaleName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockScaleNote).HasColumnType("ntext");

                entity.Property(e => e.StockScaleStatusId).HasColumnName("StockScaleStatusID");

                entity.Property(e => e.StockScaleTypeId).HasColumnName("StockScaleTypeID");
            });

            modelBuilder.Entity<StockSupplierStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockSupplierStatusId)
                    .HasName("PK_StockSupplierStatusID");

                entity.Property(e => e.StockSupplierStatusId)
                    .HasColumnName("StockSupplierStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockSupplierStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockSupplierStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockSupplierStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockSupplierTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockSupplierTypeId)
                    .HasName("PK_StockSupplierTypeID");

                entity.Property(e => e.StockSupplierTypeId)
                    .HasColumnName("StockSupplierTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockSupplierTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockSupplierTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockSupplierTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockTaxMethodTable>(entity =>
            {
                entity.HasKey(e => e.StockTaxMethodId);

                entity.Property(e => e.StockTaxMethodId)
                    .HasColumnName("StockTaxMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockTaxMethodKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockTaxMethodName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockTaxMethodNote).HasColumnType("ntext");

                entity.Property(e => e.StockTaxMethodStatusId).HasColumnName("StockTaxMethodStatusID");
            });

            modelBuilder.Entity<StockTaxStatusTable>(entity =>
            {
                entity.HasKey(e => e.StockTaxStatusId)
                    .HasName("PK_StockTaxStatusID");

                entity.HasIndex(e => e.StockTaxStatusId)
                    .HasName("IX_StockTaxStatusKey")
                    .IsUnique();

                entity.Property(e => e.StockTaxStatusId)
                    .HasColumnName("StockTaxStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockTaxStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockTaxStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockTaxStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockTaxTable>(entity =>
            {
                entity.HasKey(e => e.StockTaxId)
                    .HasName("PK_StockTaxID");

                entity.HasIndex(e => e.StockTaxKey)
                    .HasName("IX_StockTaxKey")
                    .IsUnique();

                entity.Property(e => e.StockTaxId)
                    .HasColumnName("StockTaxID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockTaxBaseFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockTaxKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockTaxName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockTaxNote).HasColumnType("ntext");

                entity.Property(e => e.StockTaxStatusId).HasColumnName("StockTaxStatusID");

                entity.Property(e => e.StockTaxTypeId).HasColumnName("StockTaxTypeID");

                entity.HasOne(d => d.StockTaxStatus)
                    .WithMany(p => p.StockTaxTable)
                    .HasForeignKey(d => d.StockTaxStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTaxTable_StockTaxStatusTable");

                entity.HasOne(d => d.StockTaxType)
                    .WithMany(p => p.StockTaxTable)
                    .HasForeignKey(d => d.StockTaxTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTaxTable_StockTaxTypeTable");
            });

            modelBuilder.Entity<StockTaxTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockTaxTypeId)
                    .HasName("PK_StockTaxTypeID");

                entity.HasIndex(e => e.StockTaxTypeKey)
                    .HasName("IX_StockTaxTypeKey")
                    .IsUnique();

                entity.Property(e => e.StockTaxTypeId)
                    .HasColumnName("StockTaxTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockTaxTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockTaxTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockTaxTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockUsageTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockUsageTypeId);

                entity.Property(e => e.StockUsageTypeId)
                    .HasColumnName("StockUsageTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockUsageTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockUsageTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockUsageTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<StockValuationTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.StockItemId, e.StockLocationId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");
            });

            modelBuilder.Entity<StockWork2110Table>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDateInitial)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWork2120Table>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellCreateUserId).HasColumnName("ShellCreateUserID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDateInitial)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTime)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransLocationShelfId).HasColumnName("TransLocationShelfID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransServiceId).HasColumnName("TransServiceID");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWork2130Table>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDateInitial)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransQuantityFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWork2140Table>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDateInitial)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWork21xZtable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.ToTable("StockWork21xZTable");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDateInitial).HasColumnType("datetime");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyCardId).HasColumnName("TransCompanyCardID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId)
                    .HasColumnName("TransPayPeriodID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWorkBudgetTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId })
                    .HasName("PK_StockWorkBudgetTable_1");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.StockBudgetTypeId).HasColumnName("StockBudgetTypeID");

                entity.Property(e => e.StockCompanyGroupId).HasColumnName("StockCompanyGroupID");

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockDeliveryGraphId).HasColumnName("StockDeliveryGraphID");

                entity.Property(e => e.StockDeliveryTypeId).HasColumnName("StockDeliveryTypeID");

                entity.Property(e => e.StockEntryDate).HasColumnType("datetime");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineId2).HasColumnName("StockEntryLineID2");

                entity.Property(e => e.StockEntryLineTypeId).HasColumnName("StockEntryLineTypeID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemGroupId).HasColumnName("StockItemGroupID");

                entity.Property(e => e.StockItemGroupId2).HasColumnName("StockItemGroupID2");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationGroupId).HasColumnName("StockLocationGroupID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockQlimitFactor)
                    .HasColumnName("StockQLimitFactor")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StockUsageTypeId).HasColumnName("StockUsageTypeID");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.TransTaxBaseFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxId).HasColumnName("TransTaxID");
            });

            modelBuilder.Entity<StockWorkLiveTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId })
                    .HasName("PK_StockWorkLiveTable_1");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Fcprice).HasColumnName("FCPrice");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.StockBomplanLineTypeId).HasColumnName("StockBOMPlanLineTypeID");

                entity.Property(e => e.StockCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.StockCarId).HasColumnName("StockCarID");

                entity.Property(e => e.StockCompanyCardId).HasColumnName("StockCompanyCardID");

                entity.Property(e => e.StockCompanyGroupId).HasColumnName("StockCompanyGroupID");

                entity.Property(e => e.StockCompanyId).HasColumnName("StockCompanyID");

                entity.Property(e => e.StockCompanyParentId).HasColumnName("StockCompanyParentID");

                entity.Property(e => e.StockCostCodeId).HasColumnName("StockCostCodeID");

                entity.Property(e => e.StockEntryDate).HasColumnType("datetime");

                entity.Property(e => e.StockEntryDate2).HasColumnType("datetime");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryId2).HasColumnName("StockEntryID2");

                entity.Property(e => e.StockEntryKey).HasMaxLength(50);

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryLineSortId).HasColumnName("StockEntryLineSortID");

                entity.Property(e => e.StockEntryLineTypeId).HasColumnName("StockEntryLineTypeID");

                entity.Property(e => e.StockEntryName).HasMaxLength(200);

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryProcessId).HasColumnName("StockEntryProcessID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemGroupId).HasColumnName("StockItemGroupID");

                entity.Property(e => e.StockItemGweight).HasColumnName("StockItemGWeight");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemId2).HasColumnName("StockItemID2");

                entity.Property(e => e.StockItemId3).HasColumnName("StockItemID3");

                entity.Property(e => e.StockItemNweight).HasColumnName("StockItemNWeight");

                entity.Property(e => e.StockLocationGroupId).HasColumnName("StockLocationGroupID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockPayPeriodId).HasColumnName("StockPayPeriodID");

                entity.Property(e => e.StockPersonId).HasColumnName("StockPersonID");

                entity.Property(e => e.StockPriceId).HasColumnName("StockPriceID");

                entity.Property(e => e.StockRecipeItemId).HasColumnName("StockRecipeItemID");

                entity.Property(e => e.StockSalesPriceGroupId).HasColumnName("StockSalesPriceGroupID");

                entity.Property(e => e.StockSalesUserId).HasColumnName("StockSalesUserID");

                entity.Property(e => e.StockShelfId).HasColumnName("StockShelfID");

                entity.Property(e => e.StockUserId).HasColumnName("StockUserID");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.TaxCodeId1).HasColumnName("TaxCodeID1");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");
            });

            modelBuilder.Entity<StockWorkTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.RswaybillId).HasColumnName("RSWaybillID");

                entity.Property(e => e.RswaybillKey)
                    .IsRequired()
                    .HasColumnName("RSWaybillKey")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.RswaybillTypeId).HasColumnName("RSWaybillTypeID");

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellCustomerId).HasColumnName("ShellCustomerID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShellModifierUserId).HasColumnName("ShellModifierUserID");

                entity.Property(e => e.ShellWorkPageLineParentId)
                    .HasColumnName("ShellWorkPageLineParentID")
                    .HasMaxLength(10);

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockAllocationBaseId).HasColumnName("StockAllocationBaseID");

                entity.Property(e => e.StockBomplanLineStatusId).HasColumnName("StockBOMPlanLineStatusID");

                entity.Property(e => e.StockBomplanLineTypeId).HasColumnName("StockBOMPlanLineTypeID");

                entity.Property(e => e.StockCarId).HasColumnName("StockCarID");

                entity.Property(e => e.StockDeliveryGraphId).HasColumnName("StockDeliveryGraphID");

                entity.Property(e => e.StockDeliveryId).HasColumnName("StockDeliveryID");

                entity.Property(e => e.StockDeliveryTypeId).HasColumnName("StockDeliveryTypeID");

                entity.Property(e => e.StockEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryDate2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryId2).HasColumnName("StockEntryID2");

                entity.Property(e => e.StockEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntrySortId).HasColumnName("StockEntrySortID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemGroupId).HasColumnName("StockItemGroupID");

                entity.Property(e => e.StockItemGroupId2).HasColumnName("StockItemGroupID2");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemId2).HasColumnName("StockItemID2");

                entity.Property(e => e.StockItemKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StockItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.StockLocationId2).HasColumnName("StockLocationID2");

                entity.Property(e => e.StockPersonId).HasColumnName("StockPersonID");

                entity.Property(e => e.StockQlimitFactor).HasColumnName("StockQLimitFactor");

                entity.Property(e => e.StockRptypeId).HasColumnName("StockRPTypeID");

                entity.Property(e => e.StockUsageTypeId).HasColumnName("StockUsageTypeID");

                entity.Property(e => e.TextCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextCompanyKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockCarKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockCarName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockPersonKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TextStockPersonName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransCompanyGroupId).HasColumnName("TransCompanyGroupID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransDiscountId).HasColumnName("TransDiscountID");

                entity.Property(e => e.TransItemBomid).HasColumnName("TransItemBOMID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.TransItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitFactor2).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.TransPriceTaxId).HasColumnName("TransPriceTaxID");

                entity.Property(e => e.TransQuantityAllowChange).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransQuantityFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<StockWorkValuationTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId });

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.ShellDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate).HasColumnType("datetime");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey).HasMaxLength(50);

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryLineSortId).HasColumnName("StockEntryLineSortID");

                entity.Property(e => e.StockEntryLineTypeId).HasColumnName("StockEntryLineTypeID");

                entity.Property(e => e.StockEntryName).HasMaxLength(200);

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TaxCodeId)
                    .HasColumnName("TaxCodeID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SyncEntryStatusTable>(entity =>
            {
                entity.HasKey(e => e.SyncEntryStatusId)
                    .HasName("PK_SyncEntryStatusID");

                entity.Property(e => e.SyncEntryStatusId)
                    .HasColumnName("SyncEntryStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyncEntryStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncEntryStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SyncEntryTable>(entity =>
            {
                entity.HasKey(e => e.SyncEntryId);

                entity.Property(e => e.SyncEntryId)
                    .HasColumnName("SyncEntryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyncEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SyncEntryKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SyncEntryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.SyncEntryStatusId).HasColumnName("SyncEntryStatusID");

                entity.Property(e => e.SyncEntryTypeId).HasColumnName("SyncEntryTypeID");

                entity.Property(e => e.SyncEntryValue)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.HasOne(d => d.SyncEntryStatus)
                    .WithMany(p => p.SyncEntryTable)
                    .HasForeignKey(d => d.SyncEntryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SyncEntryTable_SyncEntryStatusTable");

                entity.HasOne(d => d.SyncEntryType)
                    .WithMany(p => p.SyncEntryTable)
                    .HasForeignKey(d => d.SyncEntryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SyncEntryTable_SyncEntryTypeTable");
            });

            modelBuilder.Entity<SyncEntryTypeTable>(entity =>
            {
                entity.HasKey(e => e.SyncEntryTypeId)
                    .HasName("PK_SyncEntryTypeID");

                entity.Property(e => e.SyncEntryTypeId)
                    .HasColumnName("SyncEntryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyncEntryTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncEntryTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ZGlaccountTable>(entity =>
            {
                entity.HasKey(e => e.GlaccountId)
                    .HasName("PK_GLAccountTable");

                entity.ToTable("zGLAccountTable");

                entity.Property(e => e.GlaccountId)
                    .HasColumnName("GLAccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExactGlaccount)
                    .HasColumnName("ExactGLAccount")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountGroupId).HasColumnName("GLAccountGroupID");

                entity.Property(e => e.GlaccountKey)
                    .IsRequired()
                    .HasColumnName("GLAccountKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountName)
                    .IsRequired()
                    .HasColumnName("GLAccountName")
                    .HasMaxLength(200);

                entity.Property(e => e.GlaccountNote)
                    .HasColumnName("GLAccountNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.GlaccountStatusId).HasColumnName("GLAccountStatusID");

                entity.Property(e => e.GlaccountTypeId).HasColumnName("GLAccountTypeID");
            });

            modelBuilder.Entity<ZGlaccountTable11>(entity =>
            {
                entity.HasKey(e => e.GlaccountId)
                    .HasName("PK_GLAccountTable1");

                entity.ToTable("zGLAccountTable11");

                entity.Property(e => e.GlaccountId)
                    .HasColumnName("GLAccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExactGlaccount)
                    .HasColumnName("ExactGLAccount")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountGroupId).HasColumnName("GLAccountGroupID");

                entity.Property(e => e.GlaccountKey)
                    .IsRequired()
                    .HasColumnName("GLAccountKey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountName)
                    .IsRequired()
                    .HasColumnName("GLAccountName")
                    .HasMaxLength(200);

                entity.Property(e => e.GlaccountNote)
                    .HasColumnName("GLAccountNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.GlaccountStatusId).HasColumnName("GLAccountStatusID");

                entity.Property(e => e.GlaccountTypeId).HasColumnName("GLAccountTypeID");
            });

            modelBuilder.Entity<ZPosworkTable>(entity =>
            {
                entity.HasKey(e => new { e.ShellUserId, e.ShellOperationId, e.ShellWorkPageId, e.ShellWorkPageLineId })
                    .HasName("PK_POSWorkTable");

                entity.ToTable("zPOSWorkTable");

                entity.Property(e => e.ShellUserId).HasColumnName("ShellUserID");

                entity.Property(e => e.ShellOperationId).HasColumnName("ShellOperationID");

                entity.Property(e => e.ShellWorkPageId).HasColumnName("ShellWorkPageID");

                entity.Property(e => e.ShellWorkPageLineId).HasColumnName("ShellWorkPageLineID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ShellComputerId).HasColumnName("ShellComputerID");

                entity.Property(e => e.ShellCreationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellCreatorUserId).HasColumnName("ShellCreatorUserID");

                entity.Property(e => e.ShellMessageId).HasColumnName("ShellMessageID");

                entity.Property(e => e.ShellModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ShellModifierUserId).HasColumnName("ShellModifierUserID");

                entity.Property(e => e.ShellWorkPageLineParentId).HasColumnName("ShellWorkPageLineParentID");

                entity.Property(e => e.ShellWorkPageParentId).HasColumnName("ShellWorkPageParentID");

                entity.Property(e => e.ShellWorkStatusId).HasColumnName("ShellWorkStatusID");

                entity.Property(e => e.StockEntryDate).HasColumnType("datetime");

                entity.Property(e => e.StockEntryDateInitial).HasColumnType("datetime");

                entity.Property(e => e.StockEntryId).HasColumnName("StockEntryID");

                entity.Property(e => e.StockEntryKey).HasMaxLength(50);

                entity.Property(e => e.StockEntryLineId).HasColumnName("StockEntryLineID");

                entity.Property(e => e.StockEntryLineParentId).HasColumnName("StockEntryLineParentID");

                entity.Property(e => e.StockEntryName).HasMaxLength(200);

                entity.Property(e => e.StockEntryParentId).HasColumnName("StockEntryParentID");

                entity.Property(e => e.StockEntryStatusId).HasColumnName("StockEntryStatusID");

                entity.Property(e => e.StockEntryTypeId).HasColumnName("StockEntryTypeID");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.StockItemUnitId).HasColumnName("StockItemUnitID");

                entity.Property(e => e.StockLocationId).HasColumnName("StockLocationID");

                entity.Property(e => e.TransCompanyId).HasColumnName("TransCompanyID");

                entity.Property(e => e.TransCurrencyFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransCurrencyId).HasColumnName("TransCurrencyID");

                entity.Property(e => e.TransItemId).HasColumnName("TransItemID");

                entity.Property(e => e.TransItemUnitFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransItemUnitId).HasColumnName("TransItemUnitID");

                entity.Property(e => e.TransPayDiscountId).HasColumnName("TransPayDiscountID");

                entity.Property(e => e.TransPayMethodId).HasColumnName("TransPayMethodID");

                entity.Property(e => e.TransPayPeriodId).HasColumnName("TransPayPeriodID");

                entity.Property(e => e.TransTaxBaseFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxId).HasColumnName("TransTaxID");

                entity.Property(e => e.TransTaxMethodFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTaxMethodId).HasColumnName("TransTaxMethodID");
            });

            modelBuilder.Entity<ZShellSyncStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncStatusId)
                    .HasName("PK_ShellSyncStatusTable");

                entity.ToTable("zShellSyncStatusTable");

                entity.Property(e => e.ShellSyncStatusId)
                    .HasColumnName("ShellSyncStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ZShellSyncTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncId)
                    .HasName("PK_ShellSyncID");

                entity.ToTable("zShellSyncTable");

                entity.HasIndex(e => e.ShellSyncKey)
                    .HasName("IX_ShellSyncKey")
                    .IsUnique();

                entity.Property(e => e.ShellSyncId)
                    .HasColumnName("ShellSyncID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncDataId)
                    .IsRequired()
                    .HasColumnName("ShellSyncDataID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncDataStatusId)
                    .IsRequired()
                    .HasColumnName("ShellSyncDataStatusID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellSyncDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellSyncKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncLicenseFrom)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ShellSyncLicenseKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncLicenseTo)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ShellSyncName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncNote).HasColumnType("ntext");

                entity.Property(e => e.ShellSyncProcessId)
                    .HasColumnName("ShellSyncProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.ShellSyncStatusId).HasColumnName("ShellSyncStatusID");

                entity.Property(e => e.ShellSyncTableFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTableTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTypeId).HasColumnName("ShellSyncTypeID");
            });

            modelBuilder.Entity<ZShellSyncTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncTypeId)
                    .HasName("PK_ShellSyncTypeTable");

                entity.ToTable("zShellSyncTypeTable");

                entity.Property(e => e.ShellSyncTypeId)
                    .HasColumnName("ShellSyncTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ZStockEntryProcessTable>(entity =>
            {
                entity.HasKey(e => e.StockEntryProcessId)
                    .HasName("PK_StockEntryProcessID");

                entity.ToTable("zStockEntryProcessTable");

                entity.Property(e => e.StockEntryProcessId)
                    .HasColumnName("StockEntryProcessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntryProcessKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntryProcessName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockEntryProcesssNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ZStockEntrySubTypeTable>(entity =>
            {
                entity.HasKey(e => e.StockEntrySubTypeId)
                    .HasName("PK_StockEntrySubTypeID");

                entity.ToTable("zStockEntrySubTypeTable");

                entity.Property(e => e.StockEntrySubTypeId)
                    .HasColumnName("StockEntrySubTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StockEntrySubTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockEntrySubTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StockEntrySubTypeNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ZzShellSyncStatusTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncStatusId)
                    .HasName("PK_ShellSyncStatusTable1");

                entity.ToTable("zzShellSyncStatusTable");

                entity.Property(e => e.ShellSyncStatusId)
                    .HasColumnName("ShellSyncStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncStatusKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncStatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncStatusNote).HasColumnType("ntext");
            });

            modelBuilder.Entity<ZzShellSyncTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncId)
                    .HasName("PK_ShellSyncTable");

                entity.ToTable("zzShellSyncTable");

                entity.Property(e => e.ShellSyncId)
                    .HasColumnName("ShellSyncID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncComputerKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncDataId)
                    .IsRequired()
                    .HasColumnName("ShellSyncDataID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncDataStatusId)
                    .IsRequired()
                    .HasColumnName("ShellSyncDataStatusID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ShellSyncDateTo).HasColumnType("datetime");

                entity.Property(e => e.ShellSyncKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncLicenseFrom)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ShellSyncLicenseKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncLicenseTo)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ShellSyncName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncNote).HasColumnType("ntext");

                entity.Property(e => e.ShellSyncProcessId)
                    .HasColumnName("ShellSyncProcessID")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.ShellSyncStatusId).HasColumnName("ShellSyncStatusID");

                entity.Property(e => e.ShellSyncTableFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTableTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTypeId).HasColumnName("ShellSyncTypeID");
            });

            modelBuilder.Entity<ZzShellSyncTypeTable>(entity =>
            {
                entity.HasKey(e => e.ShellSyncTypeId)
                    .HasName("PK_ShellSyncTypeTable1");

                entity.ToTable("zzShellSyncTypeTable");

                entity.Property(e => e.ShellSyncTypeId)
                    .HasColumnName("ShellSyncTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShellSyncTypeKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShellSyncTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShellSyncTypeNote).HasColumnType("ntext");
            });
        }
    }
}
