using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012AB RID: 4779
	public class AttributeTypeInfoInt : AttributeTypeInfo
	{
		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x060029FF RID: 10751
		// (set) Token: 0x06002A00 RID: 10752
		public new extern int DefaultValue { get; set; }

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06002A01 RID: 10753
		// (set) Token: 0x06002A02 RID: 10754
		public extern bool UpperBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06002A03 RID: 10755
		// (set) Token: 0x06002A04 RID: 10756
		public extern bool LowerBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06002A05 RID: 10757
		// (set) Token: 0x06002A06 RID: 10758
		public extern int UpperBoundValue { get; set; }

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06002A07 RID: 10759
		// (set) Token: 0x06002A08 RID: 10760
		public extern int LowerBoundValue { get; set; }

		// Token: 0x06002A09 RID: 10761
		public extern AttributeTypeInfoInt(string name);

		// Token: 0x06002A0A RID: 10762
		protected override extern object getValidDefaultValue(object defaultValue);

		// Token: 0x04001BED RID: 7149
		private int <SyntheticNonEmptyStructMarker>;
	}
}
