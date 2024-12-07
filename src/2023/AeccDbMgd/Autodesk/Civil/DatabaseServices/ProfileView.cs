using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000058 RID: 88
	[Wrapper("AeccDbGraphProfile")]
	public sealed class ProfileView : Graph
	{
		// Token: 0x17000127 RID: 295
		// (set) Token: 0x06000398 RID: 920
		public override extern string StyleName { set; }

		// Token: 0x17000126 RID: 294
		// (set) Token: 0x06000399 RID: 921
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600039A RID: 922
		public extern string AlignmentName { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600039B RID: 923
		public extern ObjectId AlignmentId { get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600039C RID: 924
		// (set) Token: 0x0600039D RID: 925
		public extern StationRangeType StationRangeMode { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600039E RID: 926
		// (set) Token: 0x0600039F RID: 927
		public extern double StationStart { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003A0 RID: 928
		// (set) Token: 0x060003A1 RID: 929
		public extern double StationEnd { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003A2 RID: 930
		// (set) Token: 0x060003A3 RID: 931
		public extern ElevationRangeType ElevationRangeMode { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003A4 RID: 932
		// (set) Token: 0x060003A5 RID: 933
		public extern double ElevationMin { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003A6 RID: 934
		// (set) Token: 0x060003A7 RID: 935
		public extern double ElevationMax { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003A8 RID: 936
		// (set) Token: 0x060003A9 RID: 937
		public extern bool SplitProfileView { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003AA RID: 938
		// (set) Token: 0x060003AB RID: 939
		public extern double SplitHeight { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003AC RID: 940
		// (set) Token: 0x060003AD RID: 941
		public extern SplitStationType SplitStationMode { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003AE RID: 942
		// (set) Token: 0x060003AF RID: 943
		public extern StationRoundingType SplitStationRounding { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003B0 RID: 944
		// (set) Token: 0x060003B1 RID: 945
		public extern DatumRoundingType SplitDatumRounding { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003B2 RID: 946
		public extern ProfileViewSplitDataCollection SplitDataLines { get; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003B3 RID: 947
		public extern ProfileOverrideCollection GraphOverrides { get; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B4 RID: 948
		public extern PipeOverrideCollection PipeOverrides { get; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003B5 RID: 949
		public extern StructureOverrideCollection StructureOverrides { get; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003B6 RID: 950
		public extern ProfileHatchAreaCollection HatchAreas { get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003B7 RID: 951
		public extern ProfileViewBandSet Bands { get; }

		// Token: 0x060003B8 RID: 952
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileView.GetProfileViewLabelIds instead.", false)]
		public extern ObjectIdCollection GetLabelIds();

		// Token: 0x060003B9 RID: 953
		public extern ObjectIdCollection GetProfileViewLabelIds();

		// Token: 0x060003BA RID: 954
		public extern ObjectIdCollection GetAvailablePipeProfileLabelIds();

		// Token: 0x060003BB RID: 955
		public extern ObjectIdCollection GetAvailableSpanningPipeProfileLabelIds();

		// Token: 0x060003BC RID: 956
		public extern ObjectIdCollection GetAvailableStructureProfileLabelIds();

		// Token: 0x060003BD RID: 957
		public extern ObjectIdCollection GetPressureNetworkPartsInGraph();

		// Token: 0x060003BE RID: 958
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool FindStationAndElevationAtXY(double x, double y, ref double station, ref double elevation);

		// Token: 0x060003BF RID: 959
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool FindXYAtStationAndElevation(double station, double elevation, ref double x, ref double y);

		// Token: 0x060003C0 RID: 960
		public static extern ObjectIdCollection Create(ObjectId alignmentId, Point3d insertPosition, StackedProfileViewsCreationOptions stackedOptions, SplitProfileViewCreationOptions splitOptions);

		// Token: 0x060003C1 RID: 961
		public static extern ObjectIdCollection Create(ObjectId alignmentId, Point3d insertPosition, StackedProfileViewsCreationOptions stackedOptions);

		// Token: 0x060003C2 RID: 962
		public static extern ObjectIdCollection Create(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, StackedProfileViewsCreationOptions stackedOptions, SplitProfileViewCreationOptions splitOptions);

		// Token: 0x060003C3 RID: 963
		public static extern ObjectIdCollection Create(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, StackedProfileViewsCreationOptions stackedOptions);

		// Token: 0x060003C4 RID: 964
		public static extern ObjectId Create(ObjectId alignmentId, Point3d insertPosition, SplitProfileViewCreationOptions splitOptions);

		// Token: 0x060003C5 RID: 965
		public static extern ObjectId Create(ObjectId alignmentId, Point3d insertPosition);

		// Token: 0x060003C6 RID: 966
		public static extern ObjectId Create(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, ObjectId profileViewStyleId, SplitProfileViewCreationOptions splitOptions);

		// Token: 0x060003C7 RID: 967
		public static extern ObjectId Create(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, ObjectId profileViewStyleId);

		// Token: 0x060003C8 RID: 968
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileView.Create(NAMESPACE_ACDB::ObjectId alignmentId, NAMESPACE_ACGE::Point3d insertPosition, System::String^ profileViewName, NAMESPACE_ACDB::ObjectId profileViewBandSetId, NAMESPACE_ACDB::ObjectId profileViewStyleId) instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectId Create(CivilDocument document, string profileViewName, ObjectId profileViewBandSetId, ObjectId alignmentId, Point3d insertPosition);

		// Token: 0x060003C9 RID: 969
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileView.Create(NAMESPACE_ACDB::ObjectId alignmentId, NAMESPACE_ACGE::Point3d insertPosition, System::String^ profileViewName, NAMESPACE_ACDB::ObjectId profileViewBandSetId, NAMESPACE_ACDB::ObjectId profileViewStyleId) instead.", false)]
		public static extern ObjectId Create(CivilDocument document, string profileViewName, string profileViewBandSetName, string alignmentName, Point3d insertPosition);

		// Token: 0x060003CA RID: 970
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, StackedProfileViewsCreationOptions stackedOptions, MultipleProfileViewsCreationOptions multipleOptions, SplitProfileViewCreationOptions splitOptions, ProfileViewDatumType datumType);

		// Token: 0x060003CB RID: 971
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, StackedProfileViewsCreationOptions stackedOptions, MultipleProfileViewsCreationOptions multipleOptions);

		// Token: 0x060003CC RID: 972
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, StackedProfileViewsCreationOptions stackedOptions, MultipleProfileViewsCreationOptions multipleOptions, SplitProfileViewCreationOptions splitOptions, ProfileViewDatumType datumType);

		// Token: 0x060003CD RID: 973
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, StackedProfileViewsCreationOptions stackedOptions, MultipleProfileViewsCreationOptions multipleOptions);

		// Token: 0x060003CE RID: 974
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, MultipleProfileViewsCreationOptions multipleOptions, SplitProfileViewCreationOptions splitOptions, ProfileViewDatumType datumType);

		// Token: 0x060003CF RID: 975
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, MultipleProfileViewsCreationOptions multipleOptions);

		// Token: 0x060003D0 RID: 976
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, ObjectId profileViewStyleId, MultipleProfileViewsCreationOptions multipleOptions, SplitProfileViewCreationOptions splitOptions, ProfileViewDatumType datumType);

		// Token: 0x060003D1 RID: 977
		public static extern ObjectIdCollection CreateMultiple(ObjectId alignmentId, Point3d insertPosition, string profileViewName, ObjectId profileViewBandSetId, ObjectId profileViewStyleId, MultipleProfileViewsCreationOptions multipleOptions);

		// Token: 0x040002F9 RID: 761
		private int <SyntheticNonEmptyStructMarker>;
	}
}
