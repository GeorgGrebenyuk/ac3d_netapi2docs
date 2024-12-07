using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001256 RID: 4694
	[DefaultMember("Item")]
	public sealed class MarkerStyleCollection : StyleCollectionBase
	{
		// Token: 0x060028C7 RID: 10439
		public sealed override extern ObjectId Add(string name);
	}
}
