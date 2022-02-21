
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Lavery.OData.Notarier.Models
{     
    public class Client : Object
    {
 

            public System.String AltNumber { get; set; } 

            public System.DateTime ApproveDate { get; set; } 

            public System.Int32 ApproveTkpr { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public System.Guid BillDCSTemplate { get; set; } 

            public System.Guid BillGroupDCSTemplate { get; set; } 

            public System.String BillingInstruc { get; set; } 

            public System.String CliAttribute { get; set; } 

            public System.String CliCategory { get; set; } 
			[Key]
            public System.Guid ClientID { get; set; } 

            public System.Int32 ClientIndex { get; set; } 

            public System.DateTime CliStatusDate { get; set; } 

            public System.String CliStatusType { get; set; } 

            public System.String CliType { get; set; } 

            public System.DateTime CloseDate { get; set; } 

            public System.Int32 CloseTkpr { get; set; } 

            public System.String ConflictStatus { get; set; } 

            public System.String ContactInfo { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.String Country { get; set; } 

            public System.Decimal CreditLimit { get; set; } 

            public System.Guid CreditNoteDCSTemplate { get; set; } 

            public System.Guid CreditNoteGroupDCSTemplate { get; set; } 

            public System.String Currency { get; set; } 

            public System.DateTime CurrencyDate { get; set; } 

            public System.Guid CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String DisplayName { get; set; } 

            public System.Int32 DueDays { get; set; } 

            public System.Int32 EBHClientList { get; set; } 

            public System.String EbillValidationList { get; set; } 

            public System.String EngageLetterComment { get; set; } 

            public System.DateTime EngageLetterRecDate { get; set; } 

            public System.DateTime EngageLetterSubDate { get; set; } 

            public System.Int32 Entity { get; set; } 

            public System.DateTime EntryDate { get; set; } 

            public System.Boolean HasAttachments { get; set; } 

            public System.String ICBUnit { get; set; } 

            public System.DateTime IdentificationDate { get; set; } 

            public System.String Industry { get; set; } 

            public System.Int32 InvoiceSite { get; set; } 

            public System.Boolean IsConflictsConfidential { get; set; } 

            public System.Boolean IsCreateTaxInvOnRcpt { get; set; } 

            public System.Boolean IsEbhAttachments { get; set; } 

            public System.Boolean IsEBill { get; set; } 

            public System.Boolean IsEngageLetterReq { get; set; } 

            public System.Boolean IsExportRestricted { get; set; } 

            public System.Boolean IsICB { get; set; } 

            public System.Boolean IsIdentified { get; set; } 

            public System.Boolean IsPayor { get; set; } 

            public System.Boolean IsWaiverLetterReq { get; set; } 

            public System.Int32 Language { get; set; } 

            public System.Guid LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String Number { get; set; } 

            public System.DateTime OpenDate { get; set; } 

            public System.Int32 OpenTkpr { get; set; } 

            public System.Guid OrigProcItemID { get; set; } 

            public System.Guid ProfDCSTemplate { get; set; } 

            public System.Int32 RelatedClient { get; set; } 

            public System.String RSSFeed { get; set; } 

            public System.String SortString { get; set; } 

            public System.Int32 StatementSite { get; set; } 

            public System.Guid StmtDCSTemplate { get; set; } 

            public System.String TickerSymbol { get; set; } 

            public System.DateTime TimeStamp { get; set; } 

            public System.String URL { get; set; } 

            public System.String VATRegistration { get; set; } 

            public System.String VATRegistrationSeq { get; set; } 

            public System.String VolumeDiscountGroup { get; set; } 

            public System.String WaiverLetterComment { get; set; } 

            public System.DateTime WaiverLetterRecDate { get; set; } 

            public System.DateTime WaiverLetterSubDate { get; set; }
    }
}

