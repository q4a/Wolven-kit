using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetClipboardData : ISerializable
	{
		[Ordinal(0)] [RED("widget")] public CHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)] [RED("widgetPath")] public inkWidgetPath WidgetPath { get; set; }

		public inkWidgetClipboardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
