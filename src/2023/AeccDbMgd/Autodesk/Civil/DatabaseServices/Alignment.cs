using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000050 RID: 80
	[Wrapper("AeccDbAlignment")]
	public sealed class Alignment : Feature
	{
		// Token: 0x060002DF RID: 735
		public static extern ObjectId Create(CivilDocument document, string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId, AlignmentType type);

		// Token: 0x060002E0 RID: 736
		public static extern ObjectId Create(CivilDocument document, string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x060002E1 RID: 737
		public static extern ObjectId Create(CivilDocument document, string alignmentName, string siteName, string layerName, string styleName, string labelSetName);

		// Token: 0x060002E2 RID: 738
		public static extern ObjectId Create(CorridorFeatureLine corridorFeatureLine, string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId, AlignmentType alignmentType);

		// Token: 0x060002E3 RID: 739
		public static extern ObjectId Create(CivilDocument document, PolylineOptions plineOptions, string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x060002E4 RID: 740
		public static extern ObjectId Create(CivilDocument document, PolylineOptions plineOptions, string alignmentName, string siteName, string layerName, string styleName, string labelSetName);

		// Token: 0x060002E5 RID: 741
		public extern void PointLocation(double station, double offset, double tolerance, ref double easting, ref double northing, ref double Bearing);

		// Token: 0x060002E6 RID: 742
		public extern void PointLocation(double station, double offset, ref double easting, ref double northing);

		// Token: 0x060002E7 RID: 743
		public extern void StationOffset(double easting, double northing, double tolerance, ref double station, ref double offset);

		// Token: 0x060002E8 RID: 744
		public extern void StationOffset(double easting, double northing, ref double station, ref double offset);

		// Token: 0x060002E9 RID: 745
		public extern void StationOffsetAcceptOutOfRange(double easting, double northing, double tolerance, ref double station, ref double offset, ref bool outofrange);

		// Token: 0x060002EA RID: 746
		public extern void StationOffsetAcceptOutOfRange(double easting, double northing, ref double station, ref double offset, ref bool outofrange);

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002EB RID: 747
		public extern AlignmentEntityCollection Entities { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002EC RID: 748
		public extern DesignSpeedCollection DesignSpeeds { get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002ED RID: 749
		public extern StationEquationCollection StationEquations { get; }

		// Token: 0x060002EE RID: 750
		public extern void DistanceToAlignment(double stationOnThisAlignment, Alignment otherAlignment, AlignmentSide enumSide, ref double distanceToOtherAlignment, ref double stationOnOtherAlignment);

		// Token: 0x060002EF RID: 751
		public extern void DistanceToAlignment(double stationOnThisAlignment, Alignment otherAlignment, ref double distanceToOtherAlignment, ref double stationOnOtherAlignment);

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002F0 RID: 752
		public extern double StartingStation { get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002F1 RID: 753
		public extern double EndingStation { get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002F2 RID: 754
		public extern double EndingStationWithEquations { get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F3 RID: 755
		// (set) Token: 0x060002F4 RID: 756
		public extern bool UseDesignCheckSet { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002F5 RID: 757
		// (set) Token: 0x060002F6 RID: 758
		public extern ObjectId DesignCheckSetId { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002F7 RID: 759
		// (set) Token: 0x060002F8 RID: 760
		public extern string DesignCheckSetName { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002F9 RID: 761
		// (set) Token: 0x060002FA RID: 762
		public extern bool UseDesignCriteriaFile { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002FB RID: 763
		// (set) Token: 0x060002FC RID: 764
		public extern string CriteriaFileName { get; set; }

		// Token: 0x060002FD RID: 765
		public extern Station[] GetStationSet(StationTypes stationType);

		// Token: 0x060002FE RID: 766
		public extern Station[] GetStationSet(StationTypes stationType, double interval);

		// Token: 0x060002FF RID: 767
		public extern Station[] GetStationSet(StationTypes stationType, double majorInterval, double minorInterval);

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		public extern bool UseDesignSpeed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000302 RID: 770
		public extern double Length { get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000303 RID: 771
		public extern bool IsSiteless { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000304 RID: 772
		public extern ObjectId SiteId { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000305 RID: 773
		public extern string SiteName { get; }

		// Token: 0x06000306 RID: 774
		public extern void CopyToSite(string siteName);

		// Token: 0x06000307 RID: 775
		public extern void CopyToSite(ObjectId siteId);

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000308 RID: 776
		// (set) Token: 0x06000309 RID: 777
		public extern Point2d ReferencePoint { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600030A RID: 778
		// (set) Token: 0x0600030B RID: 779
		public extern double ReferencePointStation { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600030C RID: 780
		// (set) Token: 0x0600030D RID: 781
		public extern double StationIndexIncrement { get; set; }

		// Token: 0x170000D1 RID: 209
		// (set) Token: 0x0600030E RID: 782
		public override extern string StyleName { set; }

		// Token: 0x170000D0 RID: 208
		// (set) Token: 0x0600030F RID: 783
		public override extern ObjectId StyleId { set; }

		// Token: 0x06000310 RID: 784
		public extern ObjectIdCollection GetProfileIds();

		// Token: 0x06000311 RID: 785
		public extern ObjectIdCollection GetProfileViewIds();

		// Token: 0x06000312 RID: 786
		public extern ObjectIdCollection GetSuperelevationViewIds();

		// Token: 0x06000313 RID: 787
		public extern ObjectIdCollection GetSampleLineGroupIds();

		// Token: 0x06000314 RID: 788
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Alignment.GetAlignmentLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern ObjectIdCollection GetLabelGroupIds();

		// Token: 0x06000315 RID: 789
		public extern ObjectIdCollection GetAlignmentLabelGroupIds();

		// Token: 0x06000316 RID: 790
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Alignment.GetAlignmentLabelIds instead.", false)]
		public extern ObjectIdCollection GetLabelIds();

		// Token: 0x06000317 RID: 791
		public extern ObjectIdCollection GetAlignmentLabelIds();

		// Token: 0x06000318 RID: 792
		public extern ObjectId GetPolyline();

		// Token: 0x06000319 RID: 793
		public extern void ImportLabelSet(string labelSetStyleName);

		// Token: 0x0600031A RID: 794
		public extern void ImportLabelSet(ObjectId labelSetStyleId);

		// Token: 0x0600031B RID: 795
		public extern double GetInstantaneousRadius(double rawStation);

		// Token: 0x0600031C RID: 796
		public static extern ObjectId CreateOffsetAlignment(Database database, string alignmentName, string parentAlignmentName, double offset, string styleName, double startStation, double endStation);

		// Token: 0x0600031D RID: 797
		public static extern ObjectId CreateOffsetAlignment(Database database, string alignmentName, string parentAlignmentName, double offset, string styleName);

		// Token: 0x0600031E RID: 798
		public static extern ObjectId CreateOffsetAlignment(string alignmentName, ObjectId parentAlignmentId, double offset, ObjectId styleId, double startStation, double endStation);

		// Token: 0x0600031F RID: 799
		public static extern ObjectId CreateOffsetAlignment(string alignmentName, ObjectId parentAlignmentId, double offset, ObjectId styleId);

		// Token: 0x06000320 RID: 800
		[Obsolete("Use static method Autodesk.Civil.DatabaseServices.Alignment.CreateOffsetAlignment(...) instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern ObjectId CreateOffsetAlignment(double offsetDistance);

		// Token: 0x06000321 RID: 801
		public extern void Reverse();

		// Token: 0x06000322 RID: 802
		public extern string GetStationStringWithEquations(double rawStation);

		// Token: 0x06000323 RID: 803
		public static extern string GetNextUniqueName(string alignmentName);

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000324 RID: 804
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Alignment.OffsetAlignmentInfo.UpdateMode instead.", false)]
		public extern AlignmentUpdateType UpdateMode { get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000325 RID: 805
		public extern AlignmentType AlignmentType { get; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000326 RID: 806
		public extern SuperelevationType SuperelevationType { get; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000327 RID: 807
		public extern AlignmentCreationType CreationMode { get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000328 RID: 808
		public extern RailAlignmentInfo RailAlignmentInfo { get; }

		// Token: 0x06000329 RID: 809
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Alignment.OffsetAlignmentInfo.Regions instead.", false)]
		public extern AlignmentRegionCollection GetRegions();

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600032A RID: 810
		public extern OffsetAlignmentInfo OffsetAlignmentInfo { get; }

		// Token: 0x0600032B RID: 811
		public extern void Update();

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600032C RID: 812
		public extern bool IsOffsetAlignment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600032D RID: 813
		public extern bool HasRoundabout { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600032E RID: 814
		public extern bool IsConnectedAlignment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600032F RID: 815
		public extern ConnectedAlignmentInfo ConnectedAlignmentInfo { get; }

		// Token: 0x06000330 RID: 816
		public extern ObjectIdCollection GetChildOffsetAlignmentIds([MarshalAs(UnmanagedType.U1)] bool onlyDynamicUpdate);

		// Token: 0x06000331 RID: 817
		public extern ObjectIdCollection GetChildOffsetAlignmentIds();

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000332 RID: 818
		public extern SuperelevationCurveCollection SuperelevationCurves { get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000333 RID: 819
		public extern SuperelevationCriticalStationCollection SuperelevationCriticalStations { get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000334 RID: 820
		public extern CANTCurveCollection CANTCurves { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000335 RID: 821
		public extern CANTCriticalStationCollection CANTCriticalStaitons { get; }

		// Token: 0x06000336 RID: 822
		public extern double GetCrossSlopeAtStation(double station, SuperelevationCrossSegmentType crossSegmentType, [MarshalAs(UnmanagedType.U1)] bool applySmoothing);

		// Token: 0x06000337 RID: 823
		public static extern ObjectId CreateConnectedAlignment(string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId, ConnectedAlignmentParams connectedAlignmentParams);
	}
}
