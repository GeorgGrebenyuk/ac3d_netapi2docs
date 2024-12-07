using System;
using System.Runtime.InteropServices;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x0200122E RID: 4654
	public sealed class ParamOffsetTarget : ParamBase<9,Autodesk::Civil::DatabaseServices::WidthOffsetTarget\u0020^,AcArray<AcDbObjectId,AcArrayMemCopyReallocator<AcDbObjectId>\u0020>,Autodesk::Civil::Runtime::CastOp<Autodesk::Civil::DatabaseServices::WidthOffsetTarget\u0020^,AcArray<AcDbObjectId,AcArrayMemCopyReallocator<AcDbObjectId>\u0020>\u0020>\u0020>
	{
		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06002803 RID: 10243
		// (set) Token: 0x06002804 RID: 10244
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06002805 RID: 10245
		// (set) Token: 0x06002806 RID: 10246
		public override extern string DisplayName { get; set; }

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06002807 RID: 10247
		// (set) Token: 0x06002808 RID: 10248
		public override extern string Description { get; set; }

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06002809 RID: 10249
		// (set) Token: 0x0600280A RID: 10250
		public override extern string Comment { get; set; }

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600280B RID: 10251
		// (set) Token: 0x0600280C RID: 10252
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600280D RID: 10253
		// (set) Token: 0x0600280E RID: 10254
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700146E RID: 5230
		// (set) Token: 0x0600280F RID: 10255
		public override extern WidthOffsetTarget Value { set; }
	}
}
