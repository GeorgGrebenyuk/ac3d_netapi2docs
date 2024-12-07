using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F4B RID: 3915
	[DefaultMember("Item")]
	public sealed class FeatureLineStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001D8A RID: 7562
		public sealed override extern ObjectId Add(string name);
	}
}
