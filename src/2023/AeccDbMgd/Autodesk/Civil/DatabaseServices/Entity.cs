using System;
using System.Runtime.InteropServices;
using Autodesk.Aec.DatabaseServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DataShortcuts;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200003B RID: 59
	[Wrapper("AeccDbEntity")]
	public class Entity : Entity
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000156 RID: 342
		public virtual extern object Application { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000157 RID: 343
		public virtual extern object Document { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000158 RID: 344
		// (set) Token: 0x06000159 RID: 345
		public virtual extern string Name { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015A RID: 346
		// (set) Token: 0x0600015B RID: 347
		public virtual extern string Description { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015C RID: 348
		public virtual extern string DisplayName { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015D RID: 349
		// (set) Token: 0x0600015E RID: 350
		public extern bool ShowToolTip { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015F RID: 351
		// (set) Token: 0x06000160 RID: 352
		public virtual extern ulong FingerPrint { get; set; }

		// Token: 0x06000161 RID: 353
		public virtual extern ulong ComputeFingerPrint();

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000162 RID: 354
		// (set) Token: 0x06000163 RID: 355
		public virtual extern string StyleName { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000164 RID: 356
		// (set) Token: 0x06000165 RID: 357
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000166 RID: 358
		public extern bool IsUsed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000167 RID: 359
		public extern bool IsReferenceObject { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000168 RID: 360
		public extern bool IsReferenceSubObject { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000169 RID: 361
		public extern bool IsReferenceValid { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016A RID: 362
		public extern bool IsReferenceStale { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600016B RID: 363
		public extern bool IsReferencedSourceExisting { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600016C RID: 364
		public extern ObjectId FolderId { get; }

		// Token: 0x0600016D RID: 365
		public extern DataShortcutKey GetReferenceInfo();

		// Token: 0x0600016E RID: 366
		protected internal extern Entity(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
