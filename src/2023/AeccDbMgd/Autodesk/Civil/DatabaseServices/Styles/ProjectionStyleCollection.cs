using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F71 RID: 3953
	[DefaultMember("Item")]
	public sealed class ProjectionStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001E41 RID: 7745
		public sealed override extern ObjectId Add(string name);
	}
}
