using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001216 RID: 4630
	public sealed class ParamSurface : ParamBase<8,Autodesk::AutoCAD::DatabaseServices::ObjectId,AcDbObjectId,Autodesk::Civil::Runtime::CastOpSurfaceId>
	{
		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x0600274E RID: 10062
		// (set) Token: 0x0600274F RID: 10063
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06002750 RID: 10064
		// (set) Token: 0x06002751 RID: 10065
		public override extern string DisplayName { get; set; }

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06002752 RID: 10066
		// (set) Token: 0x06002753 RID: 10067
		public override extern string Description { get; set; }

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06002754 RID: 10068
		// (set) Token: 0x06002755 RID: 10069
		public override extern string Comment { get; set; }

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06002756 RID: 10070
		// (set) Token: 0x06002757 RID: 10071
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06002758 RID: 10072
		// (set) Token: 0x06002759 RID: 10073
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600275A RID: 10074
		// (set) Token: 0x0600275B RID: 10075
		public override extern ObjectId Value { get; set; }
	}
}
