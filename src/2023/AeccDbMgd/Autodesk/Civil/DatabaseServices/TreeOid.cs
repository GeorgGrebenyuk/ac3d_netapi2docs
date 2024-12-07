using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000011 RID: 17
	[Wrapper("AeccDbTreeOid")]
	internal class TreeOid : DisposableWrapper
	{
		// Token: 0x06000008 RID: 8
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x06000009 RID: 9
		protected override extern void DeleteUnmanagedObject();
	}
}
