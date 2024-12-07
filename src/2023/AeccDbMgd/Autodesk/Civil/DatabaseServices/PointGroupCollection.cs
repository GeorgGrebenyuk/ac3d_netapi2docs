using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000879 RID: 2169
	[Wrapper("AeccDbPointGroupsNode")]
	public class PointGroupCollection : IEnumerable<ObjectId>
	{
		// Token: 0x170006CC RID: 1740
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x170006CD RID: 1741
		public extern ObjectId this[string name]
		{
			get;
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001078 RID: 4216
		public extern int Count { get; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001079 RID: 4217
		public extern ObjectId AllPointsPointGroupId { get; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600107A RID: 4218
		// (set) Token: 0x0600107B RID: 4219
		public extern ObjectIdCollection DrawOrder { get; set; }

		// Token: 0x0600107C RID: 4220
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string name);

		// Token: 0x0600107D RID: 4221
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(ObjectId pointGroupId);

		// Token: 0x0600107E RID: 4222
		public extern ObjectId Add(string name);

		// Token: 0x0600107F RID: 4223
		public extern void Remove(ObjectId pointGroupId);

		// Token: 0x06001080 RID: 4224
		public extern void Remove(string name);

		// Token: 0x06001081 RID: 4225
		public extern void RemoveAt(int index);

		// Token: 0x06001082 RID: 4226
		public extern ObjectIdCollection GetOutOfDatePointGroupIds();

		// Token: 0x06001083 RID: 4227
		public extern void UpdateAllPointGroups();

		// Token: 0x06001084 RID: 4228
		public virtual extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x06001085 RID: 4229
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001086 RID: 4230
		public static extern PointGroupCollection GetPointGroups(Database pDatabase);

		// Token: 0x04001282 RID: 4738
		private int <SyntheticNonEmptyStructMarker>;
	}
}
