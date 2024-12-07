using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001210 RID: 4624
	public sealed class ParamAlignment : ParamBase<6,Autodesk::AutoCAD::DatabaseServices::ObjectId,AcDbObjectId,Autodesk::Civil::Runtime::CastOpAlignmentId>
	{
		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06002723 RID: 10019
		// (set) Token: 0x06002724 RID: 10020
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06002725 RID: 10021
		// (set) Token: 0x06002726 RID: 10022
		public override extern string DisplayName { get; set; }

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06002727 RID: 10023
		// (set) Token: 0x06002728 RID: 10024
		public override extern string Description { get; set; }

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06002729 RID: 10025
		// (set) Token: 0x0600272A RID: 10026
		public override extern string Comment { get; set; }

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x0600272B RID: 10027
		// (set) Token: 0x0600272C RID: 10028
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x0600272D RID: 10029
		// (set) Token: 0x0600272E RID: 10030
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x0600272F RID: 10031
		// (set) Token: 0x06002730 RID: 10032
		public override extern ObjectId Value { get; set; }
	}
}
