using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008A8 RID: 2216
	public class PointFileFormat : DisposableWrapper
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001144 RID: 4420
		public extern string Name { get; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001145 RID: 4421
		public extern string Delimiter { get; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001146 RID: 4422
		public extern string FileExtension { get; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001147 RID: 4423
		public extern string CommentTag { get; }

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001148 RID: 4424
		public extern PointFileFormatType FileFormatType { get; }

		// Token: 0x06001149 RID: 4425
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x0600114A RID: 4426
		protected override extern void DeleteUnmanagedObject();
	}
}
