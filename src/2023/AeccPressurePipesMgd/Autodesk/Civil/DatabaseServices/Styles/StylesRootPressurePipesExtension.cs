using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001A9 RID: 425
	public static class StylesRootPressurePipesExtension
	{
		// Token: 0x060001C2 RID: 450
		public static extern PressurePipeStyleCollection GetPressurePipeStyles(this StylesRoot stylesRoot);

		// Token: 0x060001C3 RID: 451
		public static extern PressureFittingStyleCollection GetPressureFittingStyles(this StylesRoot stylesRoot);

		// Token: 0x060001C4 RID: 452
		public static extern PressureAppurtenanceStyleCollection GetPressureAppurtenanceStyles(this StylesRoot stylesRoot);

		// Token: 0x060001C5 RID: 453
		public static extern PressurePartListCollection GetPressurePartLists(this StylesRoot stylesRoot);
	}
}
