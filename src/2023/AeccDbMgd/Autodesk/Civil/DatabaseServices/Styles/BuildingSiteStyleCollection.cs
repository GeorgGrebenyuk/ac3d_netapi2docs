using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F47 RID: 3911
	[DefaultMember("Item")]
	public sealed class BuildingSiteStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001D89 RID: 7561
		public sealed override extern ObjectId Add(string name);
	}
}
