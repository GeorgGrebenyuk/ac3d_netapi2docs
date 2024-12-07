using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B5 RID: 181
	[Wrapper("AeccDbLabelStyleTextIterator")]
	public class LabelStyleTextForEachComponent : LabelStyleComponent
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060007DD RID: 2013
		public extern LabelStyleTextForEachComponent.StyleGeneral General { get; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060007DE RID: 2014
		public extern LabelStyleTextForEachComponent.StyleText Text { get; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060007DF RID: 2015
		public extern LabelStyleTextForEachComponent.StyleBorder Border { get; }

		// Token: 0x060007E0 RID: 2016
		protected internal extern LabelStyleTextForEachComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x0200128D RID: 4749
		public sealed class StyleGeneral : LabelStyleTextComponent.StyleGeneral
		{
			// Token: 0x17001599 RID: 5529
			// (get) Token: 0x0600299F RID: 10655
			public extern string TextForEach { get; }
		}

		// Token: 0x0200128E RID: 4750
		public class StyleText : LabelStyleTextComponent.StyleText
		{
			// Token: 0x1700159B RID: 5531
			// (get) Token: 0x060029A0 RID: 10656
			public extern PropertyString CurveContents { get; }

			// Token: 0x1700159A RID: 5530
			// (get) Token: 0x060029A1 RID: 10657
			public extern PropertyString SpiralContents { get; }
		}

		// Token: 0x0200128F RID: 4751
		public sealed class StyleBorder : LabelStyleTextComponent.StyleBorder
		{
		}
	}
}
