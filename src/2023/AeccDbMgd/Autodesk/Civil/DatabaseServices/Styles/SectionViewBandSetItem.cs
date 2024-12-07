using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000933 RID: 2355
	public class SectionViewBandSetItem : BandSetItem
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001201 RID: 4609
		// (set) Token: 0x06001202 RID: 4610
		public override extern double MajorInterval { get; set; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001203 RID: 4611
		// (set) Token: 0x06001204 RID: 4612
		public override extern double MinorInterval { get; set; }

		// Token: 0x1700076A RID: 1898
		// (set) Token: 0x06001205 RID: 4613
		public override extern ObjectId BandStyleId { set; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001206 RID: 4614
		// (set) Token: 0x06001207 RID: 4615
		public extern bool LabelAtStartOffset { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001208 RID: 4616
		// (set) Token: 0x06001209 RID: 4617
		public extern bool LabelAtEndOffset { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0600120A RID: 4618
		protected new unsafe extern AeccDbSectionBandStyleSetData* GetImpObj();

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600120B RID: 4619
		protected unsafe override extern char* SettingsNode { get; }
	}
}
