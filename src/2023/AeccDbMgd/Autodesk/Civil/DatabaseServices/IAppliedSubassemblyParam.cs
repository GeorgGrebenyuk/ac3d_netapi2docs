using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B94 RID: 2964
	public interface IAppliedSubassemblyParam
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001634 RID: 5684
		string KeyName { get; }

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001635 RID: 5685
		string DisplayName { get; }

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001636 RID: 5686
		// (set) Token: 0x06001637 RID: 5687
		string Comment { get; set; }

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001638 RID: 5688
		bool IsOverriden { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001639 RID: 5689
		Type ValueType { get; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x0600163A RID: 5690
		object DesignValueAsObject { get; }

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x0600163B RID: 5691
		object ValueAsObject { get; }

		// Token: 0x0600163C RID: 5692
		[return: MarshalAs(UnmanagedType.U1)]
		bool ClearOverride();
	}
}
