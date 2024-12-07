using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B2 RID: 178
	[Wrapper("AeccDbLabelStyleTick")]
	public class LabelStyleTickComponent : LabelStyleComponent
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060007CA RID: 1994
		public extern LabelStyleTickComponent.StyleGeneral General { get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060007CB RID: 1995
		public extern LabelStyleTickComponent.StyleTick Tick { get; }

		// Token: 0x060007CC RID: 1996
		protected internal extern LabelStyleTickComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x02001291 RID: 4753
		public sealed class StyleGeneral : CivilWrapper<AeccDbLabelStyleTick>
		{
			// Token: 0x1700159D RID: 5533
			// (get) Token: 0x060029A5 RID: 10661
			// (set) Token: 0x060029A6 RID: 10662
			public extern string Name { get; set; }

			// Token: 0x1700159C RID: 5532
			// (get) Token: 0x060029A7 RID: 10663
			public extern PropertyBoolean Visible { get; }
		}

		// Token: 0x02001292 RID: 4754
		public sealed class StyleTick : CivilWrapper<AeccDbLabelStyleTick>
		{
			// Token: 0x170015A4 RID: 5540
			// (get) Token: 0x060029A8 RID: 10664
			public extern PropertyString BlockName { get; }

			// Token: 0x170015A3 RID: 5539
			// (get) Token: 0x060029A9 RID: 10665
			public extern PropertyDouble BlockHeight { get; }

			// Token: 0x170015A2 RID: 5538
			// (get) Token: 0x060029AA RID: 10666
			public extern PropertyDouble RotationAngle { get; }

			// Token: 0x170015A1 RID: 5537
			// (get) Token: 0x060029AB RID: 10667
			public extern PropertyBoolean AlignWithObject { get; }

			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x060029AC RID: 10668
			public extern PropertyColor Color { get; }

			// Token: 0x1700159F RID: 5535
			// (get) Token: 0x060029AD RID: 10669
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x1700159E RID: 5534
			// (get) Token: 0x060029AE RID: 10670
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
