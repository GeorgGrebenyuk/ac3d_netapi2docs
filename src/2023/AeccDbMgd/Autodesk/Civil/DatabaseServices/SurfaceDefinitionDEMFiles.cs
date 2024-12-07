using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009DA RID: 2522
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionDEMFiles : SurfaceDefinitionBase<SurfaceOperationAddDEMFile>
	{
		// Token: 0x060012B4 RID: 4788
		public extern SurfaceOperationAddDEMFile AddDEMFile(string filename, string coordinateSystemCode, [MarshalAs(UnmanagedType.U1)] bool useCustomNullElevation, double customeNullElevation);

		// Token: 0x060012B5 RID: 4789
		public extern SurfaceOperationAddDEMFile AddDEMFile(string filename, [MarshalAs(UnmanagedType.U1)] bool useCustomNullElevation, double customeNullElevation);

		// Token: 0x060012B6 RID: 4790
		public extern SurfaceOperationAddDEMFile AddDEMFile(string filename);
	}
}
