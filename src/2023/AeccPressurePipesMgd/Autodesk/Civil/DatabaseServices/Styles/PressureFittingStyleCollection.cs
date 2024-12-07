using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200018E RID: 398
	[DefaultMember("Item")]
	public sealed class PressureFittingStyleCollection : StyleCollectionBase
	{
		// Token: 0x060001B3 RID: 435
		public sealed override extern ObjectId Add(string name);
	}
}
