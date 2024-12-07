using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F1 RID: 241
	[Wrapper("AeccDbLabel")]
	public class Label : LabelBase, ICommonLabel
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000B03 RID: 2819
		public virtual extern AnchorInfo AnchorInfo { get; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000B04 RID: 2820
		public virtual extern AnchorInfo DimensionAnchorInfo { get; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000B05 RID: 2821
		public virtual extern bool Dragged { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06000B06 RID: 2822
		public virtual extern TextJustificationType GetTextComponentJustificationOverride(ObjectId labelStyleComponentId);

		// Token: 0x06000B07 RID: 2823
		public virtual extern string GetTextComponentOverride(ObjectId labelStyleComponentId);

		// Token: 0x06000B08 RID: 2824
		public virtual extern ObjectIdCollection GetTextComponentIds();

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000B09 RID: 2825
		// (set) Token: 0x06000B0A RID: 2826
		public virtual extern ObjectId AnchorMarkerStyleId { get; set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000B0B RID: 2827
		// (set) Token: 0x06000B0C RID: 2828
		public virtual extern DimensionAnchorOptionType DimensionAnchorOption { get; set; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000B0D RID: 2829
		// (set) Token: 0x06000B0E RID: 2830
		public virtual extern double DimensionAnchorValue { get; set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000B0F RID: 2831
		// (set) Token: 0x06000B10 RID: 2832
		public virtual extern Vector3d DraggedOffset { get; [Obsolete("Use property LabelLocation instead.", false)] [DeprecatedVersion(CivilVersion.Civil2013)] set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000B11 RID: 2833
		// (set) Token: 0x06000B12 RID: 2834
		public virtual extern Point3d LabelLocation { get; set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000B13 RID: 2835
		// (set) Token: 0x06000B14 RID: 2836
		public virtual extern bool Flipped { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000B15 RID: 2837
		// (set) Token: 0x06000B16 RID: 2838
		public virtual extern LeaderAttachmentBehaviorType LeaderAttachment { get; set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000B17 RID: 2839
		// (set) Token: 0x06000B18 RID: 2840
		public virtual extern LeaderTailVisibilityType LeaderTailVisibility { get; set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000B19 RID: 2841
		// (set) Token: 0x06000B1A RID: 2842
		public virtual extern LeaderVisibilityType LeaderVisibility { get; set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000B1B RID: 2843
		// (set) Token: 0x06000B1C RID: 2844
		public virtual extern bool Pinned { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000B1D RID: 2845
		// (set) Token: 0x06000B1E RID: 2846
		public virtual extern bool Reversed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000B1F RID: 2847
		public virtual extern bool CanRotate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000B20 RID: 2848
		// (set) Token: 0x06000B21 RID: 2849
		public virtual extern double RotationAngle { get; set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000B22 RID: 2850
		// (set) Token: 0x06000B23 RID: 2851
		public virtual extern double AnchorMarkerRotationAngle { get; set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000B24 RID: 2852
		// (set) Token: 0x06000B25 RID: 2853
		public sealed override extern ObjectId StyleId { get; set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000B26 RID: 2854
		// (set) Token: 0x06000B27 RID: 2855
		public override extern string StyleName { get; set; }

		// Token: 0x06000B28 RID: 2856
		public virtual extern void ClearAllTextComponentOverrides();

		// Token: 0x06000B29 RID: 2857
		[return: MarshalAs(UnmanagedType.U1)]
		public virtual extern bool IsTextComponentOverriden(ObjectId labelStyleComponentId);

		// Token: 0x06000B2A RID: 2858
		public virtual extern void Reset();

		// Token: 0x06000B2B RID: 2859
		public virtual extern void ResetLocation();

		// Token: 0x06000B2C RID: 2860
		public virtual extern void ResetProperties();

		// Token: 0x06000B2D RID: 2861
		public virtual extern void SetTextComponentJustificationOverride(ObjectId labelStyleComponentId, TextJustificationType textJustificationType);

		// Token: 0x06000B2E RID: 2862
		public virtual extern void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride, TextJustificationType textJustificationType);

		// Token: 0x06000B2F RID: 2863
		public virtual extern void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride);

		// Token: 0x06000B30 RID: 2864
		public virtual extern ObjectId GetReferenceTextTarget(ObjectId referenceTextComponentId);

		// Token: 0x06000B31 RID: 2865
		public virtual extern void SetReferenceTextTarget(ObjectId referenceTextComponentId, ObjectId referenceObjectId);

		// Token: 0x06000B32 RID: 2866
		protected internal extern Label(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000B33 RID: 2867
		protected virtual extern void checkStyleId(ObjectId styleId);
	}
}
