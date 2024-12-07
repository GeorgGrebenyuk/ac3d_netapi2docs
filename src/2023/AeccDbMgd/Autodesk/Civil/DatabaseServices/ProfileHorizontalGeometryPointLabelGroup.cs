using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000122 RID: 290
	[Wrapper("AeccDbVAlignmentHAGeomPointLabeling")]
	public class ProfileHorizontalGeometryPointLabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000C88 RID: 3208
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileHorizontalGeometryPointLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C89 RID: 3209
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000C8A RID: 3210
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId);

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000C8B RID: 3211
		// (set) Token: 0x06000C8C RID: 3212
		public virtual extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000C8D RID: 3213
		// (set) Token: 0x06000C8E RID: 3214
		public virtual extern double StaggerLineHeight2 { get; set; }

		// Token: 0x06000C8F RID: 3215
		public extern GeometryPointSelector<AlignmentPointType> GetGeometryPointsOptions();

		// Token: 0x06000C90 RID: 3216
		public extern void SetGeometryPointsOptions(GeometryPointSelector<AlignmentPointType> profileGeometryPoints);

		// Token: 0x06000C91 RID: 3217
		protected internal extern ProfileHorizontalGeometryPointLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
