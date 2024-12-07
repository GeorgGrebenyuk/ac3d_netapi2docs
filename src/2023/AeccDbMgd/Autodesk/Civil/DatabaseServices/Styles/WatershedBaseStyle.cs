using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F8A RID: 3978
	public class WatershedBaseStyle : CivilWrapper<AeccDbSurfaceStyle>
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06001EEE RID: 7918
		// (set) Token: 0x06001EEF RID: 7919
		public extern Color Color { get; set; }

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06001EF0 RID: 7920
		// (set) Token: 0x06001EF1 RID: 7921
		public extern string LinetypeName { get; set; }

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06001EF2 RID: 7922
		// (set) Token: 0x06001EF3 RID: 7923
		public extern ObjectId LinetypeId { get; set; }

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06001EF4 RID: 7924
		// (set) Token: 0x06001EF5 RID: 7925
		public extern bool UseHatching { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06001EF6 RID: 7926
		// (set) Token: 0x06001EF7 RID: 7927
		[DeprecatedVersion(CivilVersion.Civil2012)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.WatershedBaseStyle.Hatch instead.", false)]
		public extern string HatchPattern { get; set; }

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06001EF8 RID: 7928
		public extern SurfaceHatchInfo Hatch { get; }

		// Token: 0x04001861 RID: 6241
		private int <SyntheticNonEmptyStructMarker>;
	}
}
