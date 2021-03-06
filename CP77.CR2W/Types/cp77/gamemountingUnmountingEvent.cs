using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemountingUnmountingEvent : redEvent
	{
		[Ordinal(0)] [RED("request")] public CHandle<gamemountingUnmountingRequest> Request { get; set; }
		[Ordinal(1)] [RED("relationship")] public gamemountingMountingRelationship Relationship { get; set; }

		public gamemountingUnmountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
