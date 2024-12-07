using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000884 RID: 2180
	public class UDPClassificationCollection : IEnumerable<UDPClassification>
	{
		// Token: 0x170006D1 RID: 1745
		public extern UDPClassification this[int index]
		{
			get;
		}

		// Token: 0x170006D2 RID: 1746
		public extern UDPClassification this[string name]
		{
			get;
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600108E RID: 4238
		public extern int Count { get; }

		// Token: 0x0600108F RID: 4239
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string name);

		// Token: 0x06001090 RID: 4240
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(UDPClassification udpClassification);

		// Token: 0x06001091 RID: 4241
		public extern UDPClassification Add(string name);

		// Token: 0x06001092 RID: 4242
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(UDPClassification udpClassification);

		// Token: 0x06001093 RID: 4243
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string name);

		// Token: 0x06001094 RID: 4244
		public virtual extern IEnumerator<UDPClassification> GetEnumerator();

		// Token: 0x06001095 RID: 4245
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001096 RID: 4246
		public static extern UDPClassificationCollection GetPointUDPClassifications(Database pDatabase);

		// Token: 0x0400128D RID: 4749
		private int <SyntheticNonEmptyStructMarker>;
	}
}
