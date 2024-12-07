using System;

namespace Autodesk.Civil
{
	// Token: 0x02000082 RID: 130
	public abstract class DesignCheck : CivilWrapper<AcDbDatabase>
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600060A RID: 1546
		public extern string Name { get; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600060B RID: 1547
		// (set) Token: 0x0600060C RID: 1548
		public extern string Description { get; set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600060D RID: 1549
		// (set) Token: 0x0600060E RID: 1550
		public extern string Expression { get; set; }

		// Token: 0x0600060F RID: 1551
		protected unsafe abstract AcDbObjectId* GetClassNodeType(AcDbObjectId*);

		// Token: 0x06000610 RID: 1552
		protected unsafe extern AeccAttributeTypeInfoExpression* GetAttributeTypeInfoExpression();

		// Token: 0x04000302 RID: 770
		private int <SyntheticNonEmptyStructMarker>;
	}
}
