using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000EBB RID: 3771
	public class ProfileViewBandSetItem : BandSetItem
	{
		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06001C8D RID: 7309
		// (set) Token: 0x06001C8E RID: 7310
		public override extern double MajorInterval { get; set; }

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06001C8F RID: 7311
		// (set) Token: 0x06001C90 RID: 7312
		public override extern double MinorInterval { get; set; }

		// Token: 0x17000E51 RID: 3665
		// (set) Token: 0x06001C91 RID: 7313
		public override extern ObjectId BandStyleId { set; }

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06001C92 RID: 7314
		// (set) Token: 0x06001C93 RID: 7315
		public extern bool LabelAtStartStation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06001C94 RID: 7316
		// (set) Token: 0x06001C95 RID: 7317
		public extern bool LabelAtEndStation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06001C96 RID: 7318
		public extern GeometryPointSelector<AlignmentPointType> GetHorizontalGeometryPointsOptions();

		// Token: 0x06001C97 RID: 7319
		public extern void SetHorizontalGeometryPointsOptions(GeometryPointSelector<AlignmentPointType> alignmentGeometryPoints);

		// Token: 0x06001C98 RID: 7320
		public extern GeometryPointSelector<ProfilePointType> GetVerticalGeometryPointsOptions();

		// Token: 0x06001C99 RID: 7321
		public extern void SetVerticalGeometryPointsOptions(GeometryPointSelector<ProfilePointType> alignmentVerticalGeometryPoints);

		// Token: 0x06001C9A RID: 7322
		protected new unsafe extern AeccDbProfileBandStyleSetData* GetImpObj();

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06001C9B RID: 7323
		protected unsafe override extern char* SettingsNode { get; }
	}
}
