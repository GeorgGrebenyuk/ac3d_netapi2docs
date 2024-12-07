using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BF RID: 191
	[DefaultMember("Item")]
	internal sealed class GradingCriteriaCollection : StyleCollectionBase
	{
		// Token: 0x0600084B RID: 2123
		public sealed override extern ObjectId Add(string name);
	}
}
