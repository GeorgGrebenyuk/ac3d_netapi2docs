using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000141 RID: 321
	[Wrapper("AeccDbCatchmentAreaGroup")]
	public sealed class CatchmentGroup : Entity
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000DC0 RID: 3520
		// (set) Token: 0x06000DC1 RID: 3521
		public override extern string Name { get; set; }

		// Token: 0x06000DC2 RID: 3522
		public static extern ObjectId Create(Database database, string catchmentGroupName);

		// Token: 0x06000DC3 RID: 3523
		public extern ObjectId GetCatchmentId(string catchmentName);

		// Token: 0x06000DC4 RID: 3524
		public extern ObjectIdCollection GetAllCatchmentIds();

		// Token: 0x06000DC5 RID: 3525
		public extern void AddCatchmentId(ObjectId catchmentId);

		// Token: 0x06000DC6 RID: 3526
		public extern void RemoveCatchmentId(ObjectId catchmentId);

		// Token: 0x06000DC7 RID: 3527
		public extern void RemoveAllCatchments();
	}
}
