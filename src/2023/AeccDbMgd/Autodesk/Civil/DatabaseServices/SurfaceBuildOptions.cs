using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A1D RID: 2589
	public sealed class SurfaceBuildOptions
	{
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600136F RID: 4975
		// (set) Token: 0x06001370 RID: 4976
		public extern bool CopyDeletedDependentObjects { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001371 RID: 4977
		// (set) Token: 0x06001372 RID: 4978
		public extern bool ExecludeMinimumElevation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001373 RID: 4979
		// (set) Token: 0x06001374 RID: 4980
		public extern double MinimumElevation { get; set; }

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001375 RID: 4981
		// (set) Token: 0x06001376 RID: 4982
		public extern bool ExecludeMaximumElevation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001377 RID: 4983
		// (set) Token: 0x06001378 RID: 4984
		public extern double MaximumElevation { get; set; }

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001379 RID: 4985
		// (set) Token: 0x0600137A RID: 4986
		public extern bool UseMaximumAngle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600137B RID: 4987
		// (set) Token: 0x0600137C RID: 4988
		public extern double MaximumAngleBetweenAdjacentTinLines { get; set; }

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600137D RID: 4989
		// (set) Token: 0x0600137E RID: 4990
		public extern bool UseMaximumTriangleLength { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600137F RID: 4991
		// (set) Token: 0x06001380 RID: 4992
		public extern double MaximumTriangleLength { get; set; }

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001381 RID: 4993
		// (set) Token: 0x06001382 RID: 4994
		public extern bool NeedConvertBreaklines { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001383 RID: 4995
		// (set) Token: 0x06001384 RID: 4996
		public extern CrossingBreaklinesElevationType CrossingBreaklinesElevationOption { get; set; }

		// Token: 0x04001407 RID: 5127
		private int <SyntheticNonEmptyStructMarker>;
	}
}
