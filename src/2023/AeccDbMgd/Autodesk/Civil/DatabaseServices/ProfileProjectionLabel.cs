using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FD RID: 253
	[Wrapper("AeccDbProfileProjectionLabel")]
	public class ProfileProjectionLabel : FeatureLabel
	{
		// Token: 0x06000B7E RID: 2942
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileProjectionId, ObjectId labelStyleId);

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000B7F RID: 2943
		public extern ObjectId ProjectionSourceId { get; }

		// Token: 0x06000B80 RID: 2944
		protected internal extern ProfileProjectionLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
