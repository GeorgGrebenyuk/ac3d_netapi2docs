using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F64 RID: 3940
	[DefaultMember("Item")]
	public sealed class ProfileDesignCheckSetCollection : StyleCollectionBase
	{
		// Token: 0x06001DD0 RID: 7632
		public sealed override extern ObjectId Add(string name);
	}
}
