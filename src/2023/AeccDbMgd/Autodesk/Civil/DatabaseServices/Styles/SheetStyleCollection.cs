using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F74 RID: 3956
	[DefaultMember("Item")]
	public sealed class SheetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001E44 RID: 7748
		public sealed override extern ObjectId Add(string name);
	}
}
