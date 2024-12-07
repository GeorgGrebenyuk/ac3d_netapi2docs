using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F55 RID: 3925
	[DefaultMember("Item")]
	public sealed class MassHaulLineStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DA1 RID: 7585
		public sealed override extern ObjectId Add(string name);
	}
}
