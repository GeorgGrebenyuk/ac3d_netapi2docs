using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B0 RID: 176
	[Wrapper("AeccDbLabelStyleTextPropFieldObject")]
	public class LabelStyleReferenceTextComponent : LabelStyleComponent
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060007C2 RID: 1986
		public extern LabelStyleReferenceTextComponent.StyleGeneral General { get; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060007C3 RID: 1987
		public extern LabelStyleReferenceTextComponent.StyleText Text { get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060007C4 RID: 1988
		public extern LabelStyleReferenceTextComponent.StyleBorder Border { get; }

		// Token: 0x060007C5 RID: 1989
		protected internal extern LabelStyleReferenceTextComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x0200128A RID: 4746
		public sealed class StyleGeneral : LabelStyleTextComponent.StyleGeneral
		{
			// Token: 0x17001598 RID: 5528
			// (get) Token: 0x0600299E RID: 10654
			public extern string ReferenceTextObjectType { get; }
		}

		// Token: 0x0200128B RID: 4747
		public class StyleText : LabelStyleTextComponent.StyleText
		{
		}

		// Token: 0x0200128C RID: 4748
		public sealed class StyleBorder : LabelStyleTextComponent.StyleBorder
		{
		}
	}
}
