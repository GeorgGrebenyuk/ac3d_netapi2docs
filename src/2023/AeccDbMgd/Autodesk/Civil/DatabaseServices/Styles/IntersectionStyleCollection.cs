using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011F1 RID: 4593
	[DefaultMember("Item")]
	public sealed class IntersectionStyleCollection : StyleCollectionBase
	{
		// Token: 0x060026BD RID: 9917
		public sealed override extern ObjectId Add(string name);
	}
}
