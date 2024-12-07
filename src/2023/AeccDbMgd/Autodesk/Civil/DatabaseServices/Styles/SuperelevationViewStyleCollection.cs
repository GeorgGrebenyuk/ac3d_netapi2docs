using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000984 RID: 2436
	[DefaultMember("Item")]
	public sealed class SuperelevationViewStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001272 RID: 4722
		public sealed override extern ObjectId Add(string name);
	}
}
