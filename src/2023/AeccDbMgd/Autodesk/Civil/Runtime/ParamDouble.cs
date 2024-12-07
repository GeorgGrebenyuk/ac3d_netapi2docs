using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x0200100F RID: 4111
	public sealed class ParamDouble : ParamBase<3,double,double,Autodesk::Civil::Runtime::CastOp<double,double>\u0020>
	{
		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060020BA RID: 8378
		// (set) Token: 0x060020BB RID: 8379
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060020BC RID: 8380
		// (set) Token: 0x060020BD RID: 8381
		public override extern string DisplayName { get; set; }

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060020BE RID: 8382
		// (set) Token: 0x060020BF RID: 8383
		public override extern string Description { get; set; }

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060020C0 RID: 8384
		// (set) Token: 0x060020C1 RID: 8385
		public override extern string Comment { get; set; }

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060020C2 RID: 8386
		// (set) Token: 0x060020C3 RID: 8387
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060020C4 RID: 8388
		// (set) Token: 0x060020C5 RID: 8389
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060020C6 RID: 8390
		// (set) Token: 0x060020C7 RID: 8391
		public override extern double Value { get; set; }

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060020C8 RID: 8392
		// (set) Token: 0x060020C9 RID: 8393
		public extern TypeInfoDouble TypeInfo { get; set; }
	}
}
