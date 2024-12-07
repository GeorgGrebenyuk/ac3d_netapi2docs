using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F46 RID: 3910
	[DefaultMember("Item")]
	public sealed class AlignmentStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001D88 RID: 7560
		public sealed override extern ObjectId Add(string name);
	}
}
