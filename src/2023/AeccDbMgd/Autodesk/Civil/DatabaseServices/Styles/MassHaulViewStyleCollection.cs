using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F5E RID: 3934
	[DefaultMember("Item")]
	public sealed class MassHaulViewStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DCB RID: 7627
		public sealed override extern ObjectId Add(string name);
	}
}
