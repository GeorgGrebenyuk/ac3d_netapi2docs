using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000899 RID: 2201
	public class PointDescriptionKeySetCollection : IEnumerable<ObjectId>
	{
		// Token: 0x17000705 RID: 1797
		public extern ObjectId this[string name]
		{
			get;
		}

		// Token: 0x17000706 RID: 1798
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060010EB RID: 4331
		public extern int Count { get; }

		// Token: 0x060010EC RID: 4332
		public extern ObjectId Add(string name);

		// Token: 0x060010ED RID: 4333
		public extern void Remove(ObjectId objectId);

		// Token: 0x060010EE RID: 4334
		public extern void Remove(string name);

		// Token: 0x060010EF RID: 4335
		public extern void RemoveAt(int index);

		// Token: 0x060010F0 RID: 4336
		public extern void Clear();

		// Token: 0x060010F1 RID: 4337
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string name);

		// Token: 0x060010F2 RID: 4338
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(ObjectId objectId);

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060010F3 RID: 4339
		// (set) Token: 0x060010F4 RID: 4340
		public extern ObjectIdCollection SearchOrder { get; set; }

		// Token: 0x060010F5 RID: 4341
		public virtual extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x060010F6 RID: 4342
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060010F7 RID: 4343
		public static extern PointDescriptionKeySetCollection GetPointDescriptionKeySets(Database database);

		// Token: 0x040012AE RID: 4782
		private int <SyntheticNonEmptyStructMarker>;
	}
}
