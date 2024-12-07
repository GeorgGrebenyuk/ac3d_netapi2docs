using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200105F RID: 4191
	[DefaultMember("Item")]
	public sealed class InterferenceStyleCollection : StyleCollectionBase
	{
		// Token: 0x06002180 RID: 8576
		public sealed override extern ObjectId Add(string name);
	}
}
