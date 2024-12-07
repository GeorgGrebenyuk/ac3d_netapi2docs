using System;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A43 RID: 2627
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionAddFigureSurveyQueries : SurfaceDefinitionBase<SurfaceOperationAddFigureSurveyQuery>
	{
		// Token: 0x060013D5 RID: 5077
		public extern SurfaceOperationAddFigureSurveyQuery AddFigureSurveyQuery(Guid surveyProjectGuid, Guid surveyQueryGuid, int queryChecksum, string surfaceOpDescription, double midOrdinateDis);
	}
}
