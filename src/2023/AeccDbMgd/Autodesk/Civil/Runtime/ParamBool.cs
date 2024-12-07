using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001030 RID: 4144
	public sealed class ParamBool : ParamBase<1,bool,bool,Autodesk::Civil::Runtime::CastOp<bool,bool>\u0020>
	{
		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002103 RID: 8451
		// (set) Token: 0x06002104 RID: 8452
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002105 RID: 8453
		// (set) Token: 0x06002106 RID: 8454
		public override extern string DisplayName { get; set; }

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002107 RID: 8455
		// (set) Token: 0x06002108 RID: 8456
		public override extern string Description { get; set; }

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002109 RID: 8457
		// (set) Token: 0x0600210A RID: 8458
		public override extern string Comment { get; set; }

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x0600210B RID: 8459
		// (set) Token: 0x0600210C RID: 8460
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x0600210D RID: 8461
		// (set) Token: 0x0600210E RID: 8462
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x0600210F RID: 8463
		// (set) Token: 0x06002110 RID: 8464
		public override extern bool Value { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002111 RID: 8465
		// (set) Token: 0x06002112 RID: 8466
		public extern TypeInfoBool TypeInfo { get; set; }
	}
}
