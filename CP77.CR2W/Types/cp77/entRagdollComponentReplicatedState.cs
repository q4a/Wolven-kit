using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRagdollComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("transforms")] public CArray<Transform> Transforms { get; set; }
		[Ordinal(3)] [RED("isSleeping")] public CBool IsSleeping { get; set; }

		public entRagdollComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
