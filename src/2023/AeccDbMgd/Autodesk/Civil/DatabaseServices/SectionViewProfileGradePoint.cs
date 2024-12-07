using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000951 RID: 2385
	public sealed class SectionViewProfileGradePoint
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001220 RID: 4640
		public extern ObjectId AlignmentId { get; }

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001221 RID: 4641
		// (set) Token: 0x06001222 RID: 4642
		public extern bool IsShow { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001223 RID: 4643
		// (set) Token: 0x06001224 RID: 4644
		public extern ObjectId ProfileId { get; set; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001225 RID: 4645
		// (set) Token: 0x06001226 RID: 4646
		public extern ObjectId MarkerStyleId { get; set; }

		// Token: 0x0400134F RID: 4943
		private int <SyntheticNonEmptyStructMarker>;
	}
}
