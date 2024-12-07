using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F65 RID: 3941
	[DefaultMember("Item")]
	public sealed class ProfileStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DD1 RID: 7633
		public sealed override extern ObjectId Add(string name);
	}
}
