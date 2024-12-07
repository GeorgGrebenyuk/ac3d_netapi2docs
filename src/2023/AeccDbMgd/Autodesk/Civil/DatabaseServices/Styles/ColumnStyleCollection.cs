using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001260 RID: 4704
	public sealed class ColumnStyleCollection : CivilWrapper<AeccDbScheduleTableStyle>, IEnumerable<ColumnStyle>
	{
		// Token: 0x17001500 RID: 5376
		public extern ColumnStyle this[int index]
		{
			get;
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060028DE RID: 10462
		public extern int Count { get; }

		// Token: 0x060028DF RID: 10463
		public extern void Add();

		// Token: 0x060028E0 RID: 10464
		public extern void RemoveAt(int index);

		// Token: 0x060028E1 RID: 10465
		public extern IEnumerator<ColumnStyle> GetEnumerator();

		// Token: 0x060028E2 RID: 10466
		public extern IEnumerator GetObjectEnumerator();
	}
}
