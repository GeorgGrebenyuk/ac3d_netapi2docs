using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000061 RID: 97
	[Wrapper("AeccDbGraphCrossSection")]
	public class SectionView : Graph
	{
		// Token: 0x06000435 RID: 1077
		public static extern ObjectId Create(string sectionViewName, ObjectId sampleLineId, Point3d location);

		// Token: 0x17000165 RID: 357
		// (set) Token: 0x06000436 RID: 1078
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000437 RID: 1079
		[Obsolete("Use SectionView.SampleLineId instead", false)]
		[DeprecatedVersion(CivilVersion.Civil2020)]
		public extern ObjectId ParentEntityId { get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000438 RID: 1080
		public extern ObjectId SampleLineId { get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000439 RID: 1081
		public extern string SectionViewGroupName { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600043A RID: 1082
		public extern SectionViewBandSet Bands { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600043B RID: 1083
		public extern SectionViewProfileGradePointCollection ProfileGradePoints { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600043C RID: 1084
		public extern SectionViewVolumeTableGroup VolumeTables { get; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600043D RID: 1085
		// (set) Token: 0x0600043E RID: 1086
		public extern bool IsElevationRangeAutomatic { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600043F RID: 1087
		// (set) Token: 0x06000440 RID: 1088
		public extern double ElevationMin { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000441 RID: 1089
		// (set) Token: 0x06000442 RID: 1090
		public extern double ElevationMax { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000443 RID: 1091
		// (set) Token: 0x06000444 RID: 1092
		public extern bool IsOffsetRangeAutomatic { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000445 RID: 1093
		// (set) Token: 0x06000446 RID: 1094
		public extern double OffsetLeft { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000447 RID: 1095
		// (set) Token: 0x06000448 RID: 1096
		public extern double OffsetRight { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000449 RID: 1097
		public extern SectionOverrideCollection GraphOverrides { get; }

		// Token: 0x0600044A RID: 1098
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool FindOffsetAndElevationAtXY(double x, double y, ref double offset, ref double elevation);

		// Token: 0x0600044B RID: 1099
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool FindXYAtOffsetAndElevation(double offset, double elevation, ref double x, ref double y);

		// Token: 0x0600044C RID: 1100
		public extern ObjectIdCollection GetSectionViewDepthLabelIds();

		// Token: 0x0600044D RID: 1101
		public extern ObjectIdCollection GetSectionViewOffsetElevationLabelIds();

		// Token: 0x0600044E RID: 1102
		public extern ObjectIdCollection GetSectionProjectionLabelIds();

		// Token: 0x0600044F RID: 1103
		public extern ObjectIdCollection GetSectionCrossingLabelIds();

		// Token: 0x06000450 RID: 1104
		public extern ObjectIdCollection GetPipeSectionLabelIds();

		// Token: 0x06000451 RID: 1105
		public extern ObjectIdCollection GetStructureSectionLabelIds();

		// Token: 0x06000452 RID: 1106
		public extern ObjectIdCollection GetSectionOffsetLabelGroupIds();

		// Token: 0x06000453 RID: 1107
		public extern ObjectIdCollection GetSectionMinorOffsetLabelGroupIds();

		// Token: 0x06000454 RID: 1108
		public extern ObjectIdCollection GetSectionSegmentLabelGroupIds();

		// Token: 0x06000455 RID: 1109
		public extern ObjectIdCollection GetSectionGradeBreakLabelGroupIds();

		// Token: 0x06000456 RID: 1110
		public extern ObjectIdCollection GetSectionCorridorPointLabelGroupIds();

		// Token: 0x06000457 RID: 1111
		public extern SectionViewGroup GetSectionViewGroup();

		// Token: 0x06000458 RID: 1112
		protected internal extern SectionView(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
