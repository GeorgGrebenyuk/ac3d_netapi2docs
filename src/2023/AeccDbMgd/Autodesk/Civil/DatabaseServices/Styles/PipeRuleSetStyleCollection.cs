using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200104D RID: 4173
	[DefaultMember("Item")]
	public sealed class PipeRuleSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x0600214C RID: 8524
		public sealed override extern ObjectId Add(string name);
	}
}
