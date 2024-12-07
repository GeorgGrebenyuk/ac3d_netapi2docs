using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000854 RID: 2132
	internal static class LandDatabaseExtension
	{
		// Token: 0x0600101E RID: 4126
		public static extern ObjectIdCollection GetCivilAlignmentIds(this Database database);

		// Token: 0x0600101F RID: 4127
		public static extern ObjectIdCollection GetCivilSitelessAlignmentIds(this Database database);

		// Token: 0x06001020 RID: 4128
		public static extern ObjectIdCollection GetCivilSitelessFeatureLineIds(this Database database);

		// Token: 0x06001021 RID: 4129
		public static extern ObjectIdCollection GetCivilSiteIds(this Database database);

		// Token: 0x06001022 RID: 4130
		public static extern ObjectIdCollection GetCivilSurfaceIds(this Database database);

		// Token: 0x06001023 RID: 4131
		public static extern ObjectIdCollection GetCivilAlignmentTableIds(this Database database);

		// Token: 0x06001024 RID: 4132
		public static extern ObjectIdCollection GetCivilLegendTableIds(this Database database);

		// Token: 0x06001025 RID: 4133
		public static extern ObjectIdCollection GetCivilParcelTableIds(this Database database);

		// Token: 0x06001026 RID: 4134
		public static extern ObjectIdCollection GetCivilPointTableIds(this Database database);

		// Token: 0x06001027 RID: 4135
		public static extern ObjectIdCollection GetCivilParcelSegmentTableIds(this Database database);

		// Token: 0x06001028 RID: 4136
		public static extern ObjectIdCollection GetCivilViewFrameGroupIds(this Database database);
	}
}
