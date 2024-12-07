using System;
using System.Runtime.Serialization;

namespace Autodesk.Civil
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class CivilException : Exception
	{
		// Token: 0x0600000D RID: 13
		protected extern CivilException(SerializationInfo info, StreamingContext context);

		// Token: 0x0600000E RID: 14
		public extern CivilException(ErrorStatus es, string message, Exception innerException);

		// Token: 0x0600000F RID: 15
		public extern CivilException(ErrorStatus es, string message);

		// Token: 0x06000010 RID: 16
		public extern CivilException(ErrorStatus es);

		// Token: 0x06000011 RID: 17
		public extern CivilException(string message, Exception innerException);

		// Token: 0x06000012 RID: 18
		public extern CivilException(string message);

		// Token: 0x06000013 RID: 19
		public extern CivilException();

		// Token: 0x06000014 RID: 20
		public static extern void ErrorHandler(ErrorStatus es, string message);

		// Token: 0x06000015 RID: 21
		public static extern void ErrorHandler(string message);

		// Token: 0x06000016 RID: 22
		public static extern void ErrorHandler(ErrorStatus es);

		// Token: 0x06000017 RID: 23
		public static extern void ErrorHandler();

		// Token: 0x040002D9 RID: 729
		private int <SyntheticNonEmptyStructMarker>;
	}
}
