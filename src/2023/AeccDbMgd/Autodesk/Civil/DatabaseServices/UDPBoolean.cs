using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DCB RID: 3531
	public class UDPBoolean : UDP
	{
		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06001A2E RID: 6702
		// (set) Token: 0x06001A2F RID: 6703
		public new extern bool DefaultValue { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06001A30 RID: 6704
		public unsafe virtual extern AeccAttributeTypeInfoBool* InternalGetAttributeTypeInfo();
	}
}
