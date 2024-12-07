using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000887 RID: 2183
	internal class AttributeTypeInfoDoubleHelper : DisposableWrapper
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060010AB RID: 4267
		// (set) Token: 0x060010AC RID: 4268
		public extern double Min { get; set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060010AD RID: 4269
		// (set) Token: 0x060010AE RID: 4270
		public extern double Max { get; set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060010AF RID: 4271
		// (set) Token: 0x060010B0 RID: 4272
		public extern bool MinInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060010B1 RID: 4273
		// (set) Token: 0x060010B2 RID: 4274
		public extern bool MaxInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060010B3 RID: 4275
		public unsafe extern AttributeTypeInfoDoubleHelper(AeccAttributeTypeInfoDouble* pTypeInfoDouble, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x060010B4 RID: 4276
		public override extern void DeleteUnmanagedObject();
	}
}
