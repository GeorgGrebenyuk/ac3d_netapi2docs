using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000128 RID: 296
	[Wrapper("AeccDbProfileBandLabeling")]
	public class ProfileBandLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000CB7 RID: 3255
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(RXClass runtimeClass, ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CB8 RID: 3256
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(RXClass runtimeClass, ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000CB9 RID: 3257
		// (set) Token: 0x06000CBA RID: 3258
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000CBB RID: 3259
		// (set) Token: 0x06000CBC RID: 3260
		public override extern string StyleName { get; set; }

		// Token: 0x06000CBD RID: 3261
		protected internal extern ProfileBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
