using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000051 RID: 81
	[Wrapper("AeccDbVAlignment")]
	public sealed class Profile : Feature
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000338 RID: 824
		public extern ObjectId AlignmentId { get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000339 RID: 825
		public extern Profile.OffsetProfileParameters OffsetParameters { get; }

		// Token: 0x170000F8 RID: 248
		// (set) Token: 0x0600033A RID: 826
		public override extern string StyleName { set; }

		// Token: 0x170000F7 RID: 247
		// (set) Token: 0x0600033B RID: 827
		public override extern ObjectId StyleId { set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600033C RID: 828
		public extern ProfileType ProfileType { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600033D RID: 829
		public extern double StartingStation { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600033E RID: 830
		public extern double EndingStation { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600033F RID: 831
		public extern double Offset { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000340 RID: 832
		public extern double Length { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000341 RID: 833
		// (set) Token: 0x06000342 RID: 834
		public extern ProfileUpdateType UpdateMode { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000343 RID: 835
		public extern ProfilePVICollection PVIs { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000344 RID: 836
		public extern ObjectId DataSourceId { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000345 RID: 837
		public extern string DataSourceName { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000346 RID: 838
		public extern double ElevationMin { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000347 RID: 839
		public extern double ElevationMax { get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000348 RID: 840
		// (set) Token: 0x06000349 RID: 841
		public extern bool Plinegen { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600034A RID: 842
		public extern ProfileEntityCollection Entities { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600034B RID: 843
		// (set) Token: 0x0600034C RID: 844
		public extern bool DesignSpeedBased { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600034D RID: 845
		// (set) Token: 0x0600034E RID: 846
		public extern bool UseDesignCriteriaFile { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600034F RID: 847
		// (set) Token: 0x06000350 RID: 848
		public extern bool UseDesignCheckSet { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000351 RID: 849
		// (set) Token: 0x06000352 RID: 850
		public extern ObjectId DesignCheckSetId { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000353 RID: 851
		// (set) Token: 0x06000354 RID: 852
		public extern string DesignCheckSetName { get; set; }

		// Token: 0x06000355 RID: 853
		public extern double ElevationAt(double station);

		// Token: 0x06000356 RID: 854
		public extern double GradeAt(double station);

		// Token: 0x06000357 RID: 855
		public static extern ObjectId CreateByLayout(string profileName, CivilDocument document, string alignmentName, string layerName, string styleName, string labelSetName);

		// Token: 0x06000358 RID: 856
		public static extern ObjectId CreateByLayout(string profileName, ObjectId alignmentId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x06000359 RID: 857
		public static extern ObjectId CreateFromSurface(string profileName, CivilDocument document, string alignmentName, string surfaceName, string layerName, string styleName, string labelSetName);

		// Token: 0x0600035A RID: 858
		public static extern ObjectId CreateFromSurface(string profileName, CivilDocument document, string alignmentName, string surfaceName, string layerName, string styleName, string labelSetName, double offset, double sampleStart, double sampleEnd);

		// Token: 0x0600035B RID: 859
		public static extern ObjectId CreateFromSurface(string profileName, ObjectId alignmentId, ObjectId surfaceId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x0600035C RID: 860
		public static extern ObjectId CreateFromSurface(string profileName, ObjectId alignmentId, ObjectId surfaceId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId, double offset, double sampleStart, double sampleEnd);

		// Token: 0x0600035D RID: 861
		public static extern ObjectId CreateFromFeatureLine(string profileName, CorridorFeatureLine corridorFeatureLine, ObjectId alignmentId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x0600035E RID: 862
		public static extern ObjectId CreateStaticFGFromProfile(string profileName, CivilDocument document, string srcProfileName, string layerName, string styleName, string labelSetName);

		// Token: 0x0600035F RID: 863
		public static extern ObjectId CreateStaticFGFromProfile(string profileName, ObjectId profileId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x06000360 RID: 864
		public extern ObjectId CreateOffsetProfileBySlope(string profileName, string offsetAlignmentName, string styleName, double slope);

		// Token: 0x06000361 RID: 865
		public extern ObjectId CreateOffsetProfileBySlope(string profileName, ObjectId offsetAlignmentId, ObjectId profileStyleId, double slope);

		// Token: 0x040002F3 RID: 755
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x02000052 RID: 82
		public class OffsetProfileParametersStation : IComparable<Profile.OffsetProfileParametersStation>
		{
			// Token: 0x06000362 RID: 866
			public extern OffsetProfileParametersStation(double station, double slope, string description);

			// Token: 0x06000363 RID: 867
			public extern OffsetProfileParametersStation(double station, double slope);

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000365 RID: 869
			// (set) Token: 0x06000364 RID: 868
			public extern double Station { get; set; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000367 RID: 871
			// (set) Token: 0x06000366 RID: 870
			public extern double Slope { get; set; }

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000369 RID: 873
			// (set) Token: 0x06000368 RID: 872
			public extern string Description { get; set; }

			// Token: 0x0600036A RID: 874
			public virtual extern int CompareTo(Profile.OffsetProfileParametersStation other);

			// Token: 0x040002F4 RID: 756
			private int <SyntheticNonEmptyStructMarker>;
		}

		// Token: 0x02000053 RID: 83
		public class OffsetProfileParameters
		{
			// Token: 0x0600036B RID: 875
			public extern OffsetProfileParameters(Profile owningProfile);

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600036D RID: 877
			// (set) Token: 0x0600036C RID: 876
			public extern List<Profile.OffsetProfileParametersStation> Stations { get; set; }

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600036E RID: 878
			public extern ObjectId ParentAlignmentId { get; }

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x0600036F RID: 879
			public extern ObjectId ParentProfileId { get; }

			// Token: 0x040002F5 RID: 757
			private int <SyntheticNonEmptyStructMarker>;
		}
	}
}
