using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000105 RID: 261
	[Wrapper("AeccDbCatchmentArea")]
	public sealed class Catchment : Entity
	{
		// Token: 0x06000BB3 RID: 2995
		public static extern ObjectId Create(string name, ObjectId styleId, ObjectId catchmentGroupId, ObjectId surfaceId, Point3dCollection boundary);

		// Token: 0x06000BB4 RID: 2996
		public static extern ObjectId CreateCopy(ObjectId catchmentId, ObjectId groupId);

		// Token: 0x06000BB5 RID: 2997
		public extern ObjectIdCollection GetAvailableCatchmentLabelIds();

		// Token: 0x06000BB6 RID: 2998
		public extern ObjectIdCollection GetAvailableFlowSegmentLabelIds();

		// Token: 0x06000BB7 RID: 2999
		public extern FlowPath GetFlowPath();

		// Token: 0x06000BB8 RID: 3000
		public extern void SetFlowPath(Point3dCollection FlowPath);

		// Token: 0x06000BB9 RID: 3001
		public extern void SetFlowPath(FlowPath flowPath);

		// Token: 0x17000514 RID: 1300
		// (set) Token: 0x06000BBA RID: 3002
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000BBB RID: 3003
		public extern double Area2d { get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000BBC RID: 3004
		public extern double Perimeter2d { get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000BBD RID: 3005
		public extern Point2dCollection BoundaryPolyline2d { get; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000BBE RID: 3006
		// (set) Token: 0x06000BBF RID: 3007
		public extern Point3dCollection BoundaryPolyline3d { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000BC0 RID: 3008
		public extern ObjectId ContainingGroupId { get; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000BC1 RID: 3009
		public extern Point3d DischargePoint { get; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000BC2 RID: 3010
		// (set) Token: 0x06000BC3 RID: 3011
		public extern int CurveNumber { get; set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000BC4 RID: 3012
		// (set) Token: 0x06000BC5 RID: 3013
		public extern HydrologicalSoilGroup HydrologicalSoilGroup { get; set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000BC6 RID: 3014
		// (set) Token: 0x06000BC7 RID: 3015
		public extern int AntecedentWetness { get; set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000BC8 RID: 3016
		// (set) Token: 0x06000BC9 RID: 3017
		public extern double ImperviousArea { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000BCA RID: 3018
		// (set) Token: 0x06000BCB RID: 3019
		public extern double UnconnectedImperviousArea { get; set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000BCC RID: 3020
		public extern Point3d HydrologicallyMostDistantPoint { get; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000BCD RID: 3021
		public extern double HydrologicallyMostDistantLength { get; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000BCE RID: 3022
		public extern bool Exclusionary { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000BCF RID: 3023
		// (set) Token: 0x06000BD0 RID: 3024
		public extern double TimeOfConcentration { get; set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000BD1 RID: 3025
		// (set) Token: 0x06000BD2 RID: 3026
		public extern TimeOfConcentrationCalculationMethod TimeOfConcentrationCalculationMethod { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000BD3 RID: 3027
		// (set) Token: 0x06000BD4 RID: 3028
		public extern double ManningsCoefficient { get; set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000BD5 RID: 3029
		// (set) Token: 0x06000BD6 RID: 3030
		public extern double RunoffCoefficient { get; set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000BD7 RID: 3031
		// (set) Token: 0x06000BD8 RID: 3032
		public extern ObjectId ReferenceSurfaceId { get; set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000BD9 RID: 3033
		public extern string ReferenceSurfaceName { get; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000BDA RID: 3034
		public extern string ReferencePipeNetworkStructureName { get; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000BDB RID: 3035
		// (set) Token: 0x06000BDC RID: 3036
		public extern ObjectId ReferencePipeNetworkStructureId { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000BDD RID: 3037
		// (set) Token: 0x06000BDE RID: 3038
		public extern ObjectId ReferencePipeNetworkId { get; set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000BDF RID: 3039
		public extern string ReferencePipeNetworkName { get; }
	}
}
