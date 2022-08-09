
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class BankAcct 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  BankAcct()
        {

        }
 
			[Key]
            public System.Int32 BankAcctIndex { get; set; } 

            public System.String AcctNum { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Int32 Bank { get; set; } 

            public System.Guid BankAcctID { get; set; } 

            public System.String BankAcctStatusList { get; set; } 

            public System.String BankAcctType { get; set; } 

            public Nullable<System.Int32> BankChrgGLAcct { get; set; } 

            public System.Int32 BankGroup { get; set; } 

            public System.String BankModuleList { get; set; } 

            public System.String BIC { get; set; } 

            public System.Int32 CashGLAcct { get; set; } 

            public System.String Currency { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String EFTBankCode { get; set; } 

            public System.String EFTDescription { get; set; } 

            public System.String EFTUserID { get; set; } 

            public System.String EFTUserName { get; set; } 

            public Nullable<System.DateTime> EndDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public System.String IBAN { get; set; } 

            public Nullable<System.Int32> InterestGLAcct { get; set; } 

            public Nullable<byte> IsBalanced { get; set; } 

            public byte IsDeferCashPost { get; set; } 

            public byte IsPositivePay { get; set; } 

            public byte IsRestrictedPayment { get; set; } 

            public Nullable<System.Guid> LangDescription { get; set; } 

            public Nullable<System.Int32> Language { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String Name { get; set; } 

            public Nullable<System.Guid> NxElecTemplate { get; set; } 

            public System.String NxUnit { get; set; } 

            public System.String Office { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public System.String RollNum { get; set; } 

            public Nullable<System.Decimal> SecondSignatureThreshold { get; set; } 

            public System.String SortString { get; set; } 

            public Nullable<System.DateTime> StartDate { get; set; } 

            public Nullable<System.Int32> SuspenseGLAcct { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public Nullable<System.Decimal> ToleranceAmt { get; set; } 

            public Nullable<System.Decimal> TolerancePct { get; set; }
    }
}

