using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001079 RID: 4217
	public class SettingsDrawing : TreeOidWrapper
	{
		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060021B7 RID: 8631
		public extern SettingsUnitZone UnitZoneSettings { get; }

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060021B8 RID: 8632
		// (set) Token: 0x060021B9 RID: 8633
		public extern bool ApplyTransformSettings { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060021BA RID: 8634
		public extern SettingsTransformation TransformationSettings { get; }

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060021BB RID: 8635
		public extern SettingsAbbreviation AbbreviationsSettings { get; }

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x060021BC RID: 8636
		public extern SettingsAmbient AmbientSettings { get; }

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060021BD RID: 8637
		public extern SettingsObjectLayers ObjectLayerSettings { get; }
	}
}
