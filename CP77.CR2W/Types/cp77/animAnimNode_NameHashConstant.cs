using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_NameHashConstant : animAnimNode_IntValue
	{
		[Ordinal(1)] [RED("value")] public CName Value { get; set; }

		public animAnimNode_NameHashConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
