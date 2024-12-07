using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012AA RID: 4778
	internal class AttributeTypeInfoIntHelper : DisposableWrapper
	{
		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x060029F5 RID: 10741
		// (set) Token: 0x060029F6 RID: 10742
		public extern int Min { get; set; }

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x060029F7 RID: 10743
		// (set) Token: 0x060029F8 RID: 10744
		public extern int Max { get; set; }

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x060029F9 RID: 10745
		// (set) Token: 0x060029FA RID: 10746
		public extern bool MinInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x060029FB RID: 10747
		// (set) Token: 0x060029FC RID: 10748
		public extern bool MaxInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060029FD RID: 10749
		public unsafe extern AttributeTypeInfoIntHelper(AeccAttributeTypeInfoInt* pTypeInfoInt, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x060029FE RID: 10750
		public override extern void DeleteUnmanagedObject();
	}
}
