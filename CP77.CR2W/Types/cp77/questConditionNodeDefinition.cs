using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questConditionNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }

		public questConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
