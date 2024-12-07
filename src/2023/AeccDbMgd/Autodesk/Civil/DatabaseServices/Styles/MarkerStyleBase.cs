using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200005C RID: 92
	[Wrapper("AeccDbMarkerStyle")]
	public class MarkerStyleBase : StyleBase
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003F5 RID: 1013
		// (set) Token: 0x060003F6 RID: 1014
		public extern CustomMarkerType CustomMarkerStyle { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003F7 RID: 1015
		// (set) Token: 0x060003F8 RID: 1016
		public extern CustomMarkerSuperimposeType CustomMarkerSuperimposeStyle { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003F9 RID: 1017
		// (set) Token: 0x060003FA RID: 1018
		public extern string MarkerSymbolName { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003FB RID: 1019
		// (set) Token: 0x060003FC RID: 1020
		public extern double MarkerRotationAngle { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003FD RID: 1021
		// (set) Token: 0x060003FE RID: 1022
		public extern MarkerSizeType SizeType { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003FF RID: 1023
		// (set) Token: 0x06000400 RID: 1024
		public extern double MarkerSize { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000401 RID: 1025
		// (set) Token: 0x06000402 RID: 1026
		public extern Point3d MarkerFixedScale { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000403 RID: 1027
		// (set) Token: 0x06000404 RID: 1028
		public extern MarkerOrientationType Orientation { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000405 RID: 1029
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MarkerStyleBase.GetMarkerDisplayStylePlan instead.", false)]
		public extern DisplayStyle MarkerDisplayStylePlan { get; }

		// Token: 0x06000406 RID: 1030
		public extern DisplayStyle GetMarkerDisplayStylePlan();

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000407 RID: 1031
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MarkerStyleBase.GetMarkerDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle MarkerDisplayStyleModel { get; }

		// Token: 0x06000408 RID: 1032
		public extern DisplayStyle GetMarkerDisplayStyleModel();

		// Token: 0x06000409 RID: 1033
		public extern MarkerStyleBase(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x0600040A RID: 1034
		protected virtual extern uint getAttributeId(markStylePropertyType ptVal);

		// Token: 0x0600040B RID: 1035
		protected virtual extern uint getDisplayComponentId();
	}
}
