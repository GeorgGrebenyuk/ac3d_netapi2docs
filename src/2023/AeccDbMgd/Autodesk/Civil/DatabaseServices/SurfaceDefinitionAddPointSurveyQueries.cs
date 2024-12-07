using System;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A42 RID: 2626
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionAddPointSurveyQueries : SurfaceDefinitionBase<SurfaceOperationAddPointSurveyQuery>
	{
		// Token: 0x060013D4 RID: 5076
		public extern SurfaceOperationAddPointSurveyQuery AddPointSurveyQuery(Guid surveyProjectGuid, Guid surveyQueryGuid, int queryChecksum, string surfaceOpDescription, double midOrdinateDis);
	}
}
