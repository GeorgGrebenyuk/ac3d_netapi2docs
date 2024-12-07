using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000983 RID: 2435
	[DefaultMember("Item")]
	public sealed class PointCloudStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001271 RID: 4721
		public sealed override extern ObjectId Add(string name);
	}
}
