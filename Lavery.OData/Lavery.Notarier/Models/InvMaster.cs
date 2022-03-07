
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Notarier.Models
{     
    public class InvMaster 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  InvMaster()
        {

        }
 

            public Nullable<System.Decimal> AdjAmt { get; set; } 

            public Nullable<System.Decimal> AdjBOA { get; set; } 

            public Nullable<System.Decimal> AdjFee { get; set; } 

            public Nullable<System.Decimal> AdjHCo { get; set; } 

            public Nullable<System.Decimal> AdjInt { get; set; } 

            public Nullable<System.Decimal> AdjOth { get; set; } 

            public Nullable<System.Decimal> AdjSCo { get; set; } 

            public Nullable<System.Decimal> AdjTax { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Decimal> BalAmt { get; set; } 

            public Nullable<System.Decimal> BalBOA { get; set; } 

            public Nullable<System.Decimal> BalFee { get; set; } 

            public Nullable<System.Decimal> BalHCo { get; set; } 

            public Nullable<System.Decimal> BalInt { get; set; } 

            public Nullable<System.Decimal> BalOth { get; set; } 

            public Nullable<System.Decimal> BalSCo { get; set; } 

            public Nullable<System.Decimal> BalTax { get; set; } 

            public Nullable<System.Int32> BillingContact { get; set; } 

            public System.String BillingOffice { get; set; } 

            public Nullable<System.Int32> BillTimekeeper { get; set; } 

            public Nullable<System.Int32> CollTimekeeper { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public Nullable<System.Guid> CreditNoteDCSTemplate { get; set; } 

            public System.String CrNoteNumber { get; set; } 

            public Nullable<System.DateTime> CrNoteTaxDate { get; set; } 

            public Nullable<System.DateTime> CurDate { get; set; } 

            public System.String Currency { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public Nullable<System.Int32> DefPayor { get; set; } 

            public System.String DocFile { get; set; } 

            public Nullable<System.Decimal> DoubtfulAmt { get; set; } 

            public Nullable<System.DateTime> DueDate { get; set; } 

            public Nullable<System.DateTime> eBHPostTime { get; set; } 

            public Nullable<System.Guid> eBHPostUser { get; set; } 

            public System.String eBHRequestID { get; set; } 

            public Nullable<System.Int32> EncryptionKeyVersion { get; set; } 

            public Nullable<System.Decimal> FirmCurrRate { get; set; } 

            public Nullable<System.DateTime> GLDate { get; set; } 

            public Nullable<System.Boolean> HasAttachments { get; set; } 

            public System.String Hash { get; set; } 

            public System.String HashText { get; set; } 

            public Nullable<System.DateTime> InvDate { get; set; } 

            public System.Int32 InvIndex { get; set; } 

            public System.Guid InvMasterID { get; set; } 

            public System.String InvNumber { get; set; } 

            public System.Boolean IsArchived { get; set; } 

            public System.Boolean IsBOABalanceTransfer { get; set; } 

            public System.Boolean IsDonotReinstate { get; set; } 

            public System.Boolean IsDonotUpdateWIP { get; set; } 

            public System.Boolean IsEbilled { get; set; } 

            public System.Boolean IseBillingHub { get; set; } 

            public System.Boolean IsPaid { get; set; } 

            public Nullable<System.Boolean> IsReinstateTrustBal { get; set; } 

            public System.Boolean IsRequireEbill { get; set; } 

            public System.Boolean IsRetainInvNumber { get; set; } 

            public System.Boolean IsReversed { get; set; } 

            public System.Boolean IsReversePayment { get; set; } 

            public System.Boolean IsTaxbyMultipayor { get; set; } 

            public System.Boolean IsTaxReportable { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 
			[ForeignKey("LinkInvMasterAndMatter")]
            public Nullable<int> LeadMatter { get; set; } 

            public Matter LinkInvMasterAndMatter { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public Nullable<System.Decimal> OrgAmt { get; set; } 

            public Nullable<System.Decimal> OrgBOA { get; set; } 

            public System.Decimal OrgFee { get; set; } 

            public Nullable<System.Decimal> OrgHCo { get; set; } 

            public Nullable<System.Decimal> OrgInt { get; set; } 

            public Nullable<System.Decimal> OrgOth { get; set; } 

            public Nullable<System.Decimal> OrgSCo { get; set; } 

            public Nullable<System.Decimal> OrgTax { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String OrigTaxInvNumber { get; set; } 

            public Nullable<System.DateTime> PaidDate { get; set; } 

            public Nullable<System.Int32> ParInvIndex { get; set; } 

            public Nullable<System.DateTime> PostDate { get; set; } 

            public System.String ReasonType { get; set; } 

            public Nullable<System.Int32> RespTimekeeper { get; set; } 

            public System.String ReverseComment { get; set; } 

            public Nullable<System.DateTime> ReversedDate { get; set; } 

            public Nullable<System.Decimal> Rpt1CurrRate { get; set; } 

            public Nullable<System.Decimal> Rpt2CurrRate { get; set; } 

            public Nullable<System.Decimal> Rpt3CurrRate { get; set; } 

            public Nullable<System.Int32> SAFTFileGeneration { get; set; } 

            public Nullable<System.Int32> SendTimekeeper { get; set; } 

            public Nullable<System.DateTime> TaxDate { get; set; } 

            public System.String TaxInvNumber { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public Nullable<System.DateTime> TranDate { get; set; } 

            public Nullable<System.Decimal> UnitCurrRate { get; set; } 

            public System.String VATRegistration { get; set; }
    }
}

