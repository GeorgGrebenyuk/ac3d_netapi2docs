using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F60 RID: 3936
	[DefaultMember("Item")]
	public sealed class ParcelStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DCD RID: 7629
		public sealed override extern ObjectId Add(string name);
	}
}
