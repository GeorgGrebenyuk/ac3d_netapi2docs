using System;
using System.Runtime.Serialization;

namespace Autodesk.Civil
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class SurveyException : CivilException
	{
		// Token: 0x0600002A RID: 42
		protected extern SurveyException(SerializationInfo info, StreamingContext context);

		// Token: 0x0600002B RID: 43
		public extern SurveyException(string message, Exception innerException);

		// Token: 0x0600002C RID: 44
		public extern SurveyException(SurveyStatus es, string message);

		// Token: 0x0600002D RID: 45
		public extern SurveyException(SurveyStatus es);

		// Token: 0x0600002E RID: 46
		public extern SurveyException(string message);

		// Token: 0x0600002F RID: 47
		public extern SurveyException();
	}
}
