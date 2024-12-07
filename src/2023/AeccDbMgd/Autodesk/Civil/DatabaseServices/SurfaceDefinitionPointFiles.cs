using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A3B RID: 2619
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionPointFiles : SurfaceDefinitionBase<SurfaceOperationAddPointFile>
	{
		// Token: 0x060013C6 RID: 5062
		public extern SurfaceOperationAddPointFile AddPointFile(string pointFilename, PointFileFormat pointFileFormat, [MarshalAs(UnmanagedType.U1)] bool useAdjustedElevation, [MarshalAs(UnmanagedType.U1)] bool shouldTransformPointCoordinate, [MarshalAs(UnmanagedType.U1)] bool shouldExpandCoordinateData);

		// Token: 0x060013C7 RID: 5063
		public extern SurfaceOperationAddPointFile AddPointFile(string pointFilename, PointFileFormat pointFileFormat);
	}
}
