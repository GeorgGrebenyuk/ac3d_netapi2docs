using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001268 RID: 4712
	[DefaultMember("Item")]
	public sealed class TableStyleCollection : StyleCollectionBase
	{
		// Token: 0x060028FD RID: 10493
		public sealed override extern ObjectId Add(string name);
	}
}
