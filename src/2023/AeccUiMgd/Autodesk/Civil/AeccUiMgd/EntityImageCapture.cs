using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000193 RID: 403
	public class EntityImageCapture : IDisposable
	{
		// Token: 0x0600018A RID: 394
		public extern void SetImageFormat(ImageFormatType ImageFormat);

		// Token: 0x0600018B RID: 395
		public extern void AdjustExtents(int pcLeft, int pcRight, int pcTop, int pcBottomm);

		// Token: 0x0600018C RID: 396
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool CaptureImage(string fileName, int width, int height);

		// Token: 0x0600018D RID: 397
		public extern EntityImageCapture(ObjectIdCollection entityIds);

		// Token: 0x0600018E RID: 398
		public extern EntityImageCapture(ObjectId entityId);

		// Token: 0x0600018F RID: 399
		protected unsafe extern AeccEntityImageCapture* GetImpObj();

		// Token: 0x06000190 RID: 400
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000191 RID: 401
		public sealed extern void Dispose();

		// Token: 0x06000192 RID: 402
		protected override extern void Finalize();

		// Token: 0x040001CC RID: 460
		private int <SyntheticNonEmptyStructMarker>;
	}
}
