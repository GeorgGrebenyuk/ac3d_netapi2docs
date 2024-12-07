using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A41 RID: 2625
	internal sealed class SurfaceSurveyQueriesChecker
	{
		// Token: 0x060013D1 RID: 5073
		public unsafe static extern AeccSvProject* CheckSurveyProject(Surface surface, AeccSurfaceOp.AeccSurfaceOpType opType, Guid surveyProjectGuid);

		// Token: 0x060013D2 RID: 5074
		public unsafe static extern AeccQssMetaQuery* CheckSurveyQuery(AeccQssMetaQuery*, AeccSvProject* pSvProject, Guid surveyQueryGuid);

		// Token: 0x060013D3 RID: 5075
		public extern SurfaceSurveyQueriesChecker();
	}
}
