using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifySurfaceDirectionChanged : redEvent
	{
		[Ordinal(0)] [RED("surfaceDirection")] public CEnum<gameaudioeventsSurfaceDirection> SurfaceDirection { get; set; }

		public gameaudioeventsNotifySurfaceDirectionChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
