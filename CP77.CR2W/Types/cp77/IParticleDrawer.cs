using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IParticleDrawer : ISerializable
	{
		[Ordinal(0)] [RED("pivotOffset")] public CFloat PivotOffset { get; set; }

		public IParticleDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
