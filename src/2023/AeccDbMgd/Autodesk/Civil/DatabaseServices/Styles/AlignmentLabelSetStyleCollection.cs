using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000DFE RID: 3582
	[DefaultMember("Item")]
	public sealed class AlignmentLabelSetStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001AFE RID: 6910
		public sealed override extern ObjectId Add(string name);
	}
}
