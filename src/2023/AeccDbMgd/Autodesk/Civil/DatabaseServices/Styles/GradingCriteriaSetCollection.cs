using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F4E RID: 3918
	[DefaultMember("Item")]
	public sealed class GradingCriteriaSetCollection : StyleCollectionBase
	{
		// Token: 0x06001D8B RID: 7563
		public sealed override extern ObjectId Add(string name);
	}
}
