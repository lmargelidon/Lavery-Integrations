
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Notarier.Models
{     
    public class Matter 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Matter()
        {
				this.InvMasters = new HashSet<InvMaster>();
				this.MattBudgets = new HashSet<MattBudget>();

        }
 
			[Key]
            public System.Int32 MattIndex { get; set; } 

            public System.String AdminAccount { get; set; } 

            public System.String AdminInfo { get; set; } 

            public System.String AltNumber { get; set; } 

            public Nullable<System.DateTime> ApproveDate { get; set; } 

            public Nullable<System.Int32> ApproveTkpr { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Int32> BankAcctAp { get; set; } 

            public Nullable<System.Int32> BillAsMatter { get; set; } 

            public Nullable<System.Guid> BillDCSTemplate { get; set; } 

            public System.String BillEmail { get; set; } 

            public Nullable<System.Guid> BillGroupDCSTemplate { get; set; } 

            public System.String BillingFrequency { get; set; } 

            public System.String BillingInstruc { get; set; } 

            public System.String BillingOffice { get; set; } 

            public Nullable<System.Int32> BillSite { get; set; } 

            public System.String ChrgTaxCode { get; set; } 

            public System.Int32 Client { get; set; } 

            public Nullable<System.DateTime> CloseDate { get; set; } 

            public Nullable<System.Int32> CloseTkpr { get; set; } 

            public System.String Comments { get; set; } 

            public System.String ConflictStatus { get; set; } 

            public System.String ContactInfo { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.String CostTaxCode { get; set; } 

            public Nullable<System.Guid> CreditNoteDCSTemplate { get; set; } 

            public Nullable<System.Guid> CreditNoteGroupDCSTemplate { get; set; } 

            public System.String Currency { get; set; } 

            public System.String CurrencyDateList { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String DisplayName { get; set; } 

            public Nullable<System.Int32> DueDays { get; set; } 

            public System.String EbillValidationList { get; set; } 

            public System.String ElecBillingType { get; set; } 

            public System.String ElecCostTypeMap { get; set; } 

            public Nullable<System.Guid> ElecDCSTemplate { get; set; } 

            public System.String ElecInfo { get; set; } 

            public System.String ElecNumber { get; set; } 

            public System.String ElecTaxCodeMap { get; set; } 

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

            public Nullable<System.Guid> GLActivity { get; set; } 

            public System.String GLProject { get; set; } 

            public Nullable<System.Int32> GLRespTkpr { get; set; } 

            public Nullable<System.Boolean> HasAttachments { get; set; } 

            public System.String ICBUnitDueFrom { get; set; } 

            public System.String ICBUnitDueTo { get; set; } 
			[InverseProperty(  "LinkInvMasterAndMatter"), 
            System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public ICollection<InvMaster> InvMasters { get; set; } 

            public System.String InvoiceOverride { get; set; } 

            public System.Boolean IsAdmin { get; set; } 

            public System.Boolean IsAllowTrustOverdraw { get; set; } 

            public System.Boolean IsBillStatementIncludeDoubtful { get; set; } 

            public Nullable<System.Boolean> IsConflictsConfidential { get; set; } 

            public Nullable<System.Boolean> IsDefault { get; set; } 

            public System.Boolean IsEBill { get; set; } 

            public System.Boolean IsEngageLetterReq { get; set; } 

            public System.Boolean IsExportRestricted { get; set; } 

            public System.Boolean IsFeeEstimate { get; set; } 

            public Nullable<System.Boolean> IsForeign { get; set; } 

            public System.Boolean IsICBAcctRec { get; set; } 

            public System.Boolean IsICBPayable { get; set; } 

            public System.Boolean IsLeadVolumeDiscountMatter { get; set; } 

            public System.Boolean IsMaster { get; set; } 

            public System.Boolean IsNoBill { get; set; } 

            public Nullable<System.Boolean> IsNonBillable { get; set; } 

            public System.Boolean IsNoProforma { get; set; } 

            public System.Boolean IsOnlyABATimeTypes { get; set; } 

            public System.Boolean IsProBono { get; set; } 

            public System.Boolean IsWaiverLetterReq { get; set; } 

            public System.Int32 Language { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Markup { get; set; } 

            public System.String MattAttribute { get; set; } 
			[InverseProperty(  "LinkMattBudgetAndMatter"), 
            System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public ICollection<MattBudget> MattBudgets { get; set; } 

            public System.String MattCategory { get; set; } 

            public System.String MattCloseType { get; set; } 

            public System.Guid MatterID { get; set; } 

            public System.String MattInfo { get; set; } 

            public System.String MattInterest { get; set; } 

            public System.String MattMinType { get; set; } 

            public System.String MattStatus { get; set; } 

            public Nullable<System.DateTime> MattStatusDate { get; set; } 

            public System.String MattType { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String NonBillType { get; set; } 

            public System.String Number { get; set; } 

            public System.DateTime OpenDate { get; set; } 

            public System.Int32 OpenTkpr { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String PaymentTermsInfo { get; set; } 

            public Nullable<System.Int32> ProBonoEntity { get; set; } 

            public System.String ProBonoInfo { get; set; } 

            public Nullable<System.Guid> ProfDCSTemplate { get; set; } 

            public System.String ProformaEmail { get; set; } 

            public System.String ReferralInfo { get; set; } 

            public Nullable<System.Int32> RelMattIndex { get; set; } 

            public Nullable<System.Int32> StatementSite { get; set; } 

            public Nullable<System.Guid> StmtDCSTemplate { get; set; } 

            public System.String TaxReportID1 { get; set; } 

            public System.String TaxReportID2 { get; set; } 

            public System.String TimeIncrement { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public System.String TimeTaxCode { get; set; } 

            public System.String ToTaxArea { get; set; } 

            public System.String VATRegistration { get; set; } 

            public System.String VolumeDiscountGroup { get; set; } 

            public System.String WaiverLetterComment { get; set; } 

            public Nullable<System.DateTime> WaiverLetterRecDate { get; set; } 

            public Nullable<System.DateTime> WaiverLetterSubDate { get; set; } 

            public System.String WithholdingTax { get; set; } 

            public System.String WPType { get; set; }
    }
}

