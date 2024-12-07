using System;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AA1 RID: 2721
	public class KrigingMethodOptions
	{
		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001461 RID: 5217
		// (set) Token: 0x06001462 RID: 5218
		public extern IEnumerable<TinSurfaceVertex> SampleVertices { get; set; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001463 RID: 5219
		// (set) Token: 0x06001464 RID: 5220
		public extern KrigingSemivariogramType SemivariogramModel { get; set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001465 RID: 5221
		// (set) Token: 0x06001466 RID: 5222
		public extern double VariogramParamA { get; set; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001467 RID: 5223
		// (set) Token: 0x06001468 RID: 5224
		public extern double VariogramParamC { get; set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001469 RID: 5225
		// (set) Token: 0x0600146A RID: 5226
		public extern double NuggetEffect { get; set; }

		// Token: 0x0600146B RID: 5227
		public extern KrigingMethodOptions();

		// Token: 0x04001469 RID: 5225
		private int <SyntheticNonEmptyStructMarker>;
	}
}
