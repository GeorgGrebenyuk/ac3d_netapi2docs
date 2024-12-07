using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F62 RID: 3938
	[DefaultMember("Item")]
	public sealed class ProfileViewStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DCF RID: 7631
		public sealed override extern ObjectId Add(string name);
	}
}
