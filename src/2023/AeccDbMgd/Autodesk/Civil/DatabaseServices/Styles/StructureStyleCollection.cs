using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200105E RID: 4190
	[DefaultMember("Item")]
	public sealed class StructureStyleCollection : StyleCollectionBase
	{
		// Token: 0x0600217F RID: 8575
		public sealed override extern ObjectId Add(string name);
	}
}
