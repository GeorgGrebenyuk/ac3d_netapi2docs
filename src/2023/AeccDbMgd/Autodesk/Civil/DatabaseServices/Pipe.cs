using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C6 RID: 198
	[Wrapper("AeccDbPipe")]
	public sealed class Pipe : Part
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060008EC RID: 2284
		// (set) Token: 0x060008ED RID: 2285
		public extern Point3d EndPoint { get; set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060008EE RID: 2286
		// (set) Token: 0x060008EF RID: 2287
		public extern Point3d StartPoint { get; set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060008F0 RID: 2288
		public extern FlowDirectionType FlowDirection { get; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060008F1 RID: 2289
		// (set) Token: 0x060008F2 RID: 2290
		public extern FlowDirectionMethodType FlowDirectionMethod { get; set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060008F3 RID: 2291
		public extern double Length2D { get; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060008F4 RID: 2292
		public extern double Length2DCenterToCenter { get; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060008F5 RID: 2293
		public extern double Length3D { get; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060008F6 RID: 2294
		public extern double Length3DCenterToCenter { get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060008F7 RID: 2295
		public extern double Length2DToInsideEdge { get; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060008F8 RID: 2296
		public extern double Length3DToInsideEdge { get; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060008F9 RID: 2297
		public extern double InnerDiameterOrWidth { get; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060008FA RID: 2298
		public extern double OuterDiameterOrWidth { get; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060008FB RID: 2299
		public extern double MaximumCover { get; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060008FC RID: 2300
		public extern double MinimumCover { get; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060008FD RID: 2301
		public extern double Slope { get; }

		// Token: 0x060008FE RID: 2302
		public extern void SetSlopeHoldStart(double startValue);

		// Token: 0x060008FF RID: 2303
		public extern void SetSlopeHoldEnd(double endValue);

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000900 RID: 2304
		public extern ObjectId StartStructureId { get; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000901 RID: 2305
		public extern ObjectId EndStructureId { get; }

		// Token: 0x06000902 RID: 2306
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsMinCoverViolated(double minCover, ref Point3d[] pointsViolated, ref double[] differences, ref double[] @params);

		// Token: 0x06000903 RID: 2307
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsMaxCoverViolated(double maxCover, ref Point3d[] pointsViolated, ref double[] differences, ref double[] @params);

		// Token: 0x06000904 RID: 2308
		[Obsolete("Use GetCLosetPointTo(Point3d sourcePoint, bool extend = false) instead", false)]
		[DeprecatedVersion(CivilVersion.Civil2020)]
		public extern Point3d GetClosestPointTo(Point3d sourcePoint);

		// Token: 0x06000905 RID: 2309
		public extern void Disconnect(ConnectorPositionType pos);

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000906 RID: 2310
		// (set) Token: 0x06000907 RID: 2311
		public extern HoldOnResizeType HoldOnResizeType { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000908 RID: 2312
		public extern double InnerHeight { get; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000909 RID: 2313
		public extern double OuterHeight { get; }

		// Token: 0x0600090A RID: 2314
		public extern Point3d GetPointAtParam(double paramInterval);

		// Token: 0x0600090B RID: 2315
		public extern double GetParamAtPoint(Point3d point);

		// Token: 0x0600090C RID: 2316
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetProject2dPointVertically(Point2d sourcePoint, ref Point3d projectPoint);

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600090D RID: 2317
		public extern double Radius { get; }

		// Token: 0x0600090E RID: 2318
		public extern void ResizeByInnerDiameterOrWidth(double innerDiameterOrWidth, [MarshalAs(UnmanagedType.U1)] bool useClosestSize);

		// Token: 0x170003C2 RID: 962
		// (set) Token: 0x0600090F RID: 2319
		public override extern ObjectId StyleId { set; }

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000910 RID: 2320
		public extern PipeSubEntityType SubEntityType { get; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000911 RID: 2321
		public extern double Bearing { get; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000912 RID: 2322
		public extern double StartStation { get; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000913 RID: 2323
		public extern double EndStation { get; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000914 RID: 2324
		public extern double StartOffset { get; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000915 RID: 2325
		public extern double EndOffset { get; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000916 RID: 2326
		public extern SweptShapeType CrossSectionalShape { get; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000917 RID: 2327
		public extern double CoverOfStartPoint { get; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000918 RID: 2328
		public extern double CoverOfEndpoint { get; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000919 RID: 2329
		// (set) Token: 0x0600091A RID: 2330
		public extern double HydraulicGradeLineUp { get; set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600091B RID: 2331
		// (set) Token: 0x0600091C RID: 2332
		public extern double HydraulicGradeLineDown { get; set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600091D RID: 2333
		// (set) Token: 0x0600091E RID: 2334
		public extern double EnergyGradeLineUp { get; set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600091F RID: 2335
		// (set) Token: 0x06000920 RID: 2336
		public extern double EnergyGradeLineDown { get; set; }

		// Token: 0x06000921 RID: 2337
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Pipe.GetPipeLabelIds instead.", false)]
		public extern ObjectIdCollection GetLabelIds();

		// Token: 0x06000922 RID: 2338
		public extern ObjectIdCollection GetPipeLabelIds();

		// Token: 0x06000923 RID: 2339
		public extern ObjectIdCollection GetAvailablePipeLabelIds();

		// Token: 0x06000924 RID: 2340
		public extern ObjectIdCollection GetAvailableSpanningPipeLabelIds();

		// Token: 0x06000925 RID: 2341
		public extern void ConnectToStructure(ConnectorPositionType sourcePosition, ObjectId destinationStructureId, [MarshalAs(UnmanagedType.U1)] bool force);

		// Token: 0x06000926 RID: 2342
		public extern void ConnectToPipe(ConnectorPositionType sourceType, ObjectId destinationPipeId, ConnectorPositionType destinationType, ObjectId structureFamilyId, ObjectId structureSizeId, ref ObjectId newStructureId, [MarshalAs(UnmanagedType.U1)] bool applyRules, [MarshalAs(UnmanagedType.U1)] bool force);

		// Token: 0x06000927 RID: 2343
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool AdjustEndpoint(ConnectorPositionType endpointToAdjust, PipeEndLocation targetLocation, double dOffset);

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000928 RID: 2344
		public extern CircularArc2d Curve2d { get; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000929 RID: 2345
		// (set) Token: 0x0600092A RID: 2346
		public extern double FlowRate { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600092B RID: 2347
		// (set) Token: 0x0600092C RID: 2348
		public extern double JunctionLoss { get; set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600092D RID: 2349
		// (set) Token: 0x0600092E RID: 2350
		public extern int ReturnPeriod { get; set; }
	}
}
