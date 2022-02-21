
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Matter : Object
    {
 

            public System.String AdminAccount { get; set; } 

            public System.String AdminInfo { get; set; } 

            public System.String AltNumber { get; set; } 

            public System.DateTime ApproveDate { get; set; } 

            public System.Int32 ApproveTkpr { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Int32 BankAcctAp { get; set; } 

            public System.Int32 BillAsMatter { get; set; } 

            public System.Guid BillDCSTemplate { get; set; } 

            public System.String BillEmail { get; set; } 

            public System.Guid BillGroupDCSTemplate { get; set; } 

            public System.String BillingFrequency { get; set; } 

            public System.String BillingInstruc { get; set; } 

            public System.String BillingOffice { get; set; } 

            public System.Int32 BillSite { get; set; } 

            public System.String ChrgTaxCode { get; set; } 

            public System.Int32 Client { get; set; } 

            public System.DateTime CloseDate { get; set; } 

            public System.Int32 CloseTkpr { get; set; } 

            public System.String Comments { get; set; } 

            public System.String ConflictStatus { get; set; } 

            public System.String ContactInfo { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.String CostTaxCode { get; set; } 

            public System.Guid CreditNoteDCSTemplate { get; set; } 

            public System.Guid CreditNoteGroupDCSTemplate { get; set; } 

            public System.String Currency { get; set; } 

            public System.String CurrencyDateList { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Int32 DueDays { get; set; } 

            public System.String EbillValidationList { get; set; } 

            public System.String ElecBillingType { get; set; } 

            public System.String ElecCostTypeMap { get; set; } 

            public System.Guid ElecDCSTemplate { get; set; } 

            public System.String ElecInfo { get; set; } 

            public System.String ElecNumber { get; set; } 

            public System.String ElecTaxCodeMap { get; set; } 

            public System.String ElecTitleMap { get; set; } 

            public System.String EngageLetterComment { get; set; } 

            public System.DateTime EngageLetterRecDate { get; set; } 

            public System.DateTime EngageLetterSubDate { get; set; } 

            public System.DateTime EntryDate { get; set; } 

            public System.DateTime EstimatedCompletionDate { get; set; } 

            public System.Decimal FeeEstimateAmount { get; set; } 

            public System.String Field1 { get; set; } 

            public System.String Field2 { get; set; } 

            public System.String Field3 { get; set; } 

            public System.Guid GLActivity { get; set; } 

            public System.String GLProject { get; set; } 

            public System.Int32 GLRespTkpr { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String ICBUnitDueFrom { get; set; } 

            public System.String ICBUnitDueTo { get; set; } 

            public ICollection<InvMaster> InvMasters { get; set; } 

            public System.String InvoiceOverride { get; set; } 

            public System.Boolean IsAdmin { get; set; } 

            public System.Boolean IsAllowTrustOverdraw { get; set; } 

            public System.Boolean IsBillStatementIncludeDoubtful { get; set; } 

            public System.Boolean IsConflictsConfidential { get; set; } 

            public System.Boolean IsDefault { get; set; } 

            public System.Boolean IsEBill { get; set; } 

            public System.Boolean IsEngageLetterReq { get; set; } 

            public System.Boolean IsExportRestricted { get; set; } 

            public System.Boolean IsFeeEstimate { get; set; } 

            public System.Boolean IsForeign { get; set; } 

            public System.Boolean IsICBAcctRec { get; set; } 

            public System.Boolean IsICBPayable { get; set; } 

            public System.Boolean IsLeadVolumeDiscountMatter { get; set; } 

            public System.Boolean IsMaster { get; set; } 

            public System.Boolean IsNoBill { get; set; } 

            public System.Boolean IsNonBillable { get; set; } 

            public System.Boolean IsNoProforma { get; set; } 

            public System.Boolean IsOnlyABATimeTypes { get; set; } 

            public System.Boolean IsProBono { get; set; } 

            public System.Boolean IsWaiverLetterReq { get; set; } 

            public System.Int32 Language { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Markup { get; set; } 

            public System.String MattAttribute { get; set; } 

            public ICollection<MattBudget> MattBudgets { get; set; } 

            public System.String MattCategory { get; set; } 

            public System.String MattCloseType { get; set; } 
			[Key]
            public System.Guid MatterID { get; set; } 

            public System.Int32 MattIndex { get; set; } 

            public System.String MattInfo { get; set; } 

            public System.String MattInterest { get; set; } 

            public System.String MattMinType { get; set; } 

            public System.String MattStatus { get; set; } 

            public System.DateTime MattStatusDate { get; set; } 

            public System.String MattType { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String NonBillType { get; set; } 

            public System.String Number { get; set; } 

            public System.DateTime OpenDate { get; set; } 

            public System.Int32 OpenTkpr { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String PaymentTermsInfo { get; set; } 

            public System.Int32 ProBonoEntity { get; set; } 

            public System.String ProBonoInfo { get; set; } 

            public System.Guid ProfDCSTemplate { get; set; } 

            public System.String ProformaEmail { get; set; } 

            public System.String ReferralInfo { get; set; } 

            public System.Int32 RelMattIndex { get; set; } 

            public System.Int32 StatementSite { get; set; } 

            public System.Guid StmtDCSTemplate { get; set; } 

            public System.String TaxReportID1 { get; set; } 

            public System.String TaxReportID2 { get; set; } 

            public System.String TimeIncrement { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.String TimeTaxCode { get; set; } 

            public System.String ToTaxArea { get; set; } 

            public System.String VATRegistration { get; set; } 

            public System.String VolumeDiscountGroup { get; set; } 

            public System.String WaiverLetterComment { get; set; } 

            public System.DateTime WaiverLetterRecDate { get; set; } 

            public System.DateTime WaiverLetterSubDate { get; set; } 

            public System.String WithholdingTax { get; set; } 

            public System.String WPType { get; set; }
    }
}

