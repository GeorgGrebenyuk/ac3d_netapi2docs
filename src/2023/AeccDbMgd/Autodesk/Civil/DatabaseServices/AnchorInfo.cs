using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006D RID: 109
	public class AnchorInfo
	{
		// Token: 0x06000498 RID: 1176
		public extern AnchorInfo([MarshalAs(UnmanagedType.U1)] bool isOnCurve, Point2d centerOfCurve, Vector3d directionAtLocation, Point3d location);

		// Token: 0x040002FB RID: 763
		public readonly bool IsOnCurve;

		// Token: 0x040002FC RID: 764
		public readonly Point2d CenterOfCurve;

		// Token: 0x040002FD RID: 765
		public readonly Vector3d DirectionAtLocation;

		// Token: 0x040002FE RID: 766
		public readonly Point3d Location;
	}
}
