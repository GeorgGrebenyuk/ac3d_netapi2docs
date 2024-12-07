using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x020000F2 RID: 242
	public class CaMgdConnectionPoint : IDisposable
	{
		// Token: 0x06000125 RID: 293
		public unsafe extern CaMgdConnectionPoint(CaConnectionPoint* cp);

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000126 RID: 294
		public extern string PartSizeID { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000127 RID: 295
		public extern string Name { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000128 RID: 296
		public unsafe extern CaConnectionPoint* Value { get; }

		// Token: 0x06000129 RID: 297
		public extern CaMgdErrorStatus GetPosition(out double x, out double y, out double z);

		// Token: 0x0600012A RID: 298
		public extern CaMgdErrorStatus GetDirection(out double x, out double y, out double z);

		// Token: 0x17000043 RID: 67
		public extern CaMgdContentValue this[string A_0]
		{
			get;
			set;
		}

		// Token: 0x17000044 RID: 68
		public extern CaMgdContentValue this[int index]
		{
			get;
			set;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600012F RID: 303
		public extern int ConnetionPointPropertyCount { get; }

		// Token: 0x06000130 RID: 304
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000131 RID: 305
		public sealed extern void Dispose();

		// Token: 0x06000132 RID: 306
		protected override extern void Finalize();

		// Token: 0x040004E0 RID: 1248
		private int <SyntheticNonEmptyStructMarker>;
	}
}
