using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkIWidgetLogicController : IScriptable
	{
		[Ordinal(0)] [RED("audioMetadataName")] public CName AudioMetadataName { get; set; }

		public inkIWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
