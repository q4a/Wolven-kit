using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CTextureArrayEntry : CVariable
	{
		[Ordinal(0)] [RED("texture")] public rRef<CBitmapTexture> Texture { get; set; }

		public CTextureArrayEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
