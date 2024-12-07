using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000017 RID: 23
	[Wrapper("AeccDbPressurePartSectionLabel")]
	public class PressurePartSectionLabel : FeatureLabel
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000126 RID: 294
		// (set) Token: 0x06000127 RID: 295
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000128 RID: 296
		// (set) Token: 0x06000129 RID: 297
		public extern double Ratio { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600012A RID: 298
		// (set) Token: 0x0600012B RID: 299
		public extern Vector3d Direction { get; set; }

		// Token: 0x0600012C RID: 300
		protected internal extern PressurePartSectionLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
