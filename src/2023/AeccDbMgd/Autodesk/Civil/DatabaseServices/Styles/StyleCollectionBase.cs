using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BE RID: 190
	public abstract class StyleCollectionBase : TreeOidWrapper, IEnumerable<ObjectId>
	{
		// Token: 0x0600083F RID: 2111
		public abstract ObjectId Add(string name);

		// Token: 0x06000840 RID: 2112
		protected unsafe extern ObjectId Add(AeccDbTreeNode* pNode, string name);

		// Token: 0x06000841 RID: 2113
		[Obsolete("Use the override methods with an index or name instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public virtual extern void Remove(StyleBase style);

		// Token: 0x06000842 RID: 2114
		public virtual extern void Remove(string styleName);

		// Token: 0x06000843 RID: 2115
		public virtual extern void Remove(int index);

		// Token: 0x1700035C RID: 860
		public virtual extern ObjectId this[string styleName]
		{
			get;
		}

		// Token: 0x1700035D RID: 861
		public virtual extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x06000846 RID: 2118
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string styleName);

		// Token: 0x06000847 RID: 2119
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(ObjectId item);

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000848 RID: 2120
		public virtual extern int Count { get; }

		// Token: 0x06000849 RID: 2121
		public virtual extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x0600084A RID: 2122
		public extern IEnumerator GetObjectEnumerator();
	}
}
