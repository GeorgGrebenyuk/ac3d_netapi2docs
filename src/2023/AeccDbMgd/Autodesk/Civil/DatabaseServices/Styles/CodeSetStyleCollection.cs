using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001117 RID: 4375
	[DefaultMember("Item")]
	public sealed class CodeSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06002415 RID: 9237
		public sealed override extern ObjectId Add(string name);
	}
}
