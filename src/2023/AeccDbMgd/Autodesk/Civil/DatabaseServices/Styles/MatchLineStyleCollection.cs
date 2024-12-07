using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F5F RID: 3935
	[DefaultMember("Item")]
	public sealed class MatchLineStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001DCC RID: 7628
		public sealed override extern ObjectId Add(string name);
	}
}
