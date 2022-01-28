
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Lavery.Wcf.Core
{
     [DataContract]
    public class MatterGetResponseDetail: responseBase
    {

            [DataMember]
            public System.Guid ItemID { get; set; }
            [DataMember]
            public System.String ArchetypeCode { get; set; }
            [DataMember]
            public System.Guid CurrProcItemID { get; set; }
            [DataMember]
            public System.Guid LastProcItemID { get; set; }
            [DataMember]
            public System.Guid OrigProcItemID { get; set; }
            [DataMember]
            public System.Int32 HasAttachments { get; set; }
            [DataMember]
            public System.DateTime TimeStamp { get; set; }
            [DataMember]
            public System.Int32 MattIndex { get; set; }
            [DataMember]
            public System.String Number { get; set; }
            [DataMember]
            public System.String AltNumber { get; set; }
            [DataMember]
            public System.String DisplayName { get; set; }
            [DataMember]
            public System.String Description { get; set; }
            [DataMember]
            public System.Int32 Client { get; set; }
            [DataMember]
            public System.String MattInfo { get; set; }
            [DataMember]
            public System.Int32 RelMattIndex { get; set; }
            [DataMember]
            public System.String MattStatus { get; set; }
            [DataMember]
            public System.DateTime MattStatusDate { get; set; }
            [DataMember]
            public System.String MattType { get; set; }
            [DataMember]
            public System.DateTime OpenDate { get; set; }
            [DataMember]
            public System.String ConflictStatus { get; set; }
            [DataMember]
            public System.String Narrative { get; set; }
            [DataMember]
            public System.String BillingInstruc { get; set; }
            [DataMember]
            public System.Int32 Language { get; set; }
            [DataMember]
            public System.String ContactInfo { get; set; }
            [DataMember]
            public System.String ReferralInfo { get; set; }
            [DataMember]
            public System.String MattCloseType { get; set; }
            [DataMember]
            public System.DateTime CloseDate { get; set; }
            [DataMember]
            public System.Boolean IsMaster { get; set; }
            [DataMember]
            public System.String NonBillType { get; set; }
            [DataMember]
            public System.Boolean IsProBono { get; set; }
            [DataMember]
            public System.Int32 ProBonoEntity { get; set; }
            [DataMember]
            public System.String ProBonoInfo { get; set; }
            [DataMember]
            public System.Boolean IsAdmin { get; set; }
            [DataMember]
            public System.String AdminAccount { get; set; }
            [DataMember]
            public System.String AdminInfo { get; set; }
            [DataMember]
            public System.String ElecBillingType { get; set; }
            [DataMember]
            public System.String ElecNumber { get; set; }
            [DataMember]
            public System.String ElecInfo { get; set; }
            [DataMember]
            public System.Boolean IsNonBillable { get; set; }
            [DataMember]
            public System.Int32 BillAsMatter { get; set; }
            [DataMember]
            public System.Int32 BillSite { get; set; }
            [DataMember]
            public System.Int32 StatementSite { get; set; }
            [DataMember]
            public System.Boolean IsValidate { get; set; }
            [DataMember]
            public System.Int32 OpenTkpr { get; set; }
            [DataMember]
            public System.Int32 CloseTkpr { get; set; }
            [DataMember]
            public System.String Comments { get; set; }
            [DataMember]
            public System.Boolean IsDefault { get; set; }
            [DataMember]
            public System.String BillingFrequency { get; set; }
            [DataMember]
            public System.Boolean IsNoProforma { get; set; }
            [DataMember]
            public System.Boolean IsNoBill { get; set; }
            [DataMember]
            public System.String Markup { get; set; }
            [DataMember]
            public System.String WithholdingTax { get; set; }
            [DataMember]
            public System.String TimeTaxCode { get; set; }
            [DataMember]
            public System.String CostTaxCode { get; set; }
            [DataMember]
            public System.String ChrgTaxCode { get; set; }
            [DataMember]
            public System.Int32 DueDays { get; set; }
            [DataMember]
            public System.String Currency { get; set; }
            [DataMember]
            public System.String CurrencyDateList { get; set; }
            [DataMember]
            public System.String ElecCostTypeMap { get; set; }
            [DataMember]
            public System.String TimeIncrement { get; set; }
            [DataMember]
            public System.Boolean IsAutoNumbering { get; set; }
            [DataMember]
            public System.Boolean IsEngageLetterReq { get; set; }
            [DataMember]
            public System.DateTime EngageLetterSubDate { get; set; }
            [DataMember]
            public System.DateTime EngageLetterRecDate { get; set; }
            [DataMember]
            public System.String EngageLetterComment { get; set; }
            [DataMember]
            public System.Boolean IsWaiverLetterReq { get; set; }
            [DataMember]
            public System.DateTime WaiverLetterSubDate { get; set; }
            [DataMember]
            public System.DateTime WaiverLetterRecDate { get; set; }
            [DataMember]
            public System.String WaiverLetterComment { get; set; }
            [DataMember]
            public System.Boolean IsConflictsConfidential { get; set; }
            [DataMember]
            public System.Guid BillDCSTemplate { get; set; }
            [DataMember]
            public System.Guid ProfDCSTemplate { get; set; }
            [DataMember]
            public System.Guid StmtDCSTemplate { get; set; }
            [DataMember]
            public System.Boolean IsAutoNumAfterSave { get; set; }
            [DataMember]
            public System.Int32 ApproveTkpr { get; set; }
            [DataMember]
            public System.String MattAttribute { get; set; }
            [DataMember]
            public System.String MattCategory { get; set; }
            [DataMember]
            public System.DateTime EntryDate { get; set; }
            [DataMember]
            public System.String VATRegistration { get; set; }
            [DataMember]
            public System.String MattMinType { get; set; }
            [DataMember]
            public System.String GLProject { get; set; }
            [DataMember]
            public System.Boolean IsForeign { get; set; }
            [DataMember]
            public System.String VolumeDiscountGroup { get; set; }
            [DataMember]
            public System.String MattInterest { get; set; }
            [DataMember]
            public System.Boolean IsEBill { get; set; }
            [DataMember]
            public System.String ElecTitleMap { get; set; }
            [DataMember]
            public System.Guid ElecDCSTemplate { get; set; }
            [DataMember]
            public System.String PaymentTermsInfo { get; set; }
            [DataMember]
            public System.Boolean IsFeeEstimate { get; set; }
            [DataMember]
            public System.Decimal FeeEstimateAmount { get; set; }
            [DataMember]
            public System.DateTime EstimatedCompletionDate { get; set; }
            [DataMember]
            public System.DateTime ApproveDate { get; set; }
            [DataMember]
            public System.String InvoiceOverride { get; set; }
            [DataMember]
            public System.String ProformaEmail { get; set; }
            [DataMember]
            public System.String BillEmail { get; set; }
            [DataMember]
            public System.Boolean IsNumberEnabled { get; set; }
            [DataMember]
            public System.Int32 GLRespTkpr { get; set; }
            [DataMember]
            public System.Boolean IsICBAcctRec { get; set; }
            [DataMember]
            public System.Boolean IsICBPayable { get; set; }
            [DataMember]
            public System.String ICBUnitDueTo { get; set; }
            [DataMember]
            public System.String ICBUnitDueFrom { get; set; }
            [DataMember]
            public System.Boolean HasTimekeeperChanged { get; set; }
            [DataMember]
            public System.Boolean IsAllowTrustOverdraw { get; set; }
            [DataMember]
            public System.String BillingOffice { get; set; }
            [DataMember]
            public System.Int32 BankAcctAp { get; set; }
            [DataMember]
            public System.String TaxReportID { get; set; }
            [DataMember]
            public System.String TaxReportID2 { get; set; }
            [DataMember]
            public System.String ToTaxArea { get; set; }
            [DataMember]
            public System.Boolean IsLeadVolumeDiscountMatter { get; set; }
            [DataMember]
            public System.Boolean IsBillStatementIncludeDoubtful { get; set; }
            [DataMember]
            public System.String LoadGroup { get; set; }
            [DataMember]
            public System.String LoadNumber { get; set; }
            [DataMember]
            public System.String LoadSource { get; set; }
            [DataMember]
            public System.String EbillValidationList { get; set; }
            [DataMember]
            public System.String WPType { get; set; }
            [DataMember]
            public System.String BillTkprDispName { get; set; }
            [DataMember]
            public System.Guid GLActivity { get; set; }
            [DataMember]
            public System.Guid CreditNoteDCSTemplate { get; set; }
            [DataMember]
            public System.String ElecTaxCodeMap { get; set; }
            [DataMember]
            public System.Guid BillGroupDCSTemplate { get; set; }
            [DataMember]
            public System.Guid CreditNoteGroupDCSTemplate { get; set; }
            [DataMember]
            public System.Boolean IsExportRestricted { get; set; }
            [DataMember]
            public System.Boolean IsOnlyABATimeTypes { get; set; }
            [DataMember]
            public System.String Client_ClientDispName { get; set; }
            [DataMember]
            public System.String Client_Entity { get; set; }
            [DataMember]
            public System.String Client_Number { get; set; }
            [DataMember]
            public System.Boolean Client_IsEBill { get; set; }
            [DataMember]
            public System.String Client_ClientVolumeDiscount { get; set; }
            [DataMember]
            public System.String Client_Currency { get; set; }
            [DataMember]
            public System.String Client_RelatedClient { get; set; }
            [DataMember]
            public System.String Client_CliStatusType { get; set; }
            [DataMember]
            public System.String Client_StatementSite { get; set; }
            [DataMember]
            public System.Boolean Client_IsClientExportRestricted { get; set; }
            [DataMember]
            public System.String Client_Entity_EntIndex { get; set; }
            [DataMember]
            public System.String Client_Entity_DisplayName { get; set; }
            [DataMember]
            public System.String Client_VolumeDiscountRel_ClientVolumeDiscountDescription { get; set; }
            [DataMember]
            public System.String Client_RelatedClient_RelClientDiscountGroup { get; set; }
            [DataMember]
            public System.String Client_RelatedClient_VolumeDiscountRel_Description { get; set; }
            [DataMember]
            public System.String Client_RelatedClient_Number { get; set; }
            [DataMember]
            public System.Boolean Client_CliStatusType_IsClosed { get; set; }
            [DataMember]
            public System.String Client_CliStatusType_Description { get; set; }
            [DataMember]
            public System.String Client_StatementSite_Description { get; set; }
            [DataMember]
            public System.String RelMattIndex_RelMatterDesc { get; set; }
            [DataMember]
            public System.String RelMattIndex_DisplayName { get; set; }
            [DataMember]
            public System.String RelMattIndex_Number { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsTimeEntry { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsBilling { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsClosed { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsCostEntry { get; set; }
            [DataMember]
            public System.String MattStatus_Description { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsCheckOpenDateOnEntry { get; set; }
            [DataMember]
            public System.Boolean MattStatus_IsChargeEntry { get; set; }
            [DataMember]
            public System.String MattType_Description { get; set; }
            [DataMember]
            public System.String ConflictStatus_Description { get; set; }
            [DataMember]
            public System.String Language_Description { get; set; }
            [DataMember]
            public System.String MattCloseType_Description { get; set; }
            [DataMember]
            public System.Boolean NonBillType_IsChargeBill { get; set; }
            [DataMember]
            public System.Boolean NonBillType_IsCostBill { get; set; }
            [DataMember]
            public System.Boolean NonBillType_IsTimeBill { get; set; }
            [DataMember]
            public System.String NonBillType_Description { get; set; }
            [DataMember]
            public System.String Entity_ProBonoEntityName { get; set; }
            [DataMember]
            public System.String ElecBillingType_Description { get; set; }
            [DataMember]
            public System.String BillAsMatter_Number { get; set; }
            [DataMember]
            public System.String BillSite_BillAddrJoin { get; set; }
            [DataMember]
            public System.String BillSite_Address_BillAddress { get; set; }
            [DataMember]
            public System.String BillSite_Address_Street { get; set; }
            [DataMember]
            public System.String BillSite_Description { get; set; }
            [DataMember]
            public System.String StatementSite_StmtAddrJoin { get; set; }
            [DataMember]
            public System.String StatementSite_Address_StmtAddress { get; set; }
            [DataMember]
            public System.String StatementSite_Address_Street { get; set; }
            [DataMember]
            public System.String StatementSite_Description { get; set; }
            [DataMember]
            public System.String OpenTkprRel_DisplayName { get; set; }
            [DataMember]
            public System.String OpenTkprRel_Number { get; set; }
            [DataMember]
            public System.String CloseTkprRel_DisplayName { get; set; }
            [DataMember]
            public System.String CloseTkprRel_Number { get; set; }
            [DataMember]
            public System.String BillingFrequencyRel_Description { get; set; }
            [DataMember]
            public System.String MarkupRel_Description { get; set; }
            [DataMember]
            public System.String WithholdingTaxRel_Description { get; set; }
            [DataMember]
            public System.String TimeTaxCodeRel_Description { get; set; }
            [DataMember]
            public System.String CostTaxCodeRel_Description { get; set; }
            [DataMember]
            public System.String ChrgTaxCodeRel_Description { get; set; }
            [DataMember]
            public System.String CurrencyRel_Description { get; set; }
            [DataMember]
            public System.String CurrencyDateListRel_Description { get; set; }
            [DataMember]
            public System.String TimeIncrementRel_Description { get; set; }
            [DataMember]
            public System.String BillDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String ProfDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String StmtDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String ApproveTkprRel_Number { get; set; }
            [DataMember]
            public System.String MattAttributeRel_Description { get; set; }
            [DataMember]
            public System.String MattCategoryRel_Description { get; set; }
            [DataMember]
            public System.String MattMinTypeRel_Description { get; set; }
            [DataMember]
            public System.String GLProjectRel_Description { get; set; }
            [DataMember]
            public System.String VolumeDiscountGroupRel_Description { get; set; }
            [DataMember]
            public System.String MattInterestRel_Description { get; set; }
            [DataMember]
            public System.String ElecDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String InvoiceOverrideRel_Code { get; set; }
            [DataMember]
            public System.String InvoiceOverrideRel_Description { get; set; }
            [DataMember]
            public System.String InvoiceOverrideRel_NextInvNumber { get; set; }
            [DataMember]
            public System.String InvoiceOverrideRel_NextCRNoteNumber { get; set; }
            [DataMember]
            public System.String InvoiceOverrideRel_NextTaxInvNumber { get; set; }
            [DataMember]
            public System.String GLRespTkprRel_Number { get; set; }
            [DataMember]
            public System.String ICBUnitDueToRel_Description { get; set; }
            [DataMember]
            public System.String ICBUnitDueFromRel_Description { get; set; }
            [DataMember]
            public System.String BillingOfficeRel_Description { get; set; }
            [DataMember]
            public System.String BankAcctApRel_Name { get; set; }
            [DataMember]
            public System.String ToTaxAreaRel_Description { get; set; }
            [DataMember]
            public System.String WPTypeRel_Description { get; set; }
            [DataMember]
            public System.String GLActivityRel_GLValue { get; set; }
            [DataMember]
            public System.String CreditNoteDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String BillGroupDCSTemplateRel_Name { get; set; }
            [DataMember]
            public System.String CreditNoteGroupDCSTemplateRel_Name { get; set; }
    }
}

