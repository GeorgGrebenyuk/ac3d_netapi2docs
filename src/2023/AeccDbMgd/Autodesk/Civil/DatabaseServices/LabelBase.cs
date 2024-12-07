using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006E RID: 110
	public abstract class LabelBase : Entity, ICommonLabelOptions
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000499 RID: 1177
		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern LabelType LabelType { get; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600049A RID: 1178
		public virtual extern bool AllowsAnchorMarker { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600049B RID: 1179
		public virtual extern bool AllowsDimensionAnchors { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600049C RID: 1180
		public virtual extern bool AllowsDragging { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600049D RID: 1181
		public virtual extern bool AllowsFlipping { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600049E RID: 1182
		public virtual extern bool AllowsLeaderAttachment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600049F RID: 1183
		public virtual extern bool AllowsPinning { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004A0 RID: 1184
		public virtual extern bool AllowsReversing { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004A1 RID: 1185
		public virtual extern LabelRotationType RotationType { get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004A2 RID: 1186
		// (set) Token: 0x060004A3 RID: 1187
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("DefaultDimensionAnchorOption should be an interface only supported by LabelGroup.", false)]
		public virtual extern DimensionAnchorOptionType DefaultDimensionAnchorOption { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004A4 RID: 1188
		// (set) Token: 0x060004A5 RID: 1189
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("DefaultDimensionAnchorValue should be an interface only supported by LabelGroup.", false)]
		public virtual extern double DefaultDimensionAnchorValue { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004A6 RID: 1190
		public extern ObjectId ViewId { get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004A7 RID: 1191
		// (set) Token: 0x060004A8 RID: 1192
		public extern StaggerLabelType AutoStagger { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004A9 RID: 1193
		public extern ObjectId FeatureId { get; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004AA RID: 1194
		// (set) Token: 0x060004AB RID: 1195
		public extern LabelMaskType Mask { get; set; }

		// Token: 0x060004AC RID: 1196
		protected internal extern LabelBase(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x040002FF RID: 767
		protected LabelGroupSubEntity m_SubData;
	}
}
