using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ResolveQualityRangeInteractionLayerEvent : redEvent
	{
		[Ordinal(0)] [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }

		public ResolveQualityRangeInteractionLayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
