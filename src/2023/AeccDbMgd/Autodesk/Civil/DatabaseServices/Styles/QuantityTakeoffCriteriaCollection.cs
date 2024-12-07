using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011F4 RID: 4596
	[DefaultMember("Item")]
	public sealed class QuantityTakeoffCriteriaCollection : StyleCollectionBase
	{
		// Token: 0x060026D5 RID: 9941
		public sealed override extern ObjectId Add(string name);
	}
}
