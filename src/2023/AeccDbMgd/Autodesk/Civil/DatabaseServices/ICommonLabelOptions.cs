using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006B RID: 107
	public interface ICommonLabelOptions
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000461 RID: 1121
		bool AllowsAnchorMarker { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000462 RID: 1122
		bool AllowsDimensionAnchors { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000463 RID: 1123
		bool AllowsDragging { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000464 RID: 1124
		bool AllowsFlipping { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000465 RID: 1125
		bool AllowsLeaderAttachment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000466 RID: 1126
		bool AllowsPinning { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000467 RID: 1127
		bool AllowsReversing { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000468 RID: 1128
		// (set) Token: 0x06000469 RID: 1129
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("DefaultDimensionAnchorOption should be an interface only supported by LabelGroup.", false)]
		DimensionAnchorOptionType DefaultDimensionAnchorOption { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600046A RID: 1130
		// (set) Token: 0x0600046B RID: 1131
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("DefaultDimensionAnchorValue should be an interface only supported by LabelGroup.", false)]
		double DefaultDimensionAnchorValue { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600046C RID: 1132
		LabelRotationType RotationType { get; }
	}
}
