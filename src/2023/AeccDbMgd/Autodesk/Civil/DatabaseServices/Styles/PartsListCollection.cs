using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001073 RID: 4211
	[DefaultMember("Item")]
	public sealed class PartsListCollection : StyleCollectionBase
	{
		// Token: 0x060021A9 RID: 8617
		public sealed override extern ObjectId Add(string name);
	}
}
