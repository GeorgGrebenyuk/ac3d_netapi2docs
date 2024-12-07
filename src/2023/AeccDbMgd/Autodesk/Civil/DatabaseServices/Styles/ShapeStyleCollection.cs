using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011C8 RID: 4552
	[DefaultMember("Item")]
	public sealed class ShapeStyleCollection : StyleCollectionBase
	{
		// Token: 0x06002646 RID: 9798
		public sealed override extern ObjectId Add(string name);
	}
}
