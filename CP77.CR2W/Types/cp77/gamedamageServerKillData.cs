using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerKillData : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)] [RED("killInfo")] public gameuiKillInfo KillInfo { get; set; }

		public gamedamageServerKillData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
