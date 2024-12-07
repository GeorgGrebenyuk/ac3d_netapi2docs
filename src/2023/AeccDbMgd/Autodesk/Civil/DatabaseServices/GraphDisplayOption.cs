using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000725 RID: 1829
	public abstract class GraphDisplayOption : DisposableWrapper
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000E46 RID: 3654
		public virtual extern string SourceName { get; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000E47 RID: 3655
		// (set) Token: 0x06000E48 RID: 3656
		public virtual extern bool Draw { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000E49 RID: 3657
		// (set) Token: 0x06000E4A RID: 3658
		public virtual extern bool UseOverrideStyle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000E4B RID: 3659
		// (set) Token: 0x06000E4C RID: 3660
		public virtual extern string OverrideStyleName { get; set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000E4D RID: 3661
		// (set) Token: 0x06000E4E RID: 3662
		public virtual extern ObjectId OverrideStyleId { get; set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000E4F RID: 3663
		// (set) Token: 0x06000E50 RID: 3664
		public virtual extern ObjectId LabelSetId { get; set; }

		// Token: 0x06000E51 RID: 3665
		protected override extern void DeleteUnmanagedObject();
	}
}
