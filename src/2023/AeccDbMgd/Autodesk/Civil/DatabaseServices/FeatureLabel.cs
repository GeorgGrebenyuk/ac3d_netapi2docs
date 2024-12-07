using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F4 RID: 244
	[Wrapper("AeccDbFeatureLabel")]
	public abstract class FeatureLabel : Label
	{
		// Token: 0x06000B54 RID: 2900
		protected unsafe static extern void GetFeatureAnchorDefinition(AlignmentSubEntity subEntity, AeccFeatureAnchorDefinition* anchorDef);

		// Token: 0x06000B55 RID: 2901
		protected unsafe static extern void GetFeatureAnchorDefinition(AlignmentEntity entity, AeccFeatureAnchorDefinition* anchorDef);

		// Token: 0x06000B56 RID: 2902
		protected internal extern FeatureLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
