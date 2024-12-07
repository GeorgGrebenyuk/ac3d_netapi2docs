using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200018F RID: 399
	public static class TableStylesRootPressurePipesExtension
	{
		// Token: 0x060001B4 RID: 436
		public static extern TableStyleCollection GetPressurePipeTableStyles(this TableStylesRoot tableStylesRoot);

		// Token: 0x060001B5 RID: 437
		public static extern TableStyleCollection GetPressureFittingTableStyles(this TableStylesRoot tableStylesRoot);

		// Token: 0x060001B6 RID: 438
		public static extern TableStyleCollection GetPressureAppurtenanceTableStyles(this TableStylesRoot tableStylesRoot);
	}
}
