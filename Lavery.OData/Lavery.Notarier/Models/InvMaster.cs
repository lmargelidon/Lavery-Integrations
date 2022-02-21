
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class InvMaster : Object
    {
 

            public System.Decimal AdjAmt { get; set; } 

            public System.Decimal AdjBOA { get; set; } 

            public System.Decimal AdjFee { get; set; } 

            public System.Decimal AdjHCo { get; set; } 

            public System.Decimal AdjInt { get; set; } 

            public System.Decimal AdjOth { get; set; } 

            public System.Decimal AdjSCo { get; set; } 

            public System.Decimal AdjTax { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Decimal BalAmt { get; set; } 

            public System.Decimal BalBOA { get; set; } 

            public System.Decimal BalFee { get; set; } 

            public System.Decimal BalHCo { get; set; } 

            public System.Decimal BalInt { get; set; } 

            public System.Decimal BalOth { get; set; } 

            public System.Decimal BalSCo { get; set; } 

            public System.Decimal BalTax { get; set; } 

            public System.Int32 BillingContact { get; set; } 

            public System.String BillingOffice { get; set; } 

            public System.Int32 BillTimekeeper { get; set; } 

            public System.Int32 CollTimekeeper { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.Guid CreditNoteDCSTemplate { get; set; } 

            public System.String CrNoteNumber { get; set; } 

            public System.DateTime CrNoteTaxDate { get; set; } 

            public System.DateTime CurDate { get; set; } 

            public System.String Currency { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.Int32 DefPayor { get; set; } 

            public System.String DocFile { get; set; } 

            public System.Decimal DoubtfulAmt { get; set; } 

            public System.DateTime DueDate { get; set; } 

            public System.DateTime eBHPostTime { get; set; } 

            public System.Guid eBHPostUser { get; set; } 

            public System.String eBHRequestID { get; set; } 

            public System.Int32 EncryptionKeyVersion { get; set; } 

            public System.Decimal FirmCurrRate { get; set; } 

            public System.DateTime GLDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String Hash { get; set; } 

            public System.String HashText { get; set; } 

            public System.DateTime InvDate { get; set; } 

            public System.Int32 InvIndex { get; set; } 
			[Key]
            public System.Guid InvMasterID { get; set; } 

            public System.String InvNumber { get; set; } 

            public System.Boolean IsArchived { get; set; } 

            public System.Boolean IsBOABalanceTransfer { get; set; } 

            public System.Boolean IsDonotReinstate { get; set; } 

            public System.Boolean IsDonotUpdateWIP { get; set; } 

            public System.Boolean IsEbilled { get; set; } 

            public System.Boolean IseBillingHub { get; set; } 

            public System.Boolean IsPaid { get; set; } 

            public System.Boolean IsReinstateTrustBal { get; set; } 

            public System.Boolean IsRequireEbill { get; set; } 

            public System.Boolean IsRetainInvNumber { get; set; } 

            public System.Boolean IsReversed { get; set; } 

            public System.Boolean IsReversePayment { get; set; } 

            public System.Boolean IsTaxbyMultipayor { get; set; } 

            public System.Boolean IsTaxReportable { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.Decimal OrgAmt { get; set; } 

            public System.Decimal OrgBOA { get; set; } 

            public System.Decimal OrgFee { get; set; } 

            public System.Decimal OrgHCo { get; set; } 

            public System.Decimal OrgInt { get; set; } 

            public System.Decimal OrgOth { get; set; } 

            public System.Decimal OrgSCo { get; set; } 

            public System.Decimal OrgTax { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String OrigTaxInvNumber { get; set; } 

            public System.DateTime PaidDate { get; set; } 

            public System.Int32 ParInvIndex { get; set; } 

            public System.DateTime PostDate { get; set; } 

            public System.String ReasonType { get; set; } 

            public System.Int32 RespTimekeeper { get; set; } 

            public System.String ReverseComment { get; set; } 

            public System.DateTime ReversedDate { get; set; } 

            public System.Decimal Rpt1CurrRate { get; set; } 

            public System.Decimal Rpt2CurrRate { get; set; } 

            public System.Decimal Rpt3CurrRate { get; set; } 

            public System.Int32 SAFTFileGeneration { get; set; } 

            public System.Int32 SendTimekeeper { get; set; } 

            public System.DateTime TaxDate { get; set; } 

            public System.String TaxInvNumber { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.DateTime TranDate { get; set; } 

            public System.Decimal UnitCurrRate { get; set; } 

            public System.String VATRegistration { get; set; }
    }
}

