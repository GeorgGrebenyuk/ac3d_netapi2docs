using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011EF RID: 4591
	[DefaultMember("Item")]
	public sealed class AssemblyStyleCollection : StyleCollectionBase
	{
		// Token: 0x060026BB RID: 9915
		public sealed override extern ObjectId Add(string name);
	}
}
