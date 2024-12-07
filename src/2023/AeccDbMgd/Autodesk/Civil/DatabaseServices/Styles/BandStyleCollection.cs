using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020012A1 RID: 4769
	[DefaultMember("Item")]
	public class BandStyleCollection : StyleCollectionBase
	{
		// Token: 0x060029E3 RID: 10723
		public override extern ObjectId Add(string name);
	}
}
