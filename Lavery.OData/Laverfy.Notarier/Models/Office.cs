
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Office : Object
    {
 

            public System.Guid BillDCSTemplate { get; set; } 

            public System.Guid BillGroupDCSTemplate { get; set; } 

            public System.String CKPrimarySort { get; set; } 

            public System.String CKPrimarySortOrder { get; set; } 

            public System.String CKSecondarySort { get; set; } 

            public System.String CKSecondarySortOrder { get; set; } 

            public System.String Code { get; set; } 

            public System.Guid CreditNoteDCSTemplate { get; set; } 

            public System.Guid CreditNoteGroupDCSTemplate { get; set; } 

            public System.String Description { get; set; } 

            public System.Int32 DueDays { get; set; } 

            public System.Guid GLOffice { get; set; } 

            public System.String IDMaskIdentifier { get; set; } 

            public System.String NextCashTranNumber { get; set; } 

            public System.String NextControlledMoneyNumber { get; set; } 

            public System.String NextCrNoteNumber { get; set; } 

            public System.String NextCRTaxInvNUmber { get; set; } 

            public System.String NextGJNumber { get; set; } 

            public System.String NextInvNumber { get; set; } 

            public System.String NextPONumber { get; set; } 

            public System.String NextRcptNumber { get; set; } 

            public System.String NextTaxInvNumber { get; set; } 

            public System.String NextTrustAdjNumber { get; set; } 

            public System.String NextTrustEFTNumber { get; set; } 

            public System.String NextTrustRcptNumber { get; set; } 

            public System.String NextVoucherNumber { get; set; } 

            public System.String NxUnit { get; set; } 

            public System.String OfficeGroup { get; set; } 
			[Key]
            public System.Guid OfficeID { get; set; } 

            public System.Int32 PriorityBillingGroup { get; set; } 

            public System.Int32 PriorityEntryType { get; set; } 

            public System.Int32 PriorityMatter { get; set; } 

            public System.Int32 PriorityOffice { get; set; } 

            public System.Guid ProfDCSTemplate { get; set; } 

            public System.Int32 Site { get; set; } 

            public System.Guid StmtDCSTemplate { get; set; } 

            public System.String TaxArea { get; set; } 

            public System.String TaxInfo1 { get; set; } 

            public System.String TaxInfo2 { get; set; } 

            public System.String WestLawAcctNum { get; set; }
    }
}

