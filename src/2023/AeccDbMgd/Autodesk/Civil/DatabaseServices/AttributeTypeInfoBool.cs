using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012A9 RID: 4777
	public class AttributeTypeInfoBool : AttributeTypeInfo
	{
		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x060029F1 RID: 10737
		// (set) Token: 0x060029F2 RID: 10738
		public new extern bool DefaultValue { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060029F3 RID: 10739
		public extern AttributeTypeInfoBool(string name);

		// Token: 0x060029F4 RID: 10740
		protected override extern object getValidDefaultValue(object defaultValue);
	}
}
