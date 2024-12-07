using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A32 RID: 2610
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionDrawingObjects : SurfaceDefinitionBase<SurfaceOperationAddDrawingObject>
	{
		// Token: 0x060013BC RID: 5052
		public extern SurfaceOperationAddDrawingObject AddFromPoints(ObjectIdCollection pointIds, string description);

		// Token: 0x060013BD RID: 5053
		public extern SurfaceOperationAddDrawingObject AddFromBlocks(ObjectIdCollection blockIds, string description);

		// Token: 0x060013BE RID: 5054
		public extern SurfaceOperationAddDrawingObject AddFromTexts(ObjectIdCollection textIds, string description);

		// Token: 0x060013BF RID: 5055
		public extern SurfaceOperationAddDrawingObject AddFromLines(ObjectIdCollection lineIds, [MarshalAs(UnmanagedType.U1)] bool needMaintainEdge, string description);

		// Token: 0x060013C0 RID: 5056
		public extern SurfaceOperationAdd3DFaces AddFrom3DFaces(Point3dCollection points, IEnumerable<KeyValuePair<int, int>> edges, string description);

		// Token: 0x060013C1 RID: 5057
		public extern SurfaceOperationAdd3DFaces AddFrom3DFaces(ObjectIdCollection face3DIds, [MarshalAs(UnmanagedType.U1)] bool needMaintainEdge, string description);

		// Token: 0x060013C2 RID: 5058
		public extern SurfaceOperationAddDrawingObject AddFromPolyFaces(ObjectIdCollection polyfaceIds, [MarshalAs(UnmanagedType.U1)] bool needMaintainEdge, string description);
	}
}
