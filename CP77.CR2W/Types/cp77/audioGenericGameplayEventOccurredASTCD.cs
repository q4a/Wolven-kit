using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioGenericGameplayEventOccurredASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("gameplayEvent")] public CName GameplayEvent { get; set; }

		public audioGenericGameplayEventOccurredASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
