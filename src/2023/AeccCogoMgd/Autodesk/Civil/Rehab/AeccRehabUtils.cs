using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Rehab
{
	// Token: 0x0200003D RID: 61
	public class AeccRehabUtils : IDisposable
	{
		// Token: 0x06000014 RID: 20
		public static extern string FormatStationRehab(double station);

		// Token: 0x06000015 RID: 21
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseStationRehab(string input, ref double output);

		// Token: 0x06000016 RID: 22
		public static extern string FormatSlope(double slope);

		// Token: 0x06000017 RID: 23
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseSlope(string input, ref double output);

		// Token: 0x06000018 RID: 24
		public static extern string FormatRelativeGrade(double relGrade);

		// Token: 0x06000019 RID: 25
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseRelativeGrade(string input, ref double output);

		// Token: 0x0600001A RID: 26
		public static extern string FormatElevation(double elevation);

		// Token: 0x0600001B RID: 27
		public static extern string FormatDimension(double dimension);

		// Token: 0x0600001C RID: 28
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseElevation(string input, ref double output);

		// Token: 0x0600001D RID: 29
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseDimension(string input, ref double output);

		// Token: 0x0600001E RID: 30
		public static extern string FormatDistance(double distance);

		// Token: 0x0600001F RID: 31
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseDistance(string input, ref double output);

		// Token: 0x06000020 RID: 32
		public static extern string FormatLaneBreakSlopeLimit(double distance);

		// Token: 0x06000021 RID: 33
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseLaneBreakSlopeLimit(string input, ref double output);

		// Token: 0x06000022 RID: 34
		public static extern string FormatRelativeGradientLimit(double distance);

		// Token: 0x06000023 RID: 35
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ParseRelativeGradientLimit(string input, ref double output);

		// Token: 0x06000024 RID: 36
		public static extern double GetLaneBreakSlopeLimit();

		// Token: 0x06000025 RID: 37
		public static extern double GetRelativeGradientLimit();

		// Token: 0x06000026 RID: 38
		public static extern void SetRelativeGradientLimit(double maxRelativeGradient);

		// Token: 0x06000027 RID: 39
		public static extern void SetLaneBreakSlopeLimit(double maxLaneBreakSlope);

		// Token: 0x06000028 RID: 40
		public static extern string FormatArea(double area);

		// Token: 0x06000029 RID: 41
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600002A RID: 42
		public sealed extern void Dispose();
	}
}
