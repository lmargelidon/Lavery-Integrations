using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Schemas.E3
{
    public class TimeCardPending
	{
		public typeEnvelopp etypeEnvelopp { get; set; }
		public Guid refGuid { get; set; }
		public Guid TimeCardPendingID { get; set; }
		public int TimePendIndex  { get; set; }
		public short IsNB  { get; set; }
		public DateTime PostDate  { get; set; }
		public DateTime GLDate  { get; set; }
		public short IsNoCharge  { get; set; }
		public DateTime WorkDate  { get; set; }
		public String Currency   { get; set; }
		public Decimal WorkAmt  { get; set; }
		public Decimal WorkHrs { get; set; }
		public Decimal  WorkRate { get; set; }
		public String RateCalcList     { get; set; }
		public DateTime StartTime { get; set; }
		public String TimeInterval     { get; set; }
		public String WorkType     { get; set; }
		public String TimeType   { get; set; }
		public String EntryUnitType    { get; set; }
		public int EntryUnit { get; set; }
		public int Timekeeper{ get; set; }
		public Guid TkprEffDate  { get; set; }
		public String Office    { get; set; }
		public int Matter { get; set; }
		public Guid MattEffDate  { get; set; }
		public int Language { get; set; }
		public String TaxCode    { get; set; }
		public String TaxJurisdiction    { get; set; }
		public String TransactionType     { get; set; }
		public Guid Phase  { get; set; }
		public Guid Task  { get; set; }
		public Guid Activity  { get; set; }
		public String Narrative    { get; set; }
		public String Narrative_UnformattedText    { get; set; }
		public String InternalComments     { get; set; }
		public String LoadNumber     { get; set; }
		public String LoadSource     { get; set; }
		public String LoadGroup     { get; set; }
		public int SpvTimekeeper { get; set; }
		public short IsFlatFeeComplete  { get; set; }
		public String TimePracticeArea     { get; set; }
		public int UpdateList { get; set; }
		public String Notes     { get; set; }
		public Guid TempMatter  { get; set; }
		public short  IsTimer { get; set; }
		public int TimeCard { get; set; }
		public Guid DraftUser  { get; set; }
		public String DraftExceptions  { get; set; }
		public String DraftAccess   { get; set; }
		public String ArchetypeCode   { get; set; } 
		public Guid CurrProcItemID  { get; set; }
		public Guid LastProcItemID  { get; set; }
		public Guid OrigProcItemID  { get; set; }
		public short HasAttachments  { get; set; }
		public DateTime TimeStamp  { get; set; }
		public Guid Phase2  { get; set; }
		public Guid Task2  { get; set; }
		public Guid Activity2  { get; set; }
		public String TaskID     { get; set; }
		public String TaskPermGUID  { get; set; }
		public String UniversalTaskID { get; set; }
	}
}
	
