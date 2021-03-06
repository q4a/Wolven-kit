using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorInstanceCallStack : CVariable
	{
		[Ordinal(0)] [RED("resourceHashes")] public CArray<CUInt32> ResourceHashes { get; set; }

		public AIbehaviorBehaviorInstanceCallStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
