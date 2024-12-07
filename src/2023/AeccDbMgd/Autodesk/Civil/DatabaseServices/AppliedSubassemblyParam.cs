using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B95 RID: 2965
	public sealed class AppliedSubassemblyParam<T> : IAppliedSubassemblyParam
	{
		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600163D RID: 5693
		public extern string KeyName { get; }

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600163E RID: 5694
		public extern string DisplayName { get; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600163F RID: 5695
		// (set) Token: 0x06001640 RID: 5696
		public extern string Comment { get; set; }

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001641 RID: 5697
		public extern bool IsOverriden { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001642 RID: 5698
		public extern Type ValueType { get; }

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001643 RID: 5699
		public extern object DesignValueAsObject { get; }

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001644 RID: 5700
		public extern object ValueAsObject { get; }

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001645 RID: 5701
		public extern T DesignValue { get; }

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001646 RID: 5702
		// (set) Token: 0x06001647 RID: 5703
		public extern T Value { get; set; }

		// Token: 0x06001648 RID: 5704
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ClearOverride();

		// Token: 0x0400151A RID: 5402
		private int <SyntheticNonEmptyStructMarker>;
	}
}
