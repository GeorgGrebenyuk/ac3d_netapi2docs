using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C7 RID: 199
	[Wrapper("AeccDbStructure")]
	public sealed class Structure : Part
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600092F RID: 2351
		public extern ObjectId ConnectedPipe { get; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000930 RID: 2352
		public extern int ConnectedPipesCount { get; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000931 RID: 2353
		// (set) Token: 0x06000932 RID: 2354
		public extern StructureControlSumpType ControlSumpBy { get; set; }

		// Token: 0x06000933 RID: 2355
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ResizeByPipeDepths();

		// Token: 0x06000934 RID: 2356
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsConnectedPipeFlowingIn(int index);

		// Token: 0x06000935 RID: 2357
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsConnectedPipeFlowingOut(int index);

		// Token: 0x06000936 RID: 2358
		public extern void ConnectToPipe(ObjectId pipeId, ConnectorPositionType positionType);

		// Token: 0x06000937 RID: 2359
		public extern void Disconnect(ObjectId pipeId);

		// Token: 0x06000938 RID: 2360
		public extern void ResizeJunctionStructure(string partFamilyGuid, double rimElevation, double sumpElevation);

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000939 RID: 2361
		// (set) Token: 0x0600093A RID: 2362
		public extern double Rotation { get; set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600093B RID: 2363
		public extern BoundingShapeType BoundingShape { get; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600093C RID: 2364
		public extern double PipeWallThickness { get; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600093D RID: 2365
		public extern double PipeInnerDiameterOrWidth { get; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600093E RID: 2366
		public extern double PipeCenterDepth { get; }

		// Token: 0x0600093F RID: 2367
		public extern string[] GetConnectedPipeNames();

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000940 RID: 2368
		public extern double PipeInvertDepth { get; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000941 RID: 2369
		public extern double PipeOuterBottomDepth { get; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000942 RID: 2370
		public extern double PipeOuterTopDepth { get; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000943 RID: 2371
		public extern double PipeLowestBottomDepth { get; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000944 RID: 2372
		public extern double PipeUpperTopDepth { get; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000945 RID: 2373
		public extern double DiameterOrWidth { get; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000946 RID: 2374
		public extern double InnerDiameterOrWidth { get; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000947 RID: 2375
		public extern double Length { get; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000948 RID: 2376
		public extern double InnerLength { get; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000949 RID: 2377
		public extern double Height { get; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600094A RID: 2378
		// (set) Token: 0x0600094B RID: 2379
		public extern double SumpElevation { get; set; }

		// Token: 0x0600094C RID: 2380
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsPointInsideStructureRegion(Point3d point);

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600094D RID: 2381
		// (set) Token: 0x0600094E RID: 2382
		public extern double SurfaceAdjustmentValue { get; set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600094F RID: 2383
		// (set) Token: 0x06000950 RID: 2384
		public extern bool AutomaticRimSurfaceAdjustment { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000951 RID: 2385
		// (set) Token: 0x06000952 RID: 2386
		public extern double SumpDepth { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000953 RID: 2387
		// (set) Token: 0x06000954 RID: 2388
		public extern double RimElevation { get; set; }

		// Token: 0x06000955 RID: 2389
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Structure.GetAvailableStructureLabelIds instead.", false)]
		public extern ObjectIdCollection GetLabelIds();

		// Token: 0x06000956 RID: 2390
		public extern ObjectIdCollection GetAvailableStructureLabelIds();

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000957 RID: 2391
		public extern double SurfaceElevationAtInsertionPoint { get; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000958 RID: 2392
		public extern double Offset { get; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000959 RID: 2393
		public extern double Station { get; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600095A RID: 2394
		// (set) Token: 0x0600095B RID: 2395
		public extern double Northing { get; set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600095C RID: 2396
		// (set) Token: 0x0600095D RID: 2397
		public extern double Easting { get; set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600095E RID: 2398
		public extern double VerticalPipeClearance { get; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600095F RID: 2399
		// (set) Token: 0x06000960 RID: 2400
		public extern double RimToSumpHeight { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000961 RID: 2401
		public extern double FloorThickness { get; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000962 RID: 2402
		public extern string Frame { get; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000963 RID: 2403
		public extern string Grate { get; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000964 RID: 2404
		public extern string Cover { get; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000965 RID: 2405
		public extern double FrameHeight { get; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000966 RID: 2406
		public extern double FrameDiameter { get; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000967 RID: 2407
		public extern double BarrelPipeClearance { get; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000968 RID: 2408
		public extern double ConeHeight { get; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000969 RID: 2409
		public extern double HeadwallBaseWidth { get; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600096A RID: 2410
		public extern double HeadwallBaseThickness { get; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600096B RID: 2411
		// (set) Token: 0x0600096C RID: 2412
		public extern Point3d Location { get; set; }

		// Token: 0x170003D8 RID: 984
		// (set) Token: 0x0600096D RID: 2413
		public override extern ObjectId StyleId { set; }
	}
}
