using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008D9 RID: 2265
	public abstract class GraphOverride : CivilWrapper<AeccDbGraph>
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600115C RID: 4444
		// (set) Token: 0x0600115D RID: 4445
		public virtual extern bool Draw { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600115E RID: 4446
		// (set) Token: 0x0600115F RID: 4447
		public extern bool UseOverrideStyle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001160 RID: 4448
		// (set) Token: 0x06001161 RID: 4449
		public virtual extern string OverrideStyleName { get; set; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001162 RID: 4450
		// (set) Token: 0x06001163 RID: 4451
		public virtual extern ObjectId OverrideStyleId { get; set; }

		// Token: 0x06001164 RID: 4452
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040012E7 RID: 4839
		protected unsafe AeccDbTreeOid* m_pDataLineId;
	}
}
