using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200072A RID: 1834
	public class Event
	{
		// Token: 0x06000E58 RID: 3672
		public static extern void Log(Event.Type type, string source, string text, Database database);

		// Token: 0x06000E59 RID: 3673
		public static extern void Log(Event.Type type, string source, string text);

		// Token: 0x06000E5A RID: 3674
		public extern Event();

		// Token: 0x0200072B RID: 1835
		public enum Type
		{
			// Token: 0x04001127 RID: 4391
			Information = 1,
			// Token: 0x04001128 RID: 4392
			Warning,
			// Token: 0x04001129 RID: 4393
			Error = 4
		}
	}
}
