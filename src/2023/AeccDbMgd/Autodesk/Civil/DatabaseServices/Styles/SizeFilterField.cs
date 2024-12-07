using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001060 RID: 4192
	public sealed class SizeFilterField : PartDataField
	{
		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06002181 RID: 8577
		// (set) Token: 0x06002182 RID: 8578
		public extern bool IsMultipleSelect { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06002183 RID: 8579
		public extern PartDataSourceType DataSource { get; }

		// Token: 0x04001962 RID: 6498
		private int <SyntheticNonEmptyStructMarker>;
	}
}
