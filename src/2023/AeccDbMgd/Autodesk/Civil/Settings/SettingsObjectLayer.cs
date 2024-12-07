using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010CE RID: 4302
	public sealed class SettingsObjectLayer : TreeOidWrapper
	{
		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x060022B0 RID: 8880
		public extern SettingsObjectLayerType ObjectType { get; }

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x060022B1 RID: 8881
		// (set) Token: 0x060022B2 RID: 8882
		public extern string ModifierValue { get; set; }

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x060022B3 RID: 8883
		// (set) Token: 0x060022B4 RID: 8884
		public extern string LayerName { get; set; }

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x060022B5 RID: 8885
		// (set) Token: 0x060022B6 RID: 8886
		public extern ObjectId LayerId { get; set; }

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x060022B7 RID: 8887
		// (set) Token: 0x060022B8 RID: 8888
		public extern ObjectLayerModifierType Modifier { get; set; }

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x060022B9 RID: 8889
		// (set) Token: 0x060022BA RID: 8890
		public extern bool Locked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001A19 RID: 6681
		private int <SyntheticNonEmptyStructMarker>;
	}
}
