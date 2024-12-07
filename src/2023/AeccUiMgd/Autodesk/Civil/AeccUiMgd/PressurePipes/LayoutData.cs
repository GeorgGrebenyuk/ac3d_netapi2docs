using System;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x020000A5 RID: 165
	public class LayoutData : LayoutListData
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600005C RID: 92
		public static extern LayoutData CurrentData { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600005D RID: 93
		// (set) Token: 0x0600005E RID: 94
		public extern PressureListData CurrentSurface { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600005F RID: 95
		// (set) Token: 0x06000060 RID: 96
		public extern PressureListData CurrentAlignment { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000061 RID: 97
		// (set) Token: 0x06000062 RID: 98
		public extern PressureListData CurrentPartList { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000063 RID: 99
		public new extern ObservableCollection<PressurePartData> PressurePipeList { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000064 RID: 100
		// (set) Token: 0x06000065 RID: 101
		public extern PressurePartData CurrentPressurePipe { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000066 RID: 102
		public new extern ObservableCollection<PressurePartData> FittingList { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000067 RID: 103
		// (set) Token: 0x06000068 RID: 104
		public extern PressurePartData CurrentFitting { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000069 RID: 105
		public new extern ObservableCollection<PressurePartData> AppurtenanceList { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006A RID: 106
		// (set) Token: 0x0600006B RID: 107
		public extern PressurePartData CurrentAppurtenance { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006C RID: 108
		// (set) Token: 0x0600006D RID: 109
		public extern double Cover { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006E RID: 110
		public extern bool IsCoverEnabled { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006F RID: 111
		// (set) Token: 0x06000070 RID: 112
		public extern bool IsCompassEnabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x06000072 RID: 114
		public extern bool IsCompassSnappingEnabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000073 RID: 115
		// (set) Token: 0x06000074 RID: 116
		public extern Color CompassColor { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117
		// (set) Token: 0x06000076 RID: 118
		public extern uint CompassSize { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000077 RID: 119
		// (set) Token: 0x06000078 RID: 120
		public extern double CompassRotateIncrement { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000079 RID: 121
		// (set) Token: 0x0600007A RID: 122
		public extern double CompassTickmarkIncrement { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007B RID: 123
		public extern string NetworkName { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007C RID: 124
		// (set) Token: 0x0600007D RID: 125
		public extern ObjectId NetworkId { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007E RID: 126
		public extern LayoutCommandStates CommandStates { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007F RID: 127
		public extern PanoramaStates Panorama { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000080 RID: 128
		// (set) Token: 0x06000081 RID: 129
		public extern bool AutoAddBends { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000082 RID: 130
		public extern void ExcuteCommand(string cmdName);

		// Token: 0x06000083 RID: 131
		public extern void Reload();

		// Token: 0x06000084 RID: 132
		public override extern void NotifyPropertyChanged(string propertyName);

		// Token: 0x06000085 RID: 133
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040000C9 RID: 201
		public const string NetworkNamePropName = "NetworkName";

		// Token: 0x040000CA RID: 202
		private int <SyntheticNonEmptyStructMarker>;
	}
}
