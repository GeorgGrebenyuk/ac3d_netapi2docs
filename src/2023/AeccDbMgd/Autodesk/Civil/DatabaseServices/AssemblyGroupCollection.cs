using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B86 RID: 2950
	public abstract class AssemblyGroupCollection : IEnumerable<AssemblyGroup>
	{
		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060015F3 RID: 5619
		public extern int Count { get; }

		// Token: 0x17000993 RID: 2451
		public extern AssemblyGroup this[string groupName]
		{
			get;
		}

		// Token: 0x17000994 RID: 2452
		public extern AssemblyGroup this[int index]
		{
			get;
		}

		// Token: 0x060015F6 RID: 5622
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(AssemblyGroup group);

		// Token: 0x060015F7 RID: 5623
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string groupName);

		// Token: 0x060015F8 RID: 5624
		public extern void RemoveAt(int index);

		// Token: 0x060015F9 RID: 5625
		public virtual extern IEnumerator<AssemblyGroup> GetEnumerator();

		// Token: 0x060015FA RID: 5626
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060015FB RID: 5627
		protected unsafe extern AeccDbAssembly* GetImpObj();

		// Token: 0x060015FC RID: 5628
		protected abstract int getGroupCount();

		// Token: 0x060015FD RID: 5629
		protected unsafe abstract void getGroupNames(AecRmCStringArray* groupNames);

		// Token: 0x060015FE RID: 5630
		protected abstract AssemblyGroup createAssemblyGroup(int index);

		// Token: 0x060015FF RID: 5631
		[return: MarshalAs(UnmanagedType.U1)]
		protected abstract bool contains(AssemblyGroup group);

		// Token: 0x06001600 RID: 5632
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool deleteGroup(AecRmCString* strGroupName);

		// Token: 0x04001513 RID: 5395
		private int <SyntheticNonEmptyStructMarker>;
	}
}
