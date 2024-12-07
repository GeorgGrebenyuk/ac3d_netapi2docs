using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010CF RID: 4303
	public sealed class SettingsObjectLayers : TreeOidWrapper
	{
		// Token: 0x060022BB RID: 8891
		public extern SettingsObjectLayer GetObjectLayerSetting(SettingsObjectLayerType settingsType);

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x060022BC RID: 8892
		// (set) Token: 0x060022BD RID: 8893
		public extern bool ObjectControlledByLayer { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001A1A RID: 6682
		private int <SyntheticNonEmptyStructMarker>;
	}
}
