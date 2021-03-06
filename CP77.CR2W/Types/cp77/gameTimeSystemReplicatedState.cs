using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTimeSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] [RED("paused")] public CBool Paused { get; set; }
		[Ordinal(1)] [RED("gameTime")] public GameTime GameTime { get; set; }

		public gameTimeSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
