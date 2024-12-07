using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000886 RID: 2182
	[Wrapper("AeccAttributeTypeInfo")]
	public class AttributeTypeInfo : DisposableWrapper
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060010A1 RID: 4257
		// (set) Token: 0x060010A2 RID: 4258
		public extern string Name { get; set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060010A3 RID: 4259
		// (set) Token: 0x060010A4 RID: 4260
		public extern string Description { get; set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060010A5 RID: 4261
		// (set) Token: 0x060010A6 RID: 4262
		public extern object DefaultValue { get; set; }

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060010A7 RID: 4263
		// (set) Token: 0x060010A8 RID: 4264
		public extern bool UseDefaultValue { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060010A9 RID: 4265
		protected virtual extern object getValidDefaultValue(object defaultValue);

		// Token: 0x060010AA RID: 4266
		protected override extern void DeleteUnmanagedObject();

		// Token: 0x0400128F RID: 4751
		private int <SyntheticNonEmptyStructMarker>;
	}
}
