using System;

namespace Autodesk.Civil
{
	// Token: 0x02000FBA RID: 4026
	public sealed class AlignmentDesignCheckCollection : DesignCheckCollection<Autodesk::Civil::AlignmentDesignCheck\u0020^>
	{
		// Token: 0x17000FE2 RID: 4066
		public override extern AlignmentDesignCheck this[string name]
		{
			get;
		}

		// Token: 0x17000FE3 RID: 4067
		public override extern AlignmentDesignCheck this[int index]
		{
			get;
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06001FDD RID: 8157
		public override extern int Count { get; }

		// Token: 0x06001FDE RID: 8158
		public sealed override extern void Remove(string name);

		// Token: 0x06001FDF RID: 8159
		public sealed override extern void RemoveAt(int index);

		// Token: 0x06001FE0 RID: 8160
		public sealed override extern AlignmentDesignCheck Add(string name, string description, string expression);

		// Token: 0x06001FE1 RID: 8161
		public sealed override extern void Clear();
	}
}
