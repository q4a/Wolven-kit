using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimTranslationInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public Vector2 StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public Vector2 EndValue { get; set; }

		public inkanimTranslationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
