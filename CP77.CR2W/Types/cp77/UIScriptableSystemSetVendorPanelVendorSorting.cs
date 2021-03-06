using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetVendorPanelVendorSorting : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("sortMode")] public CInt32 SortMode { get; set; }

		public UIScriptableSystemSetVendorPanelVendorSorting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
