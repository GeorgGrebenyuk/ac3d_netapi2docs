using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BC8 RID: 3016
	public abstract class BaseBaseline : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060016E2 RID: 5858
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060016E3 RID: 5859
		public abstract CorridorBaselineType BaselineType { get; }

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060016E4 RID: 5860
		public abstract ObjectId AlignmentId { get; }

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060016E5 RID: 5861
		public virtual extern ObjectId FeatureLineId { get; }

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060016E6 RID: 5862
		public abstract ObjectId ProfileId { get; }

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060016E7 RID: 5863
		public virtual extern Guid baselineGUID { get; }

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060016E8 RID: 5864
		public extern double StartStation { get; }

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060016E9 RID: 5865
		public extern double EndStation { get; }

		// Token: 0x060016EA RID: 5866
		[return: MarshalAs(UnmanagedType.U1)]
		public abstract bool IsFeatureLineBased();

		// Token: 0x060016EB RID: 5867
		public extern void SetAlignmentAndProfile(ObjectId alignmentId, ObjectId profileId);

		// Token: 0x060016EC RID: 5868
		public abstract double[] SortedStations();

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060016ED RID: 5869
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.BaseBaseline.GetDirectionAtStation instead.", false)]
		public virtual extern Vector3d DirectionAtStation { get; }

		// Token: 0x060016EE RID: 5870
		public extern Vector3d GetDirectionAtStation(double station);

		// Token: 0x060016EF RID: 5871
		public virtual extern Point3d StationOffsetElevationToXYZ(Point3d soe);

		// Token: 0x060016F0 RID: 5872
		protected unsafe abstract void setAlignmentProfile(AcDbObjectId* oidAlignment, AcDbObjectId* oidProfile);

		// Token: 0x060016F1 RID: 5873
		protected unsafe virtual extern void checkAlignmentProfile(AcDbObjectId* oidAlignment, AcDbObjectId* oidProfile);

		// Token: 0x060016F2 RID: 5874
		protected abstract double getStartStation();

		// Token: 0x060016F3 RID: 5875
		protected abstract double getEndStation();
	}
}
