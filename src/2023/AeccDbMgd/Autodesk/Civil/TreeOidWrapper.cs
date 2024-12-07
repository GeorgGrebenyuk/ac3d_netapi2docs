using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x0200001C RID: 28
	[Wrapper("AeccDbTreeOid")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class TreeOidWrapper : DisposableWrapper
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000C6 RID: 198
		protected extern AeccDbTreeOid WrappedOid { get; }

		// Token: 0x060000C7 RID: 199
		protected override extern void DeleteUnmanagedObject();
	}
}
