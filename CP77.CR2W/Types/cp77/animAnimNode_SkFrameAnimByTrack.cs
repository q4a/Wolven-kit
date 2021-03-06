using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		[Ordinal(22)] [RED("progressFloatTrack")] public animNamedTrackIndex ProgressFloatTrack { get; set; }
		[Ordinal(23)] [RED("timeFloatTrack")] public animNamedTrackIndex TimeFloatTrack { get; set; }
		[Ordinal(24)] [RED("frameFloatTrack")] public animNamedTrackIndex FrameFloatTrack { get; set; }
		[Ordinal(25)] [RED("inputWithTracks")] public animPoseLink InputWithTracks { get; set; }

		public animAnimNode_SkFrameAnimByTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
