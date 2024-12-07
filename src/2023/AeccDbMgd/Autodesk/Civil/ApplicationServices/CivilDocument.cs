using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;
using Autodesk.Civil.Runtime;
using Autodesk.Civil.Settings;

namespace Autodesk.Civil.ApplicationServices
{
	// Token: 0x02000042 RID: 66
	public sealed class CivilDocument : DisposableWrapper
	{
		// Token: 0x060001B0 RID: 432
		public static extern CivilDocument GetCivilDocument(Database database);

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B1 RID: 433
		public extern SettingsRoot Settings { get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B2 RID: 434
		public extern StylesRoot Styles { get; }

		// Token: 0x060001B3 RID: 435
		public extern ObjectIdCollection GetAlignmentIds();

		// Token: 0x060001B4 RID: 436
		public extern ObjectIdCollection GetSitelessAlignmentIds();

		// Token: 0x060001B5 RID: 437
		public extern ObjectIdCollection GetSitelessFeatureLineIds();

		// Token: 0x060001B6 RID: 438
		public extern ObjectId GetSitelessAlignmentId(string name);

		// Token: 0x060001B7 RID: 439
		public extern ObjectIdCollection GetSiteIds();

		// Token: 0x060001B8 RID: 440
		public extern ObjectIdCollection GetSurfaceIds();

		// Token: 0x060001B9 RID: 441
		public extern ObjectIdCollection GetAlignmentTableIds();

		// Token: 0x060001BA RID: 442
		public extern ObjectIdCollection GetLegendTableIds();

		// Token: 0x060001BB RID: 443
		public extern ObjectIdCollection GetParcelTableIds();

		// Token: 0x060001BC RID: 444
		public extern ObjectIdCollection GetPointTableIds();

		// Token: 0x060001BD RID: 445
		public extern ObjectIdCollection GetParcelSegmentTableIds();

		// Token: 0x060001BE RID: 446
		public extern ObjectIdCollection GetAllPointIds();

		// Token: 0x060001BF RID: 447
		public extern ObjectIdCollection GetViewFrameGroupIds();

		// Token: 0x060001C0 RID: 448
		public extern ObjectIdCollection GetNoteLabelIds();

		// Token: 0x060001C1 RID: 449
		public extern ObjectIdCollection GetGeneralSegmentLabelIds();

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C2 RID: 450
		public extern CogoPointCollection CogoPoints { get; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C3 RID: 451
		public extern PointGroupCollection PointGroups { get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C4 RID: 452
		public extern UDPClassificationCollection PointUDPClassifications { get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C5 RID: 453
		public extern UDPCollection PointUDPs { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C6 RID: 454
		public extern UDPClassificationCollection ParcelUDPClassifications { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C7 RID: 455
		public extern UDPCollection ParcelUDPs { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001C8 RID: 456
		public extern PipeNetworkState NetworkState { get; }

		// Token: 0x060001C9 RID: 457
		public extern ObjectIdCollection GetPipeNetworkIds();

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CA RID: 458
		public extern CorridorState CorridorState { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CB RID: 459
		public extern CorridorCollection CorridorCollection { get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CC RID: 460
		public extern AssemblyCollection AssemblyCollection { get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CD RID: 461
		public extern SubassemblyCollection SubassemblyCollection { get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CE RID: 462
		public extern bool IsCorridorSectionViewActive { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CF RID: 463
		public extern bool IsSectionEditorCorridorReferenceObject { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001D0 RID: 464
		public extern bool IsDriveActive { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060001D1 RID: 465
		public extern ObjectIdCollection GetIntersectionIds();
	}
}
