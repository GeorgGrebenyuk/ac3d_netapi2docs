using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F66 RID: 3942
	[DefaultMember("Item")]
	public sealed class SampleLineStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DD2 RID: 7634
		public sealed override extern ObjectId Add(string name);
	}
}
