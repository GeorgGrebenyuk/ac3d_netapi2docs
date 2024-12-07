using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F97 RID: 3991
	[DefaultMember("Item")]
	public sealed class ViewFrameStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001F28 RID: 7976
		public sealed override extern ObjectId Add(string name);
	}
}
