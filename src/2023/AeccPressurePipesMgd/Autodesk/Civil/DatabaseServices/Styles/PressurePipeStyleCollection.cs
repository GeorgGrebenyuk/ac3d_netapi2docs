using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001AA RID: 426
	[DefaultMember("Item")]
	public sealed class PressurePipeStyleCollection : StyleCollectionBase
	{
		// Token: 0x060001C6 RID: 454
		public sealed override extern ObjectId Add(string name);
	}
}
