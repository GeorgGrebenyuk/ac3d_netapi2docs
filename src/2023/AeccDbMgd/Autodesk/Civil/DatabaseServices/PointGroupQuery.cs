using System;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200085C RID: 2140
	public abstract class PointGroupQuery
	{
		// Token: 0x0600102E RID: 4142
		public extern PointGroupQuery();

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600102F RID: 4143
		// (set) Token: 0x06001030 RID: 4144
		public extern bool UseCaseSensitiveMatch { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001031 RID: 4145
		public extern string QueryString { get; }

		// Token: 0x06001032 RID: 4146
		protected abstract void loadQuery();

		// Token: 0x06001033 RID: 4147
		protected abstract void saveQuery();

		// Token: 0x06001034 RID: 4148
		protected extern string getQueryString();

		// Token: 0x06001035 RID: 4149
		protected extern void setQueryString(string query);

		// Token: 0x06001036 RID: 4150
		protected unsafe extern void setQueryStringFromItems(list<AeccPointGroupQueryBuilder::DataItem,std::allocator<AeccPointGroupQueryBuilder::DataItem>\u0020>* items);

		// Token: 0x06001037 RID: 4151
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe extern bool isCurrentPointGroup(AecRmCString* pvalue);

		// Token: 0x06001038 RID: 4152
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe extern bool isExistingPointGroup(AecRmCString* pvalue);

		// Token: 0x04001266 RID: 4710
		protected unsafe AeccDbPG* _curPG;

		// Token: 0x04001267 RID: 4711
		protected unsafe AeccPointGroupQueryBuilder* _curBuilder;
	}
}
