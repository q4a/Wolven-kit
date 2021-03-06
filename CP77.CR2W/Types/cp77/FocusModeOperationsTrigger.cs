using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<FocusModeOperationTriggerData> TriggerData { get; set; }

		public FocusModeOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
