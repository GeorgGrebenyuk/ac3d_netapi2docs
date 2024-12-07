using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BB RID: 187
	[Wrapper("AeccDbIntersectionStyle")]
	public sealed class IntersectionStyle : StyleBase
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000831 RID: 2097
		public extern ObjectId MarkerStyleId { get; }

		// Token: 0x06000832 RID: 2098
		public extern DisplayStyle GetDisplayStylePlan();

		// Token: 0x06000833 RID: 2099
		public extern DisplayStyle GetDisplayStyleModel();
	}
}
