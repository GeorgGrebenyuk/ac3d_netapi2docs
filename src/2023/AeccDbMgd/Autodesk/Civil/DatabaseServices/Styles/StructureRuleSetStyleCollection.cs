using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001050 RID: 4176
	[DefaultMember("Item")]
	public sealed class StructureRuleSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x0600214D RID: 8525
		public sealed override extern ObjectId Add(string name);
	}
}
