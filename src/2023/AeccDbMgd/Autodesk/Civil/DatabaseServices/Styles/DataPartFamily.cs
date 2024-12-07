using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000D8 RID: 216
	public sealed class DataPartFamily
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060009D9 RID: 2521
		public extern string Description { get; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060009DA RID: 2522
		public extern string GUID { get; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060009DB RID: 2523
		public extern PartType PartType { get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060009DC RID: 2524
		public extern DomainType Domain { get; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060009DD RID: 2525
		public extern BoundingShapeType BoundingShape { get; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060009DE RID: 2526
		public extern SweptShapeType SweptShape { get; }

		// Token: 0x0400030B RID: 779
		private int <SyntheticNonEmptyStructMarker>;
	}
}
