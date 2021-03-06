using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectAnimated : gameContainerObjectBase
	{
		[Ordinal(51)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }

		public gameContainerObjectAnimated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
