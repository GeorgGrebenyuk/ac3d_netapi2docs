using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000FEF RID: 4079
	public class PartDataField
	{
		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600205E RID: 8286
		public extern PartCatalogDataType DataType { get; }

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600205F RID: 8287
		public extern bool IsFromList { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002060 RID: 8288
		public extern bool IsFromRange { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002061 RID: 8289
		public extern PartDataList ValueList { get; }

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002062 RID: 8290
		public extern PartDataRange ValueRange { get; }

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06002063 RID: 8291
		public extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002064 RID: 8292
		// (set) Token: 0x06002065 RID: 8293
		public extern object Value { get; set; }

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002066 RID: 8294
		public extern string Name { get; }

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002067 RID: 8295
		public extern string Description { get; }

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002068 RID: 8296
		public extern string ContextString { get; }

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002069 RID: 8297
		public extern PartContextType Context { get; }

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600206A RID: 8298
		public extern int Index { get; }

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600206B RID: 8299
		public extern string Units { get; }

		// Token: 0x0400188E RID: 6286
		protected unsafe AeccDataRawTable* m_rawTable;

		// Token: 0x0400188F RID: 6287
		protected unsafe AeccDataField* m_dataField;

		// Token: 0x04001890 RID: 6288
		protected DomainType m_domain;

		// Token: 0x04001891 RID: 6289
		protected unsafe AeccDataRecord* m_parentDataRecord;
	}
}
