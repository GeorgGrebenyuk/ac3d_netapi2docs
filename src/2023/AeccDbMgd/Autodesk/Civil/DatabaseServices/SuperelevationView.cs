using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200005A RID: 90
	[Wrapper("AeccDbSuperelevationDiagram")]
	public sealed class SuperelevationView : Entity
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003D9 RID: 985
		public extern ObjectId AlignmentId { get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003DA RID: 986
		// (set) Token: 0x060003DB RID: 987
		public extern GraphRangeOptions RangeOption { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003DC RID: 988
		// (set) Token: 0x060003DD RID: 989
		public extern double StationStart { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003DE RID: 990
		// (set) Token: 0x060003DF RID: 991
		public extern double StationEnd { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003E0 RID: 992
		// (set) Token: 0x060003E1 RID: 993
		public extern Point3d Location { get; set; }

		// Token: 0x1700012B RID: 299
		// (set) Token: 0x060003E2 RID: 994
		public override extern ObjectId StyleId { set; }

		// Token: 0x060003E3 RID: 995
		public static extern ObjectId Create(CivilDocument document, string alignmentName, string strNameTemplate, string strDesc, [MarshalAs(UnmanagedType.U1)] bool useLayer, string strLayer, string strBaseLayer, Point3d location);

		// Token: 0x060003E4 RID: 996
		public static extern ObjectId Create(ObjectId alignmentId, string strNameTemplate, string strDesc, [MarshalAs(UnmanagedType.U1)] bool useLayer, string strLayer, string strBaseLayer, Point3d location);

		// Token: 0x060003E5 RID: 997
		public extern void GetStationAndCrossSlope(Point3d pt, ref double dStation, ref double dCrossSlope);

		// Token: 0x060003E6 RID: 998
		public extern ObjectId CreatePolyline(SlopeLineDefinition slopeLineDef);

		// Token: 0x060003E7 RID: 999
		public extern void SetPolylineVisible(SlopeLineDefinition slopeLineDef, [MarshalAs(UnmanagedType.U1)] bool visible);

		// Token: 0x060003E8 RID: 1000
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetPolylineVisible(SlopeLineDefinition slopeLineDef);

		// Token: 0x060003E9 RID: 1001
		public extern void SetPolylineColor(SlopeLineDefinition slopeLineDef, Color color);

		// Token: 0x060003EA RID: 1002
		public extern Color GetPolylineColor(SlopeLineDefinition slopeLineDef);
	}
}
