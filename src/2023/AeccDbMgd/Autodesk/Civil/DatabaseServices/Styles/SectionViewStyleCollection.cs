using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F73 RID: 3955
	[DefaultMember("Item")]
	public sealed class SectionViewStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001E43 RID: 7747
		public sealed override extern ObjectId Add(string name);
	}
}
