using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimRequestID : CVariable
	{
		[Ordinal(0)] [RED("ID")] public CUInt32 ID { get; set; }
		[Ordinal(1)] [RED("isValid")] public CBool IsValid { get; set; }

		public StimRequestID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
