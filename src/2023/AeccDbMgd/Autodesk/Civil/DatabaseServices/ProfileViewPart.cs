using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C9 RID: 201
	[Wrapper("AeccDbGraphProfileNetworkPart")]
	public sealed class ProfileViewPart : Entity
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000970 RID: 2416
		public extern ObjectId ModelPartId { get; }

		// Token: 0x06000971 RID: 2417
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileViewPart.GetPartProfileLabelIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern ObjectIdCollection GetLabelIds();

		// Token: 0x06000972 RID: 2418
		public extern ObjectIdCollection GetPartProfileLabelIds();
	}
}
