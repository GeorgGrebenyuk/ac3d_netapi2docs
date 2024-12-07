using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000014 RID: 20
	[Wrapper("AeccDbPressurePartProfileLabel")]
	public class PressurePartProfileLabel : FeatureLabel
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600011A RID: 282
		// (set) Token: 0x0600011B RID: 283
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x0600011C RID: 284
		protected internal extern PressurePartProfileLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x0600011D RID: 285
		protected static extern void checkProfileViewPartInProfileView(AcDbObjectId oidProfileViewPart, AcDbObjectId oidProfileView);
	}
}
