using System;

namespace Autodesk.Civil
{
	// Token: 0x02000FC1 RID: 4033
	public sealed class ProfileDesignCheckCollection : DesignCheckCollection<Autodesk::Civil::ProfileDesignCheck\u0020^>
	{
		// Token: 0x17000FEF RID: 4079
		public override extern ProfileDesignCheck this[string name]
		{
			get;
		}

		// Token: 0x17000FF0 RID: 4080
		public override extern ProfileDesignCheck this[int index]
		{
			get;
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06001FF8 RID: 8184
		public override extern int Count { get; }

		// Token: 0x06001FF9 RID: 8185
		public sealed override extern void Remove(string name);

		// Token: 0x06001FFA RID: 8186
		public sealed override extern void RemoveAt(int index);

		// Token: 0x06001FFB RID: 8187
		public sealed override extern ProfileDesignCheck Add(string name, string description, string expression);

		// Token: 0x06001FFC RID: 8188
		public sealed override extern void Clear();
	}
}
