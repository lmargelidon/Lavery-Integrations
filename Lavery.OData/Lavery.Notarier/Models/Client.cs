
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lavery.OData.Models
{     
    public class Client 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Client()
        {

        }
 
			[Key]
            public System.Int32 ClientIndex { get; set; } 

            public System.String AltNumber { get; set; } 

            public Nullable<System.DateTime> ApproveDate { get; set; } 

            public Nullable<System.Int32> ApproveTkpr { get; set; } 

            public System.String ArchetypeCode { get; set; } 

            public Nullable<System.Guid> BillDCSTemplate { get; set; } 

            public Nullable<System.Guid> BillGroupDCSTemplate { get; set; } 

            public System.String BillingInstruc { get; set; } 

            public System.String CliAttribute { get; set; } 

            public System.String CliCategory { get; set; } 

            public System.String CliElecBillingType { get; set; } 

            public System.String CliElecCostTypeMap { get; set; } 

            public System.String CliElecTaxCodeMap { get; set; } 

            public System.String CliElecTitleMap { get; set; } 

            public System.Guid ClientID { get; set; } 

            public System.DateTime CliStatusDate { get; set; } 

            public System.String CliStatusType { get; set; } 

            public System.String CliType { get; set; } 

            public Nullable<System.DateTime> CloseDate { get; set; } 

            public Nullable<System.Int32> CloseTkpr { get; set; } 

            public System.String ConflictStatus { get; set; } 

            public System.String ContactInfo { get; set; } 

            public System.String ConvGroup { get; set; } 

            public System.String ConvNumber { get; set; } 

            public System.String ConvSource { get; set; } 

            public System.String Country { get; set; } 

            public Nullable<System.Decimal> CreditLimit { get; set; } 

            public Nullable<System.Guid> CreditNoteDCSTemplate { get; set; } 

            public Nullable<System.Guid> CreditNoteGroupDCSTemplate { get; set; } 

            public System.String Currency { get; set; } 

            public Nullable<System.DateTime> CurrencyDate { get; set; } 

            public Nullable<System.Guid> CurrProcItemID { get; set; } 

            public System.String Description { get; set; } 

            public System.String DisplayName { get; set; } 

            public Nullable<System.Int32> DueDays { get; set; } 

            public System.String EBHArrangement { get; set; } 

            public Nullable<System.Int32> EBHClientList { get; set; } 

            public System.String EbillValidationList { get; set; } 

            public System.String EngageLetterComment { get; set; } 

            public Nullable<System.DateTime> EngageLetterRecDate { get; set; } 

            public Nullable<System.DateTime> EngageLetterSubDate { get; set; } 

            public System.Int32 Entity { get; set; } 

            public Nullable<System.DateTime> EntryDate { get; set; } 

            public Nullable<byte> HasAttachments { get; set; } 

            public System.String ICBUnit { get; set; } 

            public Nullable<System.DateTime> IdentificationDate { get; set; } 

            public System.String Industry { get; set; } 

            public Nullable<System.Int32> InvoiceSite { get; set; } 

            public byte IsConflictsConfidential { get; set; } 

            public byte IsCreateTaxInvOnRcpt { get; set; } 

            public byte IsEbhAttachments { get; set; } 

            public byte IsEBill { get; set; } 

            public byte IsEngageLetterReq { get; set; } 

            public byte IsExportRestricted { get; set; } 

            public byte IsICB { get; set; } 

            public byte IsIdentified { get; set; } 

            public byte IsPayor { get; set; } 

            public byte IsWaiverLetterReq { get; set; } 

            public Nullable<System.Int32> Language { get; set; } 

            public Nullable<System.Guid> LastProcItemID { get; set; } 

            public System.String LoadGroup { get; set; } 

            public System.String LoadNumber { get; set; } 

            public System.String LoadSource { get; set; } 

            public System.Int32 LxLabel { get; set; } 

            public System.String Narrative { get; set; } 

            public System.String Narrative_UnformattedText { get; set; } 

            public System.String Number { get; set; } 

            public System.DateTime OpenDate { get; set; } 

            public System.Int32 OpenTkpr { get; set; } 

            public Nullable<System.Guid> OrigProcItemID { get; set; } 

            public Nullable<System.Guid> ProfDCSTemplate { get; set; } 

            public Nullable<System.Int32> RelatedClient { get; set; } 

            public System.String RSSFeed { get; set; } 

            public System.String SortString { get; set; } 

            public Nullable<System.Int32> StatementSite { get; set; } 

            public Nullable<System.Guid> StmtDCSTemplate { get; set; } 

            public System.String TickerSymbol { get; set; } 

            public Nullable<System.DateTime> TimeStamp { get; set; } 

            public System.String URL { get; set; } 

            public System.String VATRegistration { get; set; } 

            public System.String VATRegistrationSeq { get; set; } 

            public System.String VolumeDiscountGroup { get; set; } 

            public System.String WaiverLetterComment { get; set; } 

            public Nullable<System.DateTime> WaiverLetterRecDate { get; set; } 

            public Nullable<System.DateTime> WaiverLetterSubDate { get; set; }
    }
}

