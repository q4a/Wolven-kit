using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEntityInstanceData : ISerializable
	{
		[Ordinal(0)] [RED("buffer")] public DataBuffer Buffer { get; set; }

		public entEntityInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
