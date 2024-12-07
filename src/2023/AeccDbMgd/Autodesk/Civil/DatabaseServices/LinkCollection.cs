using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011BA RID: 4538
	public sealed class LinkCollection : CivilWrapper<AeccDbEntity>, IEnumerable<Link>
	{
		// Token: 0x06002604 RID: 9732
		public extern Link Add(IPoint point1, IPoint point2, string[] codes);

		// Token: 0x06002605 RID: 9733
		public extern Link Add(IPoint point1, IPoint point2, string[] codes, CorridorLinkDisplay displayMode);

		// Token: 0x06002606 RID: 9734
		public extern Link Add(IPoint[] points, string[] codes);

		// Token: 0x06002607 RID: 9735
		public extern Link Add(IPoint[] points, string[] codes, CorridorLinkDisplay displayMode);

		// Token: 0x06002608 RID: 9736
		public extern Link Add(IPoint point1, IPoint point2, string code);

		// Token: 0x06002609 RID: 9737
		public extern Link Add(IPoint point1, IPoint point2, string code, CorridorLinkDisplay displayMode);

		// Token: 0x0600260A RID: 9738
		public extern Link Add(IPoint[] points, string code);

		// Token: 0x0600260B RID: 9739
		public extern Link Add(IPoint[] points, string code, CorridorLinkDisplay displayMode);

		// Token: 0x0600260C RID: 9740
		public extern IEnumerator<Link> GetEnumerator();

		// Token: 0x0600260D RID: 9741
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x170013AC RID: 5036
		public extern Link this[int index]
		{
			get;
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600260F RID: 9743
		public extern int Count { get; }

		// Token: 0x06002610 RID: 9744
		public extern void Remove(Link link);

		// Token: 0x06002611 RID: 9745
		public extern void Remove(int index);

		// Token: 0x04001B04 RID: 6916
		private int <SyntheticNonEmptyStructMarker>;
	}
}
