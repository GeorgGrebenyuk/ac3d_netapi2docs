using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020007BE RID: 1982
	public class LabelGroupSubEntity : ICommonLabelOptions, ICommonLabel
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000F33 RID: 3891
		public extern LabelGroup Parent { get; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000F34 RID: 3892
		public extern uint Index { get; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000F35 RID: 3893
		public virtual extern bool AllowsAnchorMarker { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000F36 RID: 3894
		public virtual extern bool AllowsDimensionAnchors { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000F37 RID: 3895
		public virtual extern bool AllowsDragging { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000F38 RID: 3896
		public virtual extern bool AllowsFlipping { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000F39 RID: 3897
		public virtual extern bool AllowsLeaderAttachment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000F3A RID: 3898
		public virtual extern bool AllowsPinning { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000F3B RID: 3899
		public virtual extern bool AllowsReversing { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000F3C RID: 3900
		// (set) Token: 0x06000F3D RID: 3901
		[Obsolete("Use Autodesk.Civil.DatabaseServices.LabelGroup.DefaultDimensionAnchorOption instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public virtual extern DimensionAnchorOptionType DefaultDimensionAnchorOption { get; set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000F3E RID: 3902
		// (set) Token: 0x06000F3F RID: 3903
		[Obsolete("Use Autodesk.Civil.DatabaseServices.LabelGroup.DefaultDimensionAnchorValue instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public virtual extern double DefaultDimensionAnchorValue { get; set; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000F40 RID: 3904
		public virtual extern LabelRotationType RotationType { get; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000F41 RID: 3905
		public virtual extern AnchorInfo AnchorInfo { get; }

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000F42 RID: 3906
		public virtual extern AnchorInfo DimensionAnchorInfo { get; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000F43 RID: 3907
		public virtual extern bool Dragged { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000F44 RID: 3908
		// (set) Token: 0x06000F45 RID: 3909
		public virtual extern ObjectId AnchorMarkerStyleId { get; set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000F46 RID: 3910
		// (set) Token: 0x06000F47 RID: 3911
		public virtual extern DimensionAnchorOptionType DimensionAnchorOption { get; set; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000F48 RID: 3912
		// (set) Token: 0x06000F49 RID: 3913
		public virtual extern double DimensionAnchorValue { get; set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000F4A RID: 3914
		// (set) Token: 0x06000F4B RID: 3915
		public virtual extern Vector3d DraggedOffset { get; [DeprecatedVersion(CivilVersion.Civil2013)] [Obsolete("Use property LabelLocation instead.", false)] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000F4C RID: 3916
		// (set) Token: 0x06000F4D RID: 3917
		public virtual extern Point3d LabelLocation { get; set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000F4E RID: 3918
		// (set) Token: 0x06000F4F RID: 3919
		public virtual extern bool Flipped { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000F50 RID: 3920
		// (set) Token: 0x06000F51 RID: 3921
		public virtual extern LeaderAttachmentBehaviorType LeaderAttachment { get; set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000F52 RID: 3922
		// (set) Token: 0x06000F53 RID: 3923
		public virtual extern LeaderTailVisibilityType LeaderTailVisibility { get; set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000F54 RID: 3924
		// (set) Token: 0x06000F55 RID: 3925
		public virtual extern LeaderVisibilityType LeaderVisibility { get; set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000F56 RID: 3926
		// (set) Token: 0x06000F57 RID: 3927
		public virtual extern bool Pinned { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000F58 RID: 3928
		// (set) Token: 0x06000F59 RID: 3929
		public virtual extern bool Reversed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000F5A RID: 3930
		public virtual extern bool CanRotate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000F5B RID: 3931
		// (set) Token: 0x06000F5C RID: 3932
		public virtual extern double RotationAngle { get; set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000F5D RID: 3933
		// (set) Token: 0x06000F5E RID: 3934
		public virtual extern double AnchorMarkerRotationAngle { get; set; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000F5F RID: 3935
		// (set) Token: 0x06000F60 RID: 3936
		public virtual extern bool Visibility { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000F61 RID: 3937
		// (set) Token: 0x06000F62 RID: 3938
		public virtual extern ObjectId StyleId { get; set; }

		// Token: 0x06000F63 RID: 3939
		public virtual extern void Reset();

		// Token: 0x06000F64 RID: 3940
		public virtual extern void ResetLocation();

		// Token: 0x06000F65 RID: 3941
		public virtual extern void ResetProperties();

		// Token: 0x06000F66 RID: 3942
		public virtual extern TextJustificationType GetTextComponentJustificationOverride(ObjectId labelStyleComponentId);

		// Token: 0x06000F67 RID: 3943
		public virtual extern string GetTextComponentOverride(ObjectId labelStyleComponentId);

		// Token: 0x06000F68 RID: 3944
		public virtual extern ObjectIdCollection GetTextComponentIds();

		// Token: 0x06000F69 RID: 3945
		public virtual extern void ClearAllTextComponentOverrides();

		// Token: 0x06000F6A RID: 3946
		[return: MarshalAs(UnmanagedType.U1)]
		public virtual extern bool IsTextComponentOverriden(ObjectId newVal);

		// Token: 0x06000F6B RID: 3947
		public virtual extern void SetTextComponentJustificationOverride(ObjectId labelStyleComponentId, TextJustificationType textJustificationType);

		// Token: 0x06000F6C RID: 3948
		public virtual extern void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride, TextJustificationType textJustificationType);

		// Token: 0x06000F6D RID: 3949
		public virtual extern void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride);

		// Token: 0x06000F6E RID: 3950
		public virtual extern ObjectId GetReferenceTextTarget(ObjectId referenceTextComponentId);

		// Token: 0x06000F6F RID: 3951
		public virtual extern void SetReferenceTextTarget(ObjectId referenceTextComponentId, ObjectId referenceObjectId);

		// Token: 0x040011C4 RID: 4548
		private int <SyntheticNonEmptyStructMarker>;
	}
}
