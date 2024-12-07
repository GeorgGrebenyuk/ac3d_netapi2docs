using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F44 RID: 3908
	[DefaultMember("Item")]
	public sealed class AlignmentDesignCheckSetCollection : StyleCollectionBase
	{
		// Token: 0x06001D79 RID: 7545
		public sealed override extern ObjectId Add(string name);
	}
}
