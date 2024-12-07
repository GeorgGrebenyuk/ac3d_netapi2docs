using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EBC RID: 3772
	public class ProfileViewBandItem : ProfileViewBandSetItem
	{
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06001C9C RID: 7324
		public extern ObjectId AlignmentId { get; }

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06001C9D RID: 7325
		// (set) Token: 0x06001C9E RID: 7326
		public extern ObjectId Profile1Id { get; set; }

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06001C9F RID: 7327
		// (set) Token: 0x06001CA0 RID: 7328
		public extern ObjectId Profile2Id { get; set; }

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06001CA1 RID: 7329
		// (set) Token: 0x06001CA2 RID: 7330
		public extern ObjectId DataSourceId { get; set; }

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06001CA3 RID: 7331
		// (set) Token: 0x06001CA4 RID: 7332
		public extern string MaterialName { get; set; }

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06001CA5 RID: 7333
		protected unsafe override extern char* SettingsNode { get; }
	}
}
