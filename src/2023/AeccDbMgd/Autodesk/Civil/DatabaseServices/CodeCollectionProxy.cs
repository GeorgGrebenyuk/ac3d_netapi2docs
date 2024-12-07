using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B8D RID: 2957
	internal abstract class CodeCollectionProxy
	{
		// Token: 0x06001615 RID: 5653
		public extern int Count();

		// Token: 0x06001616 RID: 5654
		public extern string Item(int index);

		// Token: 0x06001617 RID: 5655
		public extern void Add(string code);

		// Token: 0x06001618 RID: 5656
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string code);

		// Token: 0x06001619 RID: 5657
		protected abstract int getCount();

		// Token: 0x0600161A RID: 5658
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool getCode(int index, AecRmCString* code);

		// Token: 0x0600161B RID: 5659
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool addCode(AecRmCString* code);

		// Token: 0x0600161C RID: 5660
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool removeCode(AecRmCString* code);

		// Token: 0x0600161D RID: 5661
		public extern CodeCollectionProxy();
	}
}
