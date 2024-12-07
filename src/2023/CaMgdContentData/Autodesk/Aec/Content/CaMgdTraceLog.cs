using System;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200004A RID: 74
	public class CaMgdTraceLog : IDisposable
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275
		public static extern CaMgdTraceLog Instance { get; }

		// Token: 0x06000114 RID: 276
		public extern void EnableTrace([MarshalAs(UnmanagedType.U1)] bool isEnabled);

		// Token: 0x06000115 RID: 277
		public extern void SetPriority(CaMgdSyslogLevel priority);

		// Token: 0x06000116 RID: 278
		public extern void SetLogFile(string fileName);

		// Token: 0x06000117 RID: 279
		public extern void Trace(CaMgdSyslogLevel priority, string message);

		// Token: 0x06000118 RID: 280
		public extern void Debug(string message);

		// Token: 0x06000119 RID: 281
		public extern void Info(string message);

		// Token: 0x0600011A RID: 282
		public extern void Notice(string message);

		// Token: 0x0600011B RID: 283
		public extern void Warn(string message);

		// Token: 0x0600011C RID: 284
		public extern void Error(string message);

		// Token: 0x0600011D RID: 285
		public extern void Crit(string message);

		// Token: 0x0600011E RID: 286
		public extern void Alert(string message);

		// Token: 0x0600011F RID: 287
		public extern void Emerg(string message);

		// Token: 0x06000120 RID: 288
		public extern void Fatal(string message);

		// Token: 0x06000121 RID: 289
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000122 RID: 290
		public sealed extern void Dispose();

		// Token: 0x04000469 RID: 1129
		private int <SyntheticNonEmptyStructMarker>;
	}
}
