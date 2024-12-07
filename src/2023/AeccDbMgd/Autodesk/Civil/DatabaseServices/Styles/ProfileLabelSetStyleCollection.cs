using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FA3 RID: 4003
	[DefaultMember("Item")]
	public sealed class ProfileLabelSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001F79 RID: 8057
		public sealed override extern ObjectId Add(string name);
	}
}
