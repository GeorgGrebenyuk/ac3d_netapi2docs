using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011BF RID: 4543
	[DefaultMember("Item")]
	public sealed class LinkStyleCollection : StyleCollectionBase
	{
		// Token: 0x0600261D RID: 9757
		public sealed override extern ObjectId Add(string name);
	}
}
