using System;
using System.Runtime.Serialization;

namespace Autodesk.Civil
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class SurfaceException : CivilException
	{
		// Token: 0x06000024 RID: 36
		protected extern SurfaceException(SerializationInfo info, StreamingContext context);

		// Token: 0x06000025 RID: 37
		public extern SurfaceException(string message, Exception innerException);

		// Token: 0x06000026 RID: 38
		public extern SurfaceException(SurfaceStatus es, string message);

		// Token: 0x06000027 RID: 39
		public extern SurfaceException(SurfaceStatus es);

		// Token: 0x06000028 RID: 40
		public extern SurfaceException(string message);

		// Token: 0x06000029 RID: 41
		public extern SurfaceException();
	}
}
