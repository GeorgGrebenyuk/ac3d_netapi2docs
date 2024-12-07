using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000970 RID: 2416
	[DefaultMember("Item")]
	public sealed class CantViewStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001241 RID: 4673
		public sealed override extern ObjectId Add(string name);
	}
}
