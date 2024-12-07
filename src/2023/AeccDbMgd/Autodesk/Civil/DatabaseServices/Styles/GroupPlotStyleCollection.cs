using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F67 RID: 3943
	[DefaultMember("Item")]
	public sealed class GroupPlotStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DD3 RID: 7635
		public sealed override extern ObjectId Add(string name);
	}
}
