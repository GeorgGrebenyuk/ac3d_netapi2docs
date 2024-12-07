using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001A8 RID: 424
	public static class LabelStylesRootPressurePipesExtension
	{
		// Token: 0x060001BF RID: 447
		public static extern LabelStylesPressurePipeRoot GetPressurePipeLabelStyles(this LabelStylesRoot stylesRoot);

		// Token: 0x060001C0 RID: 448
		public static extern LabelStylesPressureFittingRoot GetPressureFittingLabelStyles(this LabelStylesRoot stylesRoot);

		// Token: 0x060001C1 RID: 449
		public static extern LabelStylesPressureAppurtenanceRoot GetPressureAppurtenanceLabelStyles(this LabelStylesRoot stylesRoot);
	}
}
