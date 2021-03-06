using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] [RED("qualitySettingsArray")] public CArray<worldQualitySetting> QualitySettingsArray { get; set; }
		[Ordinal(6)] [RED("disableCrowdUniqueName")] public CName DisableCrowdUniqueName { get; set; }
		[Ordinal(7)] [RED("globalStreamingDistanceScale")] public CFloat GlobalStreamingDistanceScale { get; set; }

		public worldPerformanceAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
