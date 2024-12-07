using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000971 RID: 2417
	[DefaultMember("Item")]
	public sealed class CatchmentStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001242 RID: 4674
		public sealed override extern ObjectId Add(string name);
	}
}
