using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200000A RID: 10
	[Wrapper("AeccDbGraphProfilePressurePart")]
	public sealed class ProfileViewPressurePart : Entity
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060000D7 RID: 215
		public extern ObjectId ModelPartId { get; }
	}
}
