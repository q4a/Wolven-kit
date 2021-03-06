using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance : CVariable
	{
		[Ordinal(0)] [RED("resource")] public raRef<appearanceAppearanceResource> Resource { get; set; }
		[Ordinal(1)] [RED("definition")] public CName Definition { get; set; }

		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
