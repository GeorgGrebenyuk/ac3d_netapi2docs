using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using std;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x0200010E RID: 270
	public class CorridorSectionEditorData : IDisposable
	{
		// Token: 0x060000CF RID: 207
		public extern CorridorSectionEditorData();

		// Token: 0x060000D0 RID: 208
		public static extern CorridorSectionEditorData Instance();

		// Token: 0x060000D1 RID: 209
		public unsafe extern AeccDocumentDataAeccUiRoadway* GetDocumentData();

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D2 RID: 210
		public extern bool IsCorridorSectionEditorCommandActive { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D3 RID: 211
		public extern bool IsCorridorReferenceObject { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D4 RID: 212
		public extern bool IsCSVForCorridorRehab { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D5 RID: 213
		// (set) Token: 0x060000D6 RID: 214
		public extern StationFilterType CurrentStationFilter { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D7 RID: 215
		public extern ObservableCollection<CorridorStation> StationList { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D8 RID: 216
		// (set) Token: 0x060000D9 RID: 217
		public extern CorridorStation CurrentStation { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000DA RID: 218
		public extern bool IsStartStationCurrent { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000DB RID: 219
		public extern bool IsEndStationCurrent { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DC RID: 220
		// (set) Token: 0x060000DD RID: 221
		public extern bool IsOverriddenStationList { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DE RID: 222
		public extern bool IsOverriddenStationsEnabled { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DF RID: 223
		public extern bool IsInUndefinedRegion { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E0 RID: 224
		public extern bool HasPrevRegion { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E1 RID: 225
		public extern bool HasNextRegion { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E2 RID: 226
		public extern bool IsShowPreviewPanel { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E3 RID: 227
		public extern bool bHasRegionStations { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E4 RID: 228
		public extern bool bHasOverridenStations { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E5 RID: 229
		public extern bool bHasUndefinedStations { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E6 RID: 230
		public extern bool IsCurrentStationRegionIntermediate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060000E7 RID: 231
		public unsafe extern CorridorStation getCurrentStation(AeccDocumentDataAeccUiRoadway* pDocData);

		// Token: 0x060000E8 RID: 232
		public unsafe extern ObservableCollection<CorridorStation> getStationListCollection(AeccDocumentDataAeccUiRoadway* pDocData, AcDbObjectId* oidBaseline, vector<double,std::allocator<double>\u0020>* vecStations, vector<double,std::allocator<double>\u0020>* vecOverriddenStation, vector<double,std::allocator<double>\u0020>* vecIntStations, vector<std::pair<double,double>,std::allocator<std::pair<double,double>\u0020>\u0020>* vecRegionStartEndStns);

		// Token: 0x060000E9 RID: 233
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe extern bool isStationInRegion(double* dStation, vector<std::pair<double,double>,std::allocator<std::pair<double,double>\u0020>\u0020>* vecRegionStartEndStns);

		// Token: 0x060000EA RID: 234
		public unsafe extern string getFormatedStation(AcDbDatabase* db, double dStation, [MarshalAs(UnmanagedType.U1)] bool bIntermediate);

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EB RID: 235
		public extern ObservableCollection<CorridorBaseline> BaselineList { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EC RID: 236
		// (set) Token: 0x060000ED RID: 237
		public extern CorridorBaseline CurrentBaseline { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000EE RID: 238
		public extern ObjectId OidCorridor { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EF RID: 239
		public extern string RegionName { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F0 RID: 240
		public extern bool IsSelectBaselineEnabled { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000F1 RID: 241
		// (remove) Token: 0x060000F2 RID: 242
		public extern event CorridorSectionEditorData.CorridorSectionEditorDataEventHandler DataChanged;

		// Token: 0x060000F4 RID: 244
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000F5 RID: 245
		public sealed extern void Dispose();

		// Token: 0x0400012A RID: 298
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060000F7 RID: 247
		public delegate void CorridorSectionEditorDataEventHandler(object sender, CorridorSectionEditorDataEventArgs args);
	}
}
