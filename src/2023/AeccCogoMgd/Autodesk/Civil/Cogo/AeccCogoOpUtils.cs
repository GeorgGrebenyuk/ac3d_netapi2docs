using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.Cogo
{
	// Token: 0x0200003C RID: 60
	public class AeccCogoOpUtils : IDisposable
	{
		// Token: 0x06000004 RID: 4
		public static extern string FormatBearing(double angle);

		// Token: 0x06000005 RID: 5
		public static extern string FormatStation(double station);

		// Token: 0x06000006 RID: 6
		public static extern string FormatDistance(double distance);

		// Token: 0x06000007 RID: 7
		public static extern string FormatArea(double area);

		// Token: 0x06000008 RID: 8
		public static extern string FormatNorthingEasting(double x, double y);

		// Token: 0x06000009 RID: 9
		public static extern void FormatNorthingEasting(double x, double y, ref string easting, ref string northing);

		// Token: 0x0600000A RID: 10
		public static extern string FormatAngle(double angle);

		// Token: 0x0600000B RID: 11
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseLocation(string input, ref Point3d output);

		// Token: 0x0600000C RID: 12
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParsePointNumber(string input, ref uint output);

		// Token: 0x0600000D RID: 13
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseBearing(string input, ref double output);

		// Token: 0x0600000E RID: 14
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseDistance(string input, ref double output);

		// Token: 0x0600000F RID: 15
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseDeltaAngle(string input, ref double output);

		// Token: 0x06000010 RID: 16
		public static extern double ConverBetweenBearingAndAngle(double bearingOrAngle);

		// Token: 0x06000011 RID: 17
		public static extern double CalculateBulge(Point2d ptStart, Point2d ptEnd, double dRadius, Point2d ptCenter, [MarshalAs(UnmanagedType.U1)] bool clockwise);

		// Token: 0x06000012 RID: 18
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000013 RID: 19
		public sealed extern void Dispose();
	}
}
