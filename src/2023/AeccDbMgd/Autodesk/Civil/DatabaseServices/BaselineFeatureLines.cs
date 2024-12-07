using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001141 RID: 4417
	public sealed class BaselineFeatureLines : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x060024A2 RID: 9378
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060024A3 RID: 9379
		public extern FeatureLineCollectionMap FeatureLineCollectionMap { get; }

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060024A4 RID: 9380
		public extern bool IsMainBaseline { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060024A5 RID: 9381
		public extern ObjectId OffsetAlignmentId { get; }

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060024A6 RID: 9382
		public extern string HardcodedOffsetBaselineName { get; }

		// Token: 0x060024A7 RID: 9383
		public extern string[] CodeNames();

		// Token: 0x04001A95 RID: 6805
		private int <SyntheticNonEmptyStructMarker>;
	}
}
