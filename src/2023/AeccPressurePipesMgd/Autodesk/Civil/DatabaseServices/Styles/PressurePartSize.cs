using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000139 RID: 313
	public sealed class PressurePartSize : DisposableWrapper, IEquatable<PressurePartSize>
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000167 RID: 359
		public extern PressurePartDomainType Domain { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000168 RID: 360
		public extern PressurePartType PartType { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000169 RID: 361
		public extern string FamilyGuid { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600016A RID: 362
		// (set) Token: 0x0600016B RID: 363
		public extern string Description { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600016C RID: 364
		public extern string PartSizeGuid { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600016D RID: 365
		// (set) Token: 0x0600016E RID: 366
		public extern ObjectId StyleId { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600016F RID: 367
		// (set) Token: 0x06000170 RID: 368
		public extern ObjectId RenderMaterialId { get; set; }

		// Token: 0x06000171 RID: 369
		public extern object GetProperty(PressurePartContextType prop);

		// Token: 0x06000172 RID: 370
		public extern void SetProperty(PressurePartContextType prop, object newVal);

		// Token: 0x06000173 RID: 371
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object rhs);

		// Token: 0x06000174 RID: 372
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Equals(PressurePartSize rhs);

		// Token: 0x06000175 RID: 373
		public sealed override extern int GetHashCode();

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000176 RID: 374
		public extern bool IsValid { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
