using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200018B RID: 395
	[DefaultMember("Item")]
	public sealed class PressureAppurtenanceStyleCollection : StyleCollectionBase
	{
		// Token: 0x060001A8 RID: 424
		public sealed override extern ObjectId Add(string name);
	}
}
