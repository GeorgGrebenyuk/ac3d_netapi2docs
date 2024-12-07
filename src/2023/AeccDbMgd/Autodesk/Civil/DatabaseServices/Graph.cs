using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000054 RID: 84
	[Wrapper("AeccDbGraph")]
	public class Graph : GeoEntity
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000370 RID: 880
		// (set) Token: 0x06000371 RID: 881
		public extern Point3d Location { get; set; }

		// Token: 0x06000372 RID: 882
		protected internal extern Graph(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
