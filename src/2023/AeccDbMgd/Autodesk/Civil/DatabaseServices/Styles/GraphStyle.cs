using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F59 RID: 3929
	public sealed class GraphStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06001DBD RID: 7613
		// (set) Token: 0x06001DBE RID: 7614
		public extern double VerticalScale { get; set; }

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06001DBF RID: 7615
		public extern double CurrentHorizontalScale { get; }

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06001DC0 RID: 7616
		// (set) Token: 0x06001DC1 RID: 7617
		public extern double VerticalExaggeration { get; set; }

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06001DC2 RID: 7618
		// (set) Token: 0x06001DC3 RID: 7619
		public extern GraphDirectionType Direction { get; set; }

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06001DC4 RID: 7620
		public extern GraphTitleStyle TitleStyle { get; }
	}
}
