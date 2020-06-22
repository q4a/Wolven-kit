using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CThumbnail : CObject
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("info", 2,0)] 		public CArray<CString> Info { get; set;}

		[RED("cameraPosition")] 		public Vector CameraPosition { get; set;}

		[RED("cameraRotation")] 		public EulerAngles CameraRotation { get; set;}

		[RED("cameraFov")] 		public CFloat CameraFov { get; set;}

		[RED("sunRotation")] 		public EulerAngles SunRotation { get; set;}

		[RED("flags")] 		public CInt32 Flags { get; set;}

		public CThumbnail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CThumbnail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}