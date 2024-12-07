using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000169 RID: 361
	public class CloudDrawingMap
	{
		// Token: 0x0600017C RID: 380
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool Contains(string filePath);

		// Token: 0x0600017D RID: 381
		public static extern Tuple<CloudDrawingMap.DrawingStatus, Dictionary<string, string>> Get(string filePath);

		// Token: 0x0600017E RID: 382
		public static extern void Set(string filePath, Tuple<CloudDrawingMap.DrawingStatus, Dictionary<string, string>> drawingInfo);

		// Token: 0x0600017F RID: 383
		public static extern void Set(string filePath, CloudDrawingMap.DrawingStatus status, Dictionary<string, string> metadata);

		// Token: 0x06000180 RID: 384
		public static extern void Set(string filePath, CloudDrawingMap.DrawingStatus status);

		// Token: 0x06000181 RID: 385
		public static extern void Remove(string filePath);

		// Token: 0x06000182 RID: 386
		public extern CloudDrawingMap();

		// Token: 0x0200016A RID: 362
		public enum DrawingStatus
		{
			// Token: 0x040001A7 RID: 423
			Local,
			// Token: 0x040001A8 RID: 424
			CloudLockedByMe,
			// Token: 0x040001A9 RID: 425
			CloudLockedByOthers,
			// Token: 0x040001AA RID: 426
			CloudNotLocked
		}
	}
}
