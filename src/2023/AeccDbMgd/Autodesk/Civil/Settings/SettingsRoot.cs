using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001078 RID: 4216
	public sealed class SettingsRoot : TreeOidWrapper
	{
		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060021B1 RID: 8625
		public extern SettingsTag TagSettings { get; }

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060021B2 RID: 8626
		public extern SettingsDrawing DrawingSettings { get; }

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060021B3 RID: 8627
		// (set) Token: 0x060021B4 RID: 8628
		public extern string AssociateShortcutProjectId { get; set; }

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060021B5 RID: 8629
		public extern SettingsLandXML LandXMLSettings { get; }

		// Token: 0x060021B6 RID: 8630
		public extern T GetSettings<T>() where T : SettingsAmbient;
	}
}
