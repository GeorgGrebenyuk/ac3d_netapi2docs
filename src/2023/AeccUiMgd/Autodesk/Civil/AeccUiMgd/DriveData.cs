using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000129 RID: 297
	public class DriveData : INotifyPropertyChanged, IDisposable
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000FA RID: 250
		public static extern DriveData CurrentData { get; }

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000FB RID: 251
		// (remove) Token: 0x060000FC RID: 252
		public virtual extern event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000FE RID: 254
		// (set) Token: 0x060000FF RID: 255
		public extern bool Loop { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000100 RID: 256
		// (set) Token: 0x06000101 RID: 257
		public extern bool Reverse { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000102 RID: 258
		// (set) Token: 0x06000103 RID: 259
		public extern double Speed { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000104 RID: 260
		public extern double MinimumSpeed { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000105 RID: 261
		public extern double MaximumSpeed { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		public extern bool ShowTarget { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000108 RID: 264
		// (set) Token: 0x06000109 RID: 265
		public extern bool ShowEyePath { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600010A RID: 266
		// (set) Token: 0x0600010B RID: 267
		public extern bool Driving { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600010C RID: 268
		// (set) Token: 0x0600010D RID: 269
		public extern double CurrentStation { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		public extern double Increment { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000110 RID: 272
		public extern ObservableCollection<string> StationList { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000111 RID: 273
		// (set) Token: 0x06000112 RID: 274
		public extern double TargetOffset { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000113 RID: 275
		// (set) Token: 0x06000114 RID: 276
		public extern double TargetHeight { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000115 RID: 277
		// (set) Token: 0x06000116 RID: 278
		public extern double EyeOffset { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000117 RID: 279
		// (set) Token: 0x06000118 RID: 280
		public extern double EyeHeight { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000119 RID: 281
		// (set) Token: 0x0600011A RID: 282
		public extern double SightDistance { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011B RID: 283
		public extern string FirstLevelPath { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011C RID: 284
		public extern string SecondLevelPath { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011D RID: 285
		public extern bool SecondLevelPathVisible { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600011E RID: 286
		public extern string FirstLevelPathIcon { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600011F RID: 287
		public extern string SecondLevelPathIcon { get; }

		// Token: 0x06000120 RID: 288
		public extern double ValidateSightDistance(double A_0);

		// Token: 0x06000121 RID: 289
		public extern void Reload();

		// Token: 0x06000122 RID: 290
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000123 RID: 291
		public sealed extern void Dispose();

		// Token: 0x06000124 RID: 292
		protected override extern void Finalize();

		// Token: 0x04000155 RID: 341
		private int <SyntheticNonEmptyStructMarker>;
	}
}
