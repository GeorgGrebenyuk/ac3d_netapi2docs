using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A44 RID: 2628
	public class SurfaceOperationAddSurveyQuery : SurfaceOperation
	{
		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060013D6 RID: 5078
		public extern Guid ProjectGuid { get; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060013D7 RID: 5079
		public extern string ProjectName { get; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060013D8 RID: 5080
		public extern Guid QueryGuid { get; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060013D9 RID: 5081
		public extern string QueryName { get; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060013DA RID: 5082
		public extern string Description { get; }

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060013DB RID: 5083
		public extern SurfaceSurveyQueryType SurveyQueryType { get; }
	}
}
