using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200086A RID: 2154
	public abstract class PointGroupOverrideInfo
	{
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001042 RID: 4162
		// (set) Token: 0x06001043 RID: 4163
		public extern PointGroupOverrideType ActiveOverrideType { get; set; }

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001044 RID: 4164
		// (set) Token: 0x06001045 RID: 4165
		public extern ObjectId XDRefId { get; set; }

		// Token: 0x04001272 RID: 4722
		private int <SyntheticNonEmptyStructMarker>;
	}
}
