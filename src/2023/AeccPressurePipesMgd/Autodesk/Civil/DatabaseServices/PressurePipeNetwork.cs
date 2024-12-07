using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000003 RID: 3
	[Wrapper("AeccDbPressurePipeNetwork")]
	public sealed class PressurePipeNetwork : GeoEntity
	{
		// Token: 0x06000003 RID: 3
		public static extern ObjectId Create(Database database, string networkName);

		// Token: 0x06000004 RID: 4
		public extern ObjectIdCollection GetPipeIds();

		// Token: 0x06000005 RID: 5
		public extern ObjectIdCollection GetFittingIds();

		// Token: 0x06000006 RID: 6
		public extern ObjectIdCollection GetAppurtenanceIds();

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000007 RID: 7
		public extern bool IsEmpty { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000008 RID: 8
		public extern bool HasPipeRun { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000009 RID: 9
		// (set) Token: 0x0600000A RID: 10
		public extern ObjectId PipePlanLabelStyleId { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600000B RID: 11
		// (set) Token: 0x0600000C RID: 12
		public extern string PipePlanLabelStyleName { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600000D RID: 13
		// (set) Token: 0x0600000E RID: 14
		public extern ObjectId FittingPlanLabelStyleId { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600000F RID: 15
		// (set) Token: 0x06000010 RID: 16
		public extern string FittingPlanLabelStyleName { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000011 RID: 17
		// (set) Token: 0x06000012 RID: 18
		public extern ObjectId AppurtenancePlanLabelStyleId { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000013 RID: 19
		// (set) Token: 0x06000014 RID: 20
		public extern string AppurtenancePlanLabelStyleName { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000015 RID: 21
		// (set) Token: 0x06000016 RID: 22
		public extern ObjectId PipeProfileLabelStyleId { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000017 RID: 23
		// (set) Token: 0x06000018 RID: 24
		public extern string PipeProfileLabelStyleName { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000019 RID: 25
		// (set) Token: 0x0600001A RID: 26
		public extern ObjectId FittingProfileLabelStyleId { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600001B RID: 27
		// (set) Token: 0x0600001C RID: 28
		public extern string FittingProfileLabelStyleName { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600001D RID: 29
		// (set) Token: 0x0600001E RID: 30
		public extern ObjectId AppurtenanceProfileLabelStyleId { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600001F RID: 31
		// (set) Token: 0x06000020 RID: 32
		public extern string AppurtenanceProfileLabelStyleName { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000021 RID: 33
		// (set) Token: 0x06000022 RID: 34
		public extern ObjectId CrossingPressurePipeProfileLabelStyleId { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000023 RID: 35
		// (set) Token: 0x06000024 RID: 36
		public extern string CrossingPressurePipeProfileLabelStyleName { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000025 RID: 37
		// (set) Token: 0x06000026 RID: 38
		[DeprecatedVersion(CivilVersion.Civil2020)]
		[Obsolete("Is not used", false)]
		public extern ObjectId PipeSectionLabelStyleId { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000027 RID: 39
		// (set) Token: 0x06000028 RID: 40
		[Obsolete("Is not used", false)]
		[DeprecatedVersion(CivilVersion.Civil2020)]
		public extern string PipeSectionLabelStyleName { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000029 RID: 41
		// (set) Token: 0x0600002A RID: 42
		public extern ObjectId PipePlanLayerId { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600002B RID: 43
		public extern string ModifiedPipePlanLayerName { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600002C RID: 44
		// (set) Token: 0x0600002D RID: 45
		public extern string PipePlanLayerName { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600002E RID: 46
		// (set) Token: 0x0600002F RID: 47
		public extern ObjectId FittingPlanLayerId { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000030 RID: 48
		public extern string ModifiedFittingPlanLayerName { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000031 RID: 49
		// (set) Token: 0x06000032 RID: 50
		public extern string FittingPlanLayerName { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000033 RID: 51
		// (set) Token: 0x06000034 RID: 52
		public extern ObjectId AppurtenancePlanLayerId { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000035 RID: 53
		public extern string ModifiedAppurtenancePlanLayerName { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54
		// (set) Token: 0x06000037 RID: 55
		public extern string AppurtenancePlanLayerName { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56
		// (set) Token: 0x06000039 RID: 57
		public extern ObjectId PipeProfileLayerId { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003A RID: 58
		public extern string ModifiedPipeProfileLayerName { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003B RID: 59
		// (set) Token: 0x0600003C RID: 60
		public extern string PipeProfileLayerName { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		public extern ObjectId FittingProfileLayerId { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003F RID: 63
		public extern string ModifiedFittingProfileLayerName { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		public extern string FittingProfileLayerName { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66
		// (set) Token: 0x06000043 RID: 67
		public extern ObjectId AppurtenanceProfileLayerId { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68
		public extern string ModifiedAppurtenanceProfileLayerName { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000045 RID: 69
		// (set) Token: 0x06000046 RID: 70
		public extern string AppurtenanceProfileLayerName { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71
		// (set) Token: 0x06000048 RID: 72
		public extern ObjectId PipeSectionLayerId { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73
		public extern string ModifiedPipeSectionLayerName { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74
		// (set) Token: 0x0600004B RID: 75
		public extern string PipeSectionLayerName { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004C RID: 76
		// (set) Token: 0x0600004D RID: 77
		public extern string PipeNameTemplate { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004E RID: 78
		// (set) Token: 0x0600004F RID: 79
		public extern string FittingNameTemplate { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80
		// (set) Token: 0x06000051 RID: 81
		public extern string AppurtenanceNameTemplate { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82
		// (set) Token: 0x06000053 RID: 83
		public extern string PipeRunNameTemplate { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000054 RID: 84
		// (set) Token: 0x06000055 RID: 85
		public extern ObjectId ReferenceSurfaceId { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000056 RID: 86
		// (set) Token: 0x06000057 RID: 87
		public extern string ReferenceSurfaceName { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000058 RID: 88
		// (set) Token: 0x06000059 RID: 89
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005A RID: 90
		// (set) Token: 0x0600005B RID: 91
		public extern string ReferenceAlignmentName { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005C RID: 92
		// (set) Token: 0x0600005D RID: 93
		[Obsolete("Use PartsListId instead", false)]
		[DeprecatedVersion(CivilVersion.Civil2020)]
		public extern ObjectId CurrentPartListId { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005E RID: 94
		// (set) Token: 0x0600005F RID: 95
		public extern ObjectId PartsListId { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000060 RID: 96
		public extern double MaximumElevation { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97
		public extern double MinimumElevation { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000062 RID: 98
		// (set) Token: 0x06000063 RID: 99
		public extern string PartsListName { get; set; }

		// Token: 0x06000064 RID: 100
		public extern void AddPipe(ObjectId pipeId);

		// Token: 0x06000065 RID: 101
		public extern ObjectId AddLinePipe(LineSegment3d line, PressurePartSize partSize);

		// Token: 0x06000066 RID: 102
		public extern ObjectId AddCurvePipe(Point3d startPoint, Point3d secondPoint, Point3d endPoint, PressurePartSize partSize);

		// Token: 0x06000067 RID: 103
		public extern ObjectId AddCurvePipe(Point3d startPoint, Vector2d startDir, Point3d endPoint, PressurePartSize partSize);

		// Token: 0x06000068 RID: 104
		public extern ObjectId AddFitting(Point3d location, PressurePartSize partSize);

		// Token: 0x06000069 RID: 105
		public extern void AddFitting(ObjectId fittingId);

		// Token: 0x0600006A RID: 106
		public extern ObjectId AddAppurtenance(Point3d location, PressurePartSize partSize);

		// Token: 0x0600006B RID: 107
		public extern void AddAppurtenance(ObjectId appurtenanceId);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600006C RID: 108
		public extern PressurePipeRunCollection PipeRuns { get; }
	}
}
