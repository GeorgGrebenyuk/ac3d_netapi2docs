using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010A RID: 266
	[Wrapper("AeccDbPartProfileLabel")]
	public class PartProfileLabel : FeatureLabel
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x06000BF5 RID: 3061
		protected internal extern PartProfileLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000BF6 RID: 3062
		protected static extern void checkProfileViewPartInProfileView(AcDbObjectId oidProfileViewPart, AcDbObjectId oidProfileView);
	}
}
