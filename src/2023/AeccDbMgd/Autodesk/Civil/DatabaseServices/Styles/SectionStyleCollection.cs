using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F72 RID: 3954
	[DefaultMember("Item")]
	public sealed class SectionStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001E42 RID: 7746
		public sealed override extern ObjectId Add(string name);
	}
}
