using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001075 RID: 4213
	[DefaultMember("Item")]
	public sealed class PipeStyleCollection : StyleCollectionBase
	{
		// Token: 0x060021AC RID: 8620
		public sealed override extern ObjectId Add(string name);
	}
}
