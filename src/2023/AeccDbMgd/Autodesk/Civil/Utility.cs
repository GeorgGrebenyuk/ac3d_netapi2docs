using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil
{
	// Token: 0x020012A7 RID: 4775
	public sealed class Utility
	{
		// Token: 0x060029EF RID: 10735
		public static extern double[] PolarPoint(double[] refPoint, double angle, double distance);

		// Token: 0x060029F0 RID: 10736
		public static extern Point3d PolarPoint(Point3d refPoint, double angle, double distance);
	}
}
