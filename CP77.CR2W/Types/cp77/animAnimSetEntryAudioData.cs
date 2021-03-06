using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimSetEntryAudioData : ISerializable
	{
		[Ordinal(0)] [RED("events")] public CArray<CHandle<animAnimEvent>> Events { get; set; }

		public animAnimSetEntryAudioData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
