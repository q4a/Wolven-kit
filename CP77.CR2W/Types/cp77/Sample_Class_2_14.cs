using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_14 : CVariable
	{
		[Ordinal(0)] [RED("var0")] public CFloat Var0 { get; set; }

		public Sample_Class_2_14(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
