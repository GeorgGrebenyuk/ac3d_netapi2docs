using System;
using System.Runtime.Serialization;

namespace Autodesk.Civil
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class EntityNotFoundException : CivilException
	{
		// Token: 0x0600001E RID: 30
		protected extern EntityNotFoundException(SerializationInfo info, StreamingContext context);

		// Token: 0x0600001F RID: 31
		public extern EntityNotFoundException(string message, Exception innerException);

		// Token: 0x06000020 RID: 32
		public extern EntityNotFoundException(ErrorStatus es, string message);

		// Token: 0x06000021 RID: 33
		public extern EntityNotFoundException(ErrorStatus es);

		// Token: 0x06000022 RID: 34
		public extern EntityNotFoundException(string message);

		// Token: 0x06000023 RID: 35
		public extern EntityNotFoundException();
	}
}
