using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("meleeSoundsByMaterial")] public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial { get; set; }

		public audioMeleeHitSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
