using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200090A RID: 2314
	public class SectionViewGroupCreationRangeOptions : IDisposable
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060011B6 RID: 4534
		// (set) Token: 0x060011B7 RID: 4535
		public extern bool UseUserSpecifiedOffset { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060011B8 RID: 4536
		public extern double LeftOffset { get; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060011B9 RID: 4537
		public extern double RightOffset { get; }

		// Token: 0x060011BA RID: 4538
		public extern void SetOffsetRange(double leftOffset, double rightOffset);

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060011BB RID: 4539
		// (set) Token: 0x060011BC RID: 4540
		public extern bool UseUserSpecifiedElevation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060011BD RID: 4541
		// (set) Token: 0x060011BE RID: 4542
		public extern double Elevation { get; set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060011BF RID: 4543
		// (set) Token: 0x060011C0 RID: 4544
		public extern SectionViewElevationRangeType ElevationRangeType { get; set; }

		// Token: 0x060011C1 RID: 4545
		public extern void FollowSection(SectionSource sectionSource);

		// Token: 0x060011C2 RID: 4546
		public extern SectionViewGroupCreationRangeOptions(ObjectId sampleLineGroupId);

		// Token: 0x060011C3 RID: 4547
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060011C4 RID: 4548
		public sealed extern void Dispose();

		// Token: 0x060011C5 RID: 4549
		protected override extern void Finalize();

		// Token: 0x04001312 RID: 4882
		private int <SyntheticNonEmptyStructMarker>;
	}
}
