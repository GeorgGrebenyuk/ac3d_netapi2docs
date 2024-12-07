using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000C0 RID: 192
	[Wrapper("AeccDbGradingCriteriaSet")]
	public sealed class GradingCriteriaSet : StyleBase
	{
		// Token: 0x0600084C RID: 2124
		public extern ObjectIdCollection GradingCriteriaIds();

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600084D RID: 2125
		public extern int Count { get; }

		// Token: 0x1700035E RID: 862
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x1700035F RID: 863
		public extern ObjectId this[string criteriaName]
		{
			get;
		}

		// Token: 0x06000850 RID: 2128
		public extern void AddCriteria(string criteriaName);

		// Token: 0x06000851 RID: 2129
		public extern void RemoveCriteria(int index);

		// Token: 0x06000852 RID: 2130
		public extern void RemoveCriteria(string criteriaName);

		// Token: 0x06000853 RID: 2131
		public extern void MoveCriteria(string criteriaName, string criteriaSetName);

		// Token: 0x06000854 RID: 2132
		public extern void MoveCriteria(ObjectId criteriaId, ObjectId criteriaSetId);

		// Token: 0x04000306 RID: 774
		private int <SyntheticNonEmptyStructMarker>;
	}
}
