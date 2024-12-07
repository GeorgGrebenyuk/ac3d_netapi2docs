using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000A2B RID: 2603
	public sealed class SettingsUnitZone : TreeOidWrapper
	{
		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060013AC RID: 5036
		// (set) Token: 0x060013AD RID: 5037
		public extern DrawingUnitType DrawingUnits { get; set; }

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060013AE RID: 5038
		// (set) Token: 0x060013AF RID: 5039
		public extern ImperialToMetricConversionType ImperialToMetricConversion { get; set; }

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060013B0 RID: 5040
		// (set) Token: 0x060013B1 RID: 5041
		public extern AngleUnitType AngularUnits { get; set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060013B2 RID: 5042
		// (set) Token: 0x060013B3 RID: 5043
		public extern bool ScaleObjectsFromOtherDrawings { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060013B4 RID: 5044
		// (set) Token: 0x060013B5 RID: 5045
		public extern double DrawingScale { get; set; }

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060013B6 RID: 5046
		// (set) Token: 0x060013B7 RID: 5047
		public extern bool MatchAutoCADVariables { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060013B8 RID: 5048
		// (set) Token: 0x060013B9 RID: 5049
		public extern string CoordinateSystemCode { get; set; }

		// Token: 0x060013BA RID: 5050
		public static extern SettingsCoordinateSystem GetCoordinateSystemByCode(string code);

		// Token: 0x060013BB RID: 5051
		public static extern string[] GetAllCodes();
	}
}
