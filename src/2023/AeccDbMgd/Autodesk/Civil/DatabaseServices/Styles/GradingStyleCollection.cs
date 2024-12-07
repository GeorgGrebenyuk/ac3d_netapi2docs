using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F4F RID: 3919
	[DefaultMember("Item")]
	public sealed class GradingStyleCollection : StyleCollectionBase
	{
		// Token: 0x06001D8C RID: 7564
		public extern void SetCenterMarkerVisable([MarshalAs(UnmanagedType.U1)] bool isVisable);

		// Token: 0x06001D8D RID: 7565
		public extern void SetSlopePatternVisable([MarshalAs(UnmanagedType.U1)] bool isVisable);

		// Token: 0x06001D8E RID: 7566
		public sealed override extern ObjectId Add(string name);
	}
}
