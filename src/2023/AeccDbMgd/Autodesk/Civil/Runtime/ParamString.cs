using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001034 RID: 4148
	public sealed class ParamString : ParamBase<4,System::String\u0020^,AecRmCString,Autodesk::Civil::Runtime::CastOp<System::String\u0020^,AecRmCString>\u0020>
	{
		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600212C RID: 8492
		// (set) Token: 0x0600212D RID: 8493
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x0600212E RID: 8494
		// (set) Token: 0x0600212F RID: 8495
		public override extern string DisplayName { get; set; }

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06002130 RID: 8496
		// (set) Token: 0x06002131 RID: 8497
		public override extern string Description { get; set; }

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06002132 RID: 8498
		// (set) Token: 0x06002133 RID: 8499
		public override extern string Comment { get; set; }

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06002134 RID: 8500
		// (set) Token: 0x06002135 RID: 8501
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06002136 RID: 8502
		// (set) Token: 0x06002137 RID: 8503
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06002138 RID: 8504
		// (set) Token: 0x06002139 RID: 8505
		public override extern string Value { get; set; }
	}
}
