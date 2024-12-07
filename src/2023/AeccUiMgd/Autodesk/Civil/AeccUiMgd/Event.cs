using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000198 RID: 408
	public class Event
	{
		// Token: 0x06000193 RID: 403
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool AddEvent(Event.EventType eventType, string strSource, string strDescription);

		// Token: 0x06000194 RID: 404
		public extern Event();

		// Token: 0x02000199 RID: 409
		public enum EventType
		{
			// Token: 0x040001D6 RID: 470
			EventInformation = 1,
			// Token: 0x040001D7 RID: 471
			EventWarning,
			// Token: 0x040001D8 RID: 472
			EventError = 4
		}
	}
}
