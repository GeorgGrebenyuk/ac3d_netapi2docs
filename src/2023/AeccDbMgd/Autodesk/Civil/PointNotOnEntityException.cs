using System;
using System.Runtime.Serialization;

namespace Autodesk.Civil
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public class PointNotOnEntityException : CivilException
	{
		// Token: 0x06000018 RID: 24
		protected extern PointNotOnEntityException(SerializationInfo info, StreamingContext context);

		// Token: 0x06000019 RID: 25
		public extern PointNotOnEntityException(ErrorStatus es, string message);

		// Token: 0x0600001A RID: 26
		public extern PointNotOnEntityException(ErrorStatus es);

		// Token: 0x0600001B RID: 27
		public extern PointNotOnEntityException(string message, Exception innerException);

		// Token: 0x0600001C RID: 28
		public extern PointNotOnEntityException(string message);

		// Token: 0x0600001D RID: 29
		public extern PointNotOnEntityException();
	}
}
