using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001A6 RID: 422
	[DefaultMember("Item")]
	internal sealed class PressurePipesBandStyleCollection : BandStyleCollection
	{
		// Token: 0x060001BD RID: 445
		public sealed override extern ObjectId Add(string name);
	}
}
