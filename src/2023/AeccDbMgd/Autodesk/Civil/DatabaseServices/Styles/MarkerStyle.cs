using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200005D RID: 93
	[Wrapper("AeccDbRoadwayMarkerStyle")]
	public class MarkerStyle : MarkerStyleBase
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600040C RID: 1036
		// (set) Token: 0x0600040D RID: 1037
		public extern MarkerDisplayType MarkerType { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600040E RID: 1038
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MarkerStyle.GetMarkerDisplayStyleProfile instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public virtual extern DisplayStyle MarkerDisplayStyleProfile { get; }

		// Token: 0x0600040F RID: 1039
		public virtual extern DisplayStyle GetMarkerDisplayStyleProfile();

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000410 RID: 1040
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MarkerStyle.GetMarkerDisplayStyleSection instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public virtual extern DisplayStyle MarkerDisplayStyleSection { get; }

		// Token: 0x06000411 RID: 1041
		public virtual extern DisplayStyle GetMarkerDisplayStyleSection();

		// Token: 0x06000412 RID: 1042
		protected internal extern MarkerStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000413 RID: 1043
		protected override extern uint getAttributeId(markStylePropertyType ptVal);

		// Token: 0x06000414 RID: 1044
		protected override extern uint getDisplayComponentId();
	}
}
