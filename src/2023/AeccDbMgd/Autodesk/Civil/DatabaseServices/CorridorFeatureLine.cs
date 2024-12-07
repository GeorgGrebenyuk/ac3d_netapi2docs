using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BBB RID: 3003
	public sealed class CorridorFeatureLine : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060016B0 RID: 5808
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060016B1 RID: 5809
		public extern string CodeName { get; }

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060016B2 RID: 5810
		public extern FeatureLinePointCollection FeatureLinePoints { get; }

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060016B3 RID: 5811
		// (set) Token: 0x060016B4 RID: 5812
		public extern ObjectId StyleId { get; set; }

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060016B5 RID: 5813
		// (set) Token: 0x060016B6 RID: 5814
		public extern string StyleName { get; set; }

		// Token: 0x060016B7 RID: 5815
		[Obsolete("Use Autodesk.Civil.DatabaseServices.CorridorFeatureLine.ExportAsPolyline3dCollection instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern ObjectId ExportAsPolyline3d();

		// Token: 0x060016B8 RID: 5816
		public extern ObjectIdCollection ExportAsPolyline3dCollection();

		// Token: 0x060016B9 RID: 5817
		public extern ObjectId ExportAsGradingFeatureLine(ObjectId siteId, [MarshalAs(UnmanagedType.U1)] bool isDynamic, string featureLineName, ObjectId layerId, ObjectId styleId, GradingSmoothOption smoothOption);

		// Token: 0x060016BA RID: 5818
		public extern ObjectId ExportAsGradingFeatureLine(ObjectId siteId, [MarshalAs(UnmanagedType.U1)] bool isDynamic);

		// Token: 0x060016BB RID: 5819
		public extern ObjectId ExportAsAlignment(string alignmentName, ObjectId siteId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId, AlignmentType alignmentType);

		// Token: 0x060016BC RID: 5820
		public extern ObjectId ExportAsProfile(string profileName, ObjectId alignmentId, ObjectId layerId, ObjectId styleId, ObjectId labelSetId);

		// Token: 0x04001543 RID: 5443
		private int <SyntheticNonEmptyStructMarker>;
	}
}
