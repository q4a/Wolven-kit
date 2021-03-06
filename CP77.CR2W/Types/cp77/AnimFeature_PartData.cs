using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PartData : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }

		public AnimFeature_PartData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
