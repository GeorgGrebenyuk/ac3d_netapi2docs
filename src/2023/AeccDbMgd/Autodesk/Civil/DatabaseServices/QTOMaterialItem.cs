using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000823 RID: 2083
	public sealed class QTOMaterialItem : IDisposable
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000F98 RID: 3992
		public extern ObjectId SampleLineGroupId { get; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000F99 RID: 3993
		public extern Guid MaterialListGuid { get; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000F9A RID: 3994
		public extern Guid MaterialGuid { get; }

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000F9B RID: 3995
		public extern string Name { get; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000F9C RID: 3996
		// (set) Token: 0x06000F9D RID: 3997
		public extern MaterialConditionType Condition { get; set; }

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000F9E RID: 3998
		public extern MaterialItemType Type { get; }

		// Token: 0x06000F9F RID: 3999
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsConditionApplicable(MaterialConditionType conditionType);

		// Token: 0x06000FA0 RID: 4000
		public sealed extern void Dispose();

		// Token: 0x0400122A RID: 4650
		private int <SyntheticNonEmptyStructMarker>;
	}
}
