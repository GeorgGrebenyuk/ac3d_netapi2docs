using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000042 RID: 66
	public class CaMgdPart : IDisposable
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B5 RID: 181
		public extern string Industry { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B6 RID: 182
		public extern string Domain { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B7 RID: 183
		public extern string PartType { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B8 RID: 184
		public extern string PartFamilyId { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B9 RID: 185
		public extern string PartSize { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000BA RID: 186
		public extern string Description { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BB RID: 187
		public extern string PartFamilyName { get; }

		// Token: 0x17000013 RID: 19
		public extern CaMgdContentValue this[string A_0]
		{
			get;
			set;
		}

		// Token: 0x17000014 RID: 20
		public extern CaMgdContentValue this[int index]
		{
			get;
			set;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C0 RID: 192
		public extern List<CaMgdConnectionPoint> ConnectionPoints { get; }

		// Token: 0x060000C1 RID: 193
		public extern CaMgdPart Clone([MarshalAs(UnmanagedType.U1)] bool bCopyData);

		// Token: 0x060000C2 RID: 194
		public extern void AddCollectionPoint(CaMgdConnectionPoint cp);

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000C3 RID: 195
		public extern int EngineeringPropertyCount { get; }

		// Token: 0x060000C4 RID: 196
		public unsafe extern CaMgdPart(CaPart* caPart, [MarshalAs(UnmanagedType.U1)] bool bOwner);

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000C5 RID: 197
		public unsafe extern CaPart* Value { get; }

		// Token: 0x060000C6 RID: 198
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000C7 RID: 199
		public sealed extern void Dispose();

		// Token: 0x060000C8 RID: 200
		protected override extern void Finalize();

		// Token: 0x04000462 RID: 1122
		private int <SyntheticNonEmptyStructMarker>;
	}
}
