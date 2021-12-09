using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Schemas.E3
{
    public class TimeCard
	{
		public typeEnvelopp etypeEnvelopp { get; set; }				
		public Guid refGuid { get; set; }
		public Guid TimecardID { get; set; } 
		public int TimeIndex { get; set; }
		public int OrigTimeIndex { get; set; }
		public int IsActive { get; set; }
		public String Office { get; set; }
		public DateTime WorkDate { get; set; }
		public DateTime PostDate { get; set; }
		public String Currency { get; set; }
		public DateTime CurrDate { get; set; }
		public int Matter { get; set; }
		public int BillMatter { get; set; }
		public int Timekeeper { get; set; }
		public Guid WorkMattEffDate { get; set; }
		public Guid BillMattEffDate { get; set; }
		public Guid TkprEffDate { get; set; }
		public int IsNB { get; set; }
		public int IsNoCharge { get; set; }
		public Decimal  WorkHrs { get; set; }
		public Decimal WorkRate { get; set; }
		public Decimal WorkAmt { get; set; }
		public String StdCurrency { get; set; }
		public Decimal StdRate { get; set; }
		public Decimal StdAmt { get; set; }
		public int Language { get; set; }
		public String Narrative { get; set; }
		public String Narrative_UnformattedText { get; set; }
		public String InternalComments { get; set; }
		public String TimeType { get; set; }
		public String TransactionType { get; set; }
		public String WorkType { get; set; }
		public String RefCurrency { get; set; }
		public Decimal RefRate { get; set; }
		public Decimal RefAmt { get; set; }
		public Decimal UnitCurrRate { get; set; }
		public Decimal FirmCurrRate { get; set; }
		public Decimal UnitCurrRateStd { get; set; }
		public Decimal FirmCurrRateStd { get; set; }
		public Decimal WIPHrs { get; set; }
		public Decimal WIPRate { get; set; }
		public Decimal WIPAmt { get; set; }
		public int IsDisplay { get; set; }
		public String LoadGroup { get; set; }
		public String RateCalcList { get; set; }
		public DateTime GLDate { get; set; }
		public int SpvTimekeeper { get; set; }
		public int IsFlatFeeComplete { get; set; }
		public int IsTaxAdvice { get; set; }
		public int? PrevProfMaster { get; set; }
		public int? IsTimer { get; set; }
		public String ArchetypeCode { get; set; }
		public Guid? LastProcItemID { get; set; }
		public Guid? OrigProcItemID { get; set; }
		public int? HasAttachments { get; set; }
		public DateTime TimeStamp { get; set; }
		public int? LxLabel { get; set; }
	}
}
