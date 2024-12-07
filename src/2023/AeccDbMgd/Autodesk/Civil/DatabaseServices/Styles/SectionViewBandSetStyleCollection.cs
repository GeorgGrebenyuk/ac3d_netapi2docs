using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB8 RID: 4024
	[DefaultMember("Item")]
	public sealed class SectionViewBandSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001FD1 RID: 8145
		public sealed override extern ObjectId Add(string name);
	}
}
