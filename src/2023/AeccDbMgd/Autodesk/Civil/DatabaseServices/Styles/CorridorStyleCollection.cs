using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011F0 RID: 4592
	[DefaultMember("Item")]
	public sealed class CorridorStyleCollection : StyleCollectionBase
	{
		// Token: 0x060026BC RID: 9916
		public sealed override extern ObjectId Add(string name);
	}
}
