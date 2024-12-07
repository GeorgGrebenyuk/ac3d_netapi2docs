using System;
using System.Runtime.InteropServices;
using Autodesk.Aec.DatabaseServices;
using Autodesk.Aec.Geometry;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000D3 RID: 211
	[Wrapper("AeccDbNetworkPartDef")]
	public class PartDef : DBObject
	{
		// Token: 0x060009CC RID: 2508
		public extern PartViewDef GetNetworkPartViewDef();

		// Token: 0x060009CD RID: 2509
		public extern Solid3d Get3dBody();

		// Token: 0x060009CE RID: 2510
		public extern Solid3d GetBoundingShapeBody();

		// Token: 0x060009CF RID: 2511
		public extern Profile GetProfileInFrontView();

		// Token: 0x060009D0 RID: 2512
		public extern PartDef(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
