
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Matter 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Matter()
        {
				this.InvMasters = new HashSet<InvMaster>();
				this.MattBudgets = new HashSet<MattBudget>();

        }
 
			[ForeignKey("ClientEntitySet")]
            public System.Int32 Client { get; set; } 
			[ForeignKey("NxCurrencyCodeEntitySet")]
            public System.String Currency { get; set; } 
			[ForeignKey("CurrencyDateListEntitySet")]
            public System.String CurrencyDateList { get; set; } 
			[ForeignKey("LanguageEntitySet")]
            public System.Int32 Language { get; set; } 
			[ForeignKey("LxLabelEntitySet")]
            public System.Int32 LxLabel { get; set; } 
			[ForeignKey("MattStatusEntitySet")]
            public System.String MattStatus { get; set; } 

            public BankAcct BankAcctEntitySet { get; set; } 

            public BillingFrequency BillingFrequencyEntitySet { get; set; } 

            public Client ClientEntitySet { get; set; } 

            public ConflictStatus ConflictStatusEntitySet { get; set; } 

            public CurrencyDateList CurrencyDateListEntitySet { get; set; } 

            public EBHArrangement EBHArrangementEntitySet { get; set; } 

            public EBHClientList EBHClientListEntitySet { get; set; } 

            public EBillValList EBillValListEntitySet { get; set; } 

            public ElecBillingType ElecBillingTypeEntitySet { get; set; } 

            public ElecCostTypeMap ElecCostTypeMapEntitySet { get; set; } 

            public ElecTitleMap ElecTitleMapEntitySet { get; set; } 

            public ElectronicTaxCodeMap ElectronicTaxCodeMapEntitySet { get; set; } 

            public Entity EntityEntitySet { get; set; } 

            public GLActivity GLActivityEntitySet { get; set; } 

            public GLProject GLProjectEntitySet { get; set; } 

            public InvoiceOverride InvoiceOverrideEntitySet { get; set; } 

            public Language LanguageEntitySet { get; set; } 

            public LxLabel LxLabelEntitySet { get; set; } 

            public Markup MarkupEntitySet { get; set; } 

            public MattAttribute MattAttributeEntitySet { get; set; } 

            public MattCategory MattCategoryEntitySet { get; set; } 

            public MattCloseType MattCloseTypeEntitySet { get; set; } 

            public MattInterest MattInterestEntitySet { get; set; } 

            public MattMinType MattMinTypeEntitySet { get; set; } 

            public MattStatus MattStatusEntitySet { get; set; } 

            public MattType MattTypeEntitySet { get; set; } 

            public NonBillMatType NonBillMatTypeEntitySet { get; set; } 

            public NxCurrencyCode NxCurrencyCodeEntitySet { get; set; } 

            public NxFWKUnit NxFWKUnitEntitySet { get; set; } 

            public NxPrinterTemplate NxPrinterTemplateEntitySet { get; set; } 

            public Office OfficeEntitySet { get; set; } 

            public Site SiteEntitySet { get; set; } 

            public TaxArea TaxAreaEntitySet { get; set; } 

            public TaxCode TaxCodeEntitySet { get; set; } 

            public TimeIncrement TimeIncrementEntitySet { get; set; } 

            public Timekeeper TimekeeperEntitySet { get; set; } 

            public VolumeDiscountGroup VolumeDiscountGroupEntitySet { get; set; } 

            public WithholdingTax WithholdingTaxEntitySet { get; set; } 

            public WPType WPTypeEntitySet { get; set; } 
			[Key]
            public System.Int32 MattIndex { get; set; } 

            public System.String AdminAccount { get; set; } 

            public System.String AdminInfo { get; set; } 

            public System.String AltNumber { get; set; } 

            public Nullable<System.DateTime> ApproveDate { get; set; } 
			[ForeignKey("TimekeeperEntitySet")]
            public Nullable<System.Int32> ApproveTkpr { get; set; } 

            public System.String ArchetypeCode { get; set; } 
			[ForeignKey("BankAcctEntitySet")]
            public Nullable<System.Int32> BankAcctAp { get; set; } 
			[ForeignKey("NxPrinterTemplateEntitySet")]
            public Nullable<System.Guid> BillDCSTemplate { get; set; } 

            public System.String BillEmail { get; set; } 
			[ForeignKey("BillingFrequencyEntitySet")]
            public System.String BillingFrequency { get; set; } 

            public System.String BillingInstruc { get; set; } 
			[ForeignKey("OfficeEntitySet")]
            public System.String BillingOffice { get; set; } 
			[ForeignKey("SiteEntitySet")]
            public Nullable<System.Int32> BillSite { get; set; } 
			[ForeignKey("TaxCodeEntitySet")]
            public System.String ChrgTaxCode { get; set; } 

            public Nullable<System.DateTime> CloseDate { get; set; } 

            public System.String Comments { get; set; } 
			[ForeignKey("ConflictStatusEntitySet")]
            public System.String ConflictStatus { get; set; } 

            public System.String ContactInfo { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String DisplayName { get; set; } 

            public Nullable<System.Int32> DueDays { get; set; } 
			[ForeignKey("EBHArrangementEntitySet")]
            public System.String EBHArrangement { get; set; } 
			[ForeignKey("EBHClientListEntitySet")]
            public Nullable<System.Int32> eBHClientList { get; set; } 
			[ForeignKey("EBillValListEntitySet")]
            public System.String EbillValidationList { get; set; } 
			[ForeignKey("ElecBillingTypeEntitySet")]
            public System.String ElecBillingType { get; set; } 
			[ForeignKey("ElecCostTypeMapEntitySet")]
            public System.String ElecCostTypeMap { get; set; } 

            public System.String ElecInfo { get; set; } 

            public System.String ElecNumber { get; set; } 
			[ForeignKey("ElectronicTaxCodeMapEntitySet")]
            public System.String ElecTaxCodeMap { get; set; } 
			[ForeignKey("ElecTitleMapEntitySet")]
            public System.String ElecTitleMap { get; set; } 

            public System.String EngageLetterComment { get; set; } 

            public Nullable<System.DateTime> EngageLetterRecDate { get; set; } 

            public Nullable<System.DateTime> EngageLetterSubDate { get; set; } 

            public Nullable<System.DateTime> EntryDate { get; set; } 

            public Nullable<System.DateTime> EstimatedCompletionDate { get; set; } 

            public Nullable<System.Decimal> FeeEstimateAmount { get; set; } 

            public System.String Field1 { get; set; } 

            public System.String Field2 { get; set; } 

            public System.String Field3 { get; set; } 
			[ForeignKey("GLActivityEntitySet")]
            public Nullable<System.Guid> GLActivity { get; set; } 
			[ForeignKey("GLProjectEntitySet")]
            public System.String GLProject { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 
			[ForeignKey("NxFWKUnitEntitySet")]
            public System.String ICBUnitDueFrom { get; set; } 
			[InverseProperty(  "LinkInvMasterAndMatter"), 
            System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public ICollection<InvMaster> InvMasters { get; set; } 
			[ForeignKey("InvoiceOverrideEntitySet")]
            public System.String InvoiceOverride { get; set; } 

            public byte IsAdmin { get; set; } 

            public byte IsAllowTrustOverdraw { get; set; } 

            public byte IsBillStatementIncludeDoubtful { get; set; } 

            public Nullable<byte> IsConflictsConfidential { get; set; } 

            public Nullable<byte> IsDefault { get; set; } 

            public byte IsEBill { get; set; } 

            public byte IsEngageLetterReq { get; set; } 

            public byte IsExportRestricted { get; set; } 

            public byte IsFeeEstimate { get; set; } 

            public Nullable<byte> IsForeign { get; set; } 

            public byte IsICBAcctRec { get; set; } 

            public byte IsICBPayable { get; set; } 

            public byte IsLeadVolumeDiscountMatter { get; set; } 

            public byte IsMaster { get; set; } 

            public byte IsNoBill { get; set; } 

            public Nullable<byte> IsNonBillable { get; set; } 

            public byte IsNoProforma { get; set; } 

            public byte IsOnlyABATimeTypes { get; set; } 

            public byte IsProBono { get; set; } 

            public byte IsWaiverLetterReq { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 
			[ForeignKey("MarkupEntitySet")]
            public System.String Markup { get; set; } 
			[ForeignKey("MattAttributeEntitySet")]
            public System.String MattAttribute { get; set; } 
			[InverseProperty(  "LinkMattBudgetAndMatter"), 
            System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public ICollection<MattBudget> MattBudgets { get; set; } 
			[ForeignKey("MattCategoryEntitySet")]
            public System.String MattCategory { get; set; } 
			[ForeignKey("MattCloseTypeEntitySet")]
            public System.String MattCloseType { get; set; } 

            public System.Guid MatterID { get; set; } 

            public System.String MattInfo { get; set; } 
			[ForeignKey("MattInterestEntitySet")]
            public System.String MattInterest { get; set; } 
			[ForeignKey("MattMinTypeEntitySet")]
            public System.String MattMinType { get; set; } 

            public Nullable<System.DateTime> MattStatusDate { get; set; } 
			[ForeignKey("MattTypeEntitySet")]
            public System.String MattType { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 
			[ForeignKey("NonBillMatTypeEntitySet")]
            public System.String NonBillType { get; set; } 

            public System.String Number { get; set; } 

            public System.DateTime OpenDate { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String PaymentTermsInfo { get; set; } 
			[ForeignKey("EntityEntitySet")]
            public Nullable<System.Int32> ProBonoEntity { get; set; } 

            public System.String ProBonoInfo { get; set; } 

            public System.String ProformaEmail { get; set; } 

            public System.String ReferralInfo { get; set; } 

            public System.String TaxReportID1 { get; set; } 

            public System.String TaxReportID2 { get; set; } 
			[ForeignKey("TimeIncrementEntitySet")]
            public System.String TimeIncrement { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 
			[ForeignKey("TaxAreaEntitySet")]
            public System.String ToTaxArea { get; set; } 

            public System.String VATRegistration { get; set; } 
			[ForeignKey("VolumeDiscountGroupEntitySet")]
            public System.String VolumeDiscountGroup { get; set; } 

            public System.String WaiverLetterComment { get; set; } 

            public Nullable<System.DateTime> WaiverLetterRecDate { get; set; } 

            public Nullable<System.DateTime> WaiverLetterSubDate { get; set; } 
			[ForeignKey("WithholdingTaxEntitySet")]
            public System.String WithholdingTax { get; set; } 
			[ForeignKey("WPTypeEntitySet")]
            public System.String WPType { get; set; }
    }
}

