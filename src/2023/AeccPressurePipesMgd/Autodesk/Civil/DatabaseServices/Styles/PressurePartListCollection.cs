using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001A4 RID: 420
	[DefaultMember("Item")]
	public sealed class PressurePartListCollection : StyleCollectionBase
	{
		// Token: 0x060001BC RID: 444
		public sealed override extern ObjectId Add(string name);
	}
}
