using System;
using System.Runtime.InteropServices;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001227 RID: 4647
	public sealed class ParamElevationTarget : ParamBase<10,Autodesk::Civil::DatabaseServices::SlopeElevationTarget\u0020^,AcArray<AcDbObjectId,AcArrayMemCopyReallocator<AcDbObjectId>\u0020>,Autodesk::Civil::Runtime::CastOp<Autodesk::Civil::DatabaseServices::SlopeElevationTarget\u0020^,AcArray<AcDbObjectId,AcArrayMemCopyReallocator<AcDbObjectId>\u0020>\u0020>\u0020>
	{
		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060027D9 RID: 10201
		// (set) Token: 0x060027DA RID: 10202
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060027DB RID: 10203
		// (set) Token: 0x060027DC RID: 10204
		public override extern string DisplayName { get; set; }

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060027DD RID: 10205
		// (set) Token: 0x060027DE RID: 10206
		public override extern string Description { get; set; }

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060027DF RID: 10207
		// (set) Token: 0x060027E0 RID: 10208
		public override extern string Comment { get; set; }

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060027E1 RID: 10209
		// (set) Token: 0x060027E2 RID: 10210
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060027E3 RID: 10211
		// (set) Token: 0x060027E4 RID: 10212
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001459 RID: 5209
		// (set) Token: 0x060027E5 RID: 10213
		public override extern SlopeElevationTarget Value { set; }
	}
}
