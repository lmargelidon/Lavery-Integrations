
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class BankAcct : Object
    {
 

            public System.String AcctNum { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Int32 Bank { get; set; } 
			[Key]
            public System.Guid BankAcctID { get; set; } 

            public System.Int32 BankAcctIndex { get; set; } 

            public System.String BankAcctStatusList { get; set; } 

            public System.String BankAcctType { get; set; } 

            public System.Int32 BankChrgGLAcct { get; set; } 

            public System.Int32 BankGroup { get; set; } 

            public System.String BankModuleList { get; set; } 

            public System.String BIC { get; set; } 

            public System.Int32 CashGLAcct { get; set; } 

            public System.String Currency { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.DateTime EndDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String IBAN { get; set; } 

            public System.Int32 InterestGLAcct { get; set; } 

            public System.Boolean IsDeferCashPost { get; set; } 

            public System.Boolean IsPositivePay { get; set; } 

            public System.Boolean IsRestrictedPayment { get; set; } 

            public System.Guid LangDescription { get; set; } 

            public System.Int32 Language { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String Name { get; set; } 

            public System.Guid NxElecTemplate { get; set; } 

            public System.String NxUnit { get; set; } 

            public System.String Office { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.String RollNum { get; set; } 

            public System.String SortString { get; set; } 

            public System.DateTime StartDate { get; set; } 

            public System.Int32 SuspenseGLAcct { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.Decimal ToleranceAmt { get; set; } 

            public System.Decimal TolerancePct { get; set; }
    }
}

