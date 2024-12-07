using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB5 RID: 4021
	[DefaultMember("Item")]
	public sealed class ProfileViewBandSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001FC5 RID: 8133
		public sealed override extern ObjectId Add(string name);
	}
}
