using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCurveStatModifierData : gameStatModifierData
	{
		[Ordinal(2)] [RED("curveName")] public CName CurveName { get; set; }
		[Ordinal(3)] [RED("columnName")] public CName ColumnName { get; set; }
		[Ordinal(4)] [RED("curveStat")] public CEnum<gamedataStatType> CurveStat { get; set; }

		public gameCurveStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
