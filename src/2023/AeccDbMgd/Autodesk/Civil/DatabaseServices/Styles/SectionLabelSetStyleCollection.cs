using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FA6 RID: 4006
	[DefaultMember("Item")]
	public sealed class SectionLabelSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001F8D RID: 8077
		public sealed override extern ObjectId Add(string name);
	}
}
