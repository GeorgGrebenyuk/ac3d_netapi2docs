using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F7B RID: 3963
	[DefaultMember("Item")]
	public sealed class SlopePatternStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001E85 RID: 7813
		public sealed override extern ObjectId Add(string name);
	}
}
