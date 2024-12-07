using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000100 RID: 256
	[Wrapper("AeccDbSectionProjectionLabel")]
	public class SectionProjectionLabel : FeatureLabel
	{
		// Token: 0x06000B95 RID: 2965
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionProjectionId);

		// Token: 0x06000B96 RID: 2966
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionProjectionId, ObjectId labelStyleId);

		// Token: 0x06000B97 RID: 2967
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId);

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000B98 RID: 2968
		public extern ObjectId ProjectionSourceId { get; }

		// Token: 0x06000B99 RID: 2969
		protected internal extern SectionProjectionLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000B9A RID: 2970
		protected override extern void checkStyleId(ObjectId styleId);
	}
}
