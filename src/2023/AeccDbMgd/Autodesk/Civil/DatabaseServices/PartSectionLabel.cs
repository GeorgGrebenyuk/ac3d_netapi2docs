using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010C RID: 268
	[Wrapper("AeccDbPartSectionLabel")]
	public class PartSectionLabel : FeatureLabel
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000BFC RID: 3068
		// (set) Token: 0x06000BFD RID: 3069
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x06000BFE RID: 3070
		protected internal extern PartSectionLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000BFF RID: 3071
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool isSectionViewContainSectionPipeNetowrk(AcDbObjectId oidPart, AcDbObjectId oidSectionView);

		// Token: 0x06000C00 RID: 3072
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool isSectionViewDrawSectionPipeNetwork(AcDbObjectId oidPart, AcDbObjectId oidSectionView);

		// Token: 0x06000C01 RID: 3073
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool isNetworkPartTheSourceOfSectionPipeNetwork(AcDbObjectId oidPart, AcDbObjectId oidSectionPipeNetwork);

		// Token: 0x06000C02 RID: 3074
		protected static extern int getIntersectionCount(AcDbObjectId oidPart, AcDbObjectId oidSectionPipeNetwork);
	}
}
