using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("parentTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> ParentTransform { get; set; }
		[Ordinal(3)] [RED("isParentTransformResaved")] public CBool IsParentTransformResaved { get; set; }
		[Ordinal(4)] [RED("parentTransformIndex")] public animTransformIndex ParentTransformIndex { get; set; }
		[Ordinal(5)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(6)] [RED("interpolationType")] public CEnum<animEInterpolationType> InterpolationType { get; set; }
		[Ordinal(7)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(8)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }
		[Ordinal(9)] [RED("useBoneReferencePoseAsDefaultOffset")] public CBool UseBoneReferencePoseAsDefaultOffset { get; set; }
		[Ordinal(10)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(11)] [RED("offsetTranslationLS")] public animVectorLink OffsetTranslationLS { get; set; }
		[Ordinal(12)] [RED("offsetEulerRotationLS")] public animVectorLink OffsetEulerRotationLS { get; set; }

		public animAnimNode_ParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
