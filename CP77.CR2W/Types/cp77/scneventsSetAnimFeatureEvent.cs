using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsSetAnimFeatureEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(7)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(8)] [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }

		public scneventsSetAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
