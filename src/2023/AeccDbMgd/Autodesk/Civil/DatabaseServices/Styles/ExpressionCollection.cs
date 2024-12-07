using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200124D RID: 4685
	public class ExpressionCollection : IEnumerable<Expression>
	{
		// Token: 0x170014BE RID: 5310
		public extern Expression this[string name]
		{
			get;
		}

		// Token: 0x170014BF RID: 5311
		public extern Expression this[int index]
		{
			get;
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06002882 RID: 10370
		public extern int Count { get; }

		// Token: 0x06002883 RID: 10371
		public extern void RemoveAt(int index);

		// Token: 0x06002884 RID: 10372
		public extern Expression Add(string name, string description, string expression);

		// Token: 0x06002885 RID: 10373
		public extern void Clear();

		// Token: 0x06002886 RID: 10374
		public virtual extern IEnumerator<Expression> GetEnumerator();

		// Token: 0x06002887 RID: 10375
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001BAC RID: 7084
		private int <SyntheticNonEmptyStructMarker>;
	}
}
