using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F96 RID: 3990
	[DefaultMember("Item")]
	public sealed class SurfaceStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001F27 RID: 7975
		public sealed override extern ObjectId Add(string name);
	}
}
