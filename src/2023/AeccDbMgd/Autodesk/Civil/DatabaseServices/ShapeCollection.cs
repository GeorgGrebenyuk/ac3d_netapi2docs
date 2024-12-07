using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C3 RID: 4547
	public sealed class ShapeCollection : CivilWrapper<AeccDbEntity>, IEnumerable<Shape>
	{
		// Token: 0x06002626 RID: 9766
		public extern Shape Add(Link link1, Link link2, Link link3, Link link4, string[] codes);

		// Token: 0x06002627 RID: 9767
		public extern Shape Add(Link[] links, string[] codes);

		// Token: 0x06002628 RID: 9768
		public extern Shape Add(Link link1, Link link2, Link link3, Link link4, string code);

		// Token: 0x06002629 RID: 9769
		public extern Shape Add(Link[] links, string code);

		// Token: 0x0600262A RID: 9770
		public extern IEnumerator<Shape> GetEnumerator();

		// Token: 0x0600262B RID: 9771
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x170013B4 RID: 5044
		public extern Shape this[int index]
		{
			get;
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600262D RID: 9773
		public extern int Count { get; }

		// Token: 0x0600262E RID: 9774
		public extern void Remove(Shape shape);

		// Token: 0x0600262F RID: 9775
		public extern void Remove(int index);

		// Token: 0x04001B0B RID: 6923
		private int <SyntheticNonEmptyStructMarker>;
	}
}
