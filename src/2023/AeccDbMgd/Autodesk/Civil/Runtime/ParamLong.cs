using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x0200100B RID: 4107
	public sealed class ParamLong : ParamBase<2,long,long,Autodesk::Civil::Runtime::CastOp<long,long>\u0020>
	{
		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600208E RID: 8334
		// (set) Token: 0x0600208F RID: 8335
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06002090 RID: 8336
		// (set) Token: 0x06002091 RID: 8337
		public override extern string DisplayName { get; set; }

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06002092 RID: 8338
		// (set) Token: 0x06002093 RID: 8339
		public override extern string Description { get; set; }

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06002094 RID: 8340
		// (set) Token: 0x06002095 RID: 8341
		public override extern string Comment { get; set; }

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06002096 RID: 8342
		// (set) Token: 0x06002097 RID: 8343
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06002098 RID: 8344
		// (set) Token: 0x06002099 RID: 8345
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600209A RID: 8346
		// (set) Token: 0x0600209B RID: 8347
		public override extern int Value { get; set; }

		// Token: 0x0600209C RID: 8348
		public extern uint EnumCount();

		// Token: 0x0600209D RID: 8349
		public extern void GetEnumData(uint index, ref string name, ref string displayName, ref int value);

		// Token: 0x0600209E RID: 8350
		public extern void AddEnumData(string name, string displayName, int value);

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600209F RID: 8351
		// (set) Token: 0x060020A0 RID: 8352
		public extern TypeInfoLong TypeInfo { get; set; }
	}
}
