using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200084B RID: 2123
	public sealed class QTOSubcriteria : IEnumerable<QTOMaterialItem>, IDisposable
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000FF9 RID: 4089
		public extern ObjectId SampleLineGroupId { get; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000FFA RID: 4090
		public extern Guid MaterialListGuid { get; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000FFB RID: 4091
		public extern Guid MaterialGuid { get; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000FFC RID: 4092
		// (set) Token: 0x06000FFD RID: 4093
		public extern string Name { get; set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000FFE RID: 4094
		public extern int Count { get; }

		// Token: 0x1700069D RID: 1693
		public extern QTOMaterialItem this[string name]
		{
			get;
		}

		// Token: 0x1700069E RID: 1694
		public extern QTOMaterialItem this[int index]
		{
			get;
		}

		// Token: 0x06001001 RID: 4097
		public extern QTOMaterialItem Add(ObjectId surfaceId);

		// Token: 0x06001002 RID: 4098
		public extern void RemoveAt(int index);

		// Token: 0x06001003 RID: 4099
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOMaterialItem materialItem);

		// Token: 0x06001004 RID: 4100
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string name);

		// Token: 0x06001005 RID: 4101
		public extern IEnumerator<QTOMaterialItem> GetEnumerator();

		// Token: 0x06001006 RID: 4102
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001007 RID: 4103
		public sealed extern void Dispose();

		// Token: 0x04001257 RID: 4695
		private int <SyntheticNonEmptyStructMarker>;
	}
}
