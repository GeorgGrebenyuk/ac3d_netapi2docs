using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CFD RID: 3325
	public sealed class SettingsCmdCreateSurfaceWaterdrop : SettingsSurface
	{
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060017B4 RID: 6068
		public extern SettingsCmdCreateSurfaceWaterdrop.SettingsCmdWaterdropPath WaterdropPath { get; }

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060017B5 RID: 6069
		public extern SettingsCmdCreateSurfaceWaterdrop.SettingsCmdWaterdropMarker WaterdropMarker { get; }

		// Token: 0x02000CFE RID: 3326
		public sealed class SettingsCmdWaterdropPath : TreeOidWrapper
		{
			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x060017B6 RID: 6070
			public extern PropertyLayer PathLayer { get; }

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x060017B7 RID: 6071
			public extern PropertyEnum<WaterdropObjectType> PathObjectType { get; }
		}

		// Token: 0x02000CFF RID: 3327
		public sealed class SettingsCmdWaterdropMarker : TreeOidWrapper
		{
			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x060017B8 RID: 6072
			public extern PropertyBoolean PlaceMarkerAtStartPoint { get; }

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x060017B9 RID: 6073
			public extern PropertyString StartPointMarkerStyle { get; }

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x060017BA RID: 6074
			public extern PropertyObjectId StartPointMarkerStyleId { get; }
		}
	}
}
