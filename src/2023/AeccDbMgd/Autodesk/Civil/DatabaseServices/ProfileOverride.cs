using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EA5 RID: 3749
	public sealed class ProfileOverride : GraphOverride
	{
		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06001C75 RID: 7285
		public extern ObjectId ProfileId { get; }

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06001C76 RID: 7286
		public extern string ProfileName { get; }

		// Token: 0x06001C77 RID: 7287
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileOverride.GetProfileLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern ObjectIdCollection GetLabelGroupIds();

		// Token: 0x06001C78 RID: 7288
		public extern ObjectIdCollection GetProfileLabelGroupIds();

		// Token: 0x17000E46 RID: 3654
		// (set) Token: 0x06001C79 RID: 7289
		public override extern string OverrideStyleName { set; }

		// Token: 0x17000E45 RID: 3653
		// (set) Token: 0x06001C7A RID: 7290
		public override extern ObjectId OverrideStyleId { set; }
	}
}
