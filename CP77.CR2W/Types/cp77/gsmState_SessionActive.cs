using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gsmState_SessionActive : gsmState_SessionStreamingAware
	{
		public gsmState_SessionActive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
