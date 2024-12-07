using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001245 RID: 4677
	public class Expression
	{
		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06002877 RID: 10359
		public extern string Name { get; }

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06002878 RID: 10360
		// (set) Token: 0x06002879 RID: 10361
		public extern string Description { get; set; }

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600287A RID: 10362
		// (set) Token: 0x0600287B RID: 10363
		public extern string ExpressionString { get; set; }

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600287C RID: 10364
		public extern string ReferenceString { get; }

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600287D RID: 10365
		// (set) Token: 0x0600287E RID: 10366
		public extern ExpressionFormatedType FormatResultAs { get; set; }

		// Token: 0x0600287F RID: 10367
		protected unsafe extern AeccAttributeTypeInfoExpression* GetAttributeTypeInfoExpression();

		// Token: 0x04001B96 RID: 7062
		private int <SyntheticNonEmptyStructMarker>;
	}
}
