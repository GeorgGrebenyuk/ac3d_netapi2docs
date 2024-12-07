using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F61 RID: 3937
	[DefaultMember("Item")]
	public sealed class PointStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DCE RID: 7630
		public sealed override extern ObjectId Add(string name);
	}
}
