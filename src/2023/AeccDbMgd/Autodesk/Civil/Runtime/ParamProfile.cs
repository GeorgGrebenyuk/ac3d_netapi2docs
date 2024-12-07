using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x0200121C RID: 4636
	public sealed class ParamProfile : ParamBase<7,Autodesk::AutoCAD::DatabaseServices::ObjectId,AcDbObjectId,Autodesk::Civil::Runtime::CastOpProfileId>
	{
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06002779 RID: 10105
		// (set) Token: 0x0600277A RID: 10106
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600277B RID: 10107
		// (set) Token: 0x0600277C RID: 10108
		public override extern string DisplayName { get; set; }

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600277D RID: 10109
		// (set) Token: 0x0600277E RID: 10110
		public override extern string Description { get; set; }

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600277F RID: 10111
		// (set) Token: 0x06002780 RID: 10112
		public override extern string Comment { get; set; }

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06002781 RID: 10113
		// (set) Token: 0x06002782 RID: 10114
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06002783 RID: 10115
		// (set) Token: 0x06002784 RID: 10116
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06002785 RID: 10117
		// (set) Token: 0x06002786 RID: 10118
		public override extern ObjectId Value { get; set; }
	}
}
