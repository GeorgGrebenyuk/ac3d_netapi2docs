using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011D8 RID: 4568
	[Wrapper("SampleSectionLinkData")]
	public sealed class SampledSectionLink : CivilWrapper<Autodesk::Civil::DatabaseServices::SampleSectionLinkData>
	{
		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600268B RID: 9867
		// (set) Token: 0x0600268C RID: 9868
		public extern double EndPointOffset { get; set; }

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600268D RID: 9869
		// (set) Token: 0x0600268E RID: 9870
		public extern double EndPointElevation { get; set; }

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600268F RID: 9871
		public extern double StartPointStation { get; }

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06002690 RID: 9872
		public extern double EndPointStation { get; }

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06002691 RID: 9873
		public extern double StartPointOffset { get; }

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06002692 RID: 9874
		public extern double StartPointElevation { get; }
	}
}
