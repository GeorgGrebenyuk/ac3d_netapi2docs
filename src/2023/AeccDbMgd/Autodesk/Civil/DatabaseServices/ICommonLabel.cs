using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006C RID: 108
	public interface ICommonLabel
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600046D RID: 1133
		AnchorInfo AnchorInfo { get; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600046E RID: 1134
		AnchorInfo DimensionAnchorInfo { get; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600046F RID: 1135
		bool Dragged { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000470 RID: 1136
		// (set) Token: 0x06000471 RID: 1137
		ObjectId AnchorMarkerStyleId { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000472 RID: 1138
		// (set) Token: 0x06000473 RID: 1139
		DimensionAnchorOptionType DimensionAnchorOption { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000474 RID: 1140
		// (set) Token: 0x06000475 RID: 1141
		double DimensionAnchorValue { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000476 RID: 1142
		// (set) Token: 0x06000477 RID: 1143
		Vector3d DraggedOffset { get; set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000478 RID: 1144
		// (set) Token: 0x06000479 RID: 1145
		bool Flipped { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600047A RID: 1146
		// (set) Token: 0x0600047B RID: 1147
		LeaderAttachmentBehaviorType LeaderAttachment { get; set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600047C RID: 1148
		// (set) Token: 0x0600047D RID: 1149
		LeaderTailVisibilityType LeaderTailVisibility { get; set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600047E RID: 1150
		// (set) Token: 0x0600047F RID: 1151
		LeaderVisibilityType LeaderVisibility { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000480 RID: 1152
		// (set) Token: 0x06000481 RID: 1153
		bool Pinned { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000482 RID: 1154
		// (set) Token: 0x06000483 RID: 1155
		bool Reversed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000484 RID: 1156
		bool CanRotate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000485 RID: 1157
		// (set) Token: 0x06000486 RID: 1158
		double RotationAngle { get; set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000487 RID: 1159
		// (set) Token: 0x06000488 RID: 1160
		double AnchorMarkerRotationAngle { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000489 RID: 1161
		// (set) Token: 0x0600048A RID: 1162
		ObjectId StyleId { get; set; }

		// Token: 0x0600048B RID: 1163
		void Reset();

		// Token: 0x0600048C RID: 1164
		void ResetLocation();

		// Token: 0x0600048D RID: 1165
		void ResetProperties();

		// Token: 0x0600048E RID: 1166
		TextJustificationType GetTextComponentJustificationOverride(ObjectId labelStyleComponentId);

		// Token: 0x0600048F RID: 1167
		string GetTextComponentOverride(ObjectId labelStyleComponentId);

		// Token: 0x06000490 RID: 1168
		ObjectIdCollection GetTextComponentIds();

		// Token: 0x06000491 RID: 1169
		void ClearAllTextComponentOverrides();

		// Token: 0x06000492 RID: 1170
		[return: MarshalAs(UnmanagedType.U1)]
		bool IsTextComponentOverriden(ObjectId labelStyleComponentId);

		// Token: 0x06000493 RID: 1171
		void SetTextComponentJustificationOverride(ObjectId labelStyleComponentId, TextJustificationType textJustificationType);

		// Token: 0x06000494 RID: 1172
		void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride, TextJustificationType textJustificationType);

		// Token: 0x06000495 RID: 1173
		void SetTextComponentOverride(ObjectId labelStyleComponentId, string textOverride);

		// Token: 0x06000496 RID: 1174
		ObjectId GetReferenceTextTarget(ObjectId referenceTextComponentId);

		// Token: 0x06000497 RID: 1175
		void SetReferenceTextTarget(ObjectId referenceTextComponentId, ObjectId referenceObjectId);
	}
}
