using System;

namespace Autodesk.Civil.Logging
{
	// Token: 0x02000002 RID: 2
	public class FileLogger
	{
		// Token: 0x06000003 RID: 3
		public extern FileLogger(string logPath);

		// Token: 0x06000004 RID: 4
		public static extern string GetDefaultLogPath();

		// Token: 0x06000005 RID: 5
		public extern void Log(FileLogger.LogType logType, string msg);

		// Token: 0x0400000E RID: 14
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x02000003 RID: 3
		public enum LogType
		{
			// Token: 0x04000010 RID: 16
			Verbose,
			// Token: 0x04000011 RID: 17
			Debug,
			// Token: 0x04000012 RID: 18
			Information,
			// Token: 0x04000013 RID: 19
			Warning,
			// Token: 0x04000014 RID: 20
			Error,
			// Token: 0x04000015 RID: 21
			Fatal
		}
	}
}
