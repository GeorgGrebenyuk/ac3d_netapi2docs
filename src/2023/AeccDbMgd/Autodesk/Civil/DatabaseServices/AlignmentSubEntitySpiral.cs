using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DFC RID: 3580
	public sealed class AlignmentSubEntitySpiral : AlignmentSubEntity
	{
		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06001AA6 RID: 6822
		public override extern AlignmentSubEntityType SubEntityType { get; }

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06001AA7 RID: 6823
		// (set) Token: 0x06001AA8 RID: 6824
		public extern double A { get; set; }

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06001AA9 RID: 6825
		public extern bool Compound { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06001AAA RID: 6826
		public extern SpiralCurveType CurveType { get; }

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06001AAB RID: 6827
		public extern double Delta { get; }

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06001AAC RID: 6828
		public extern double StartDirection { get; }

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06001AAD RID: 6829
		public extern double EndDirection { get; }

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06001AAE RID: 6830
		public extern double K { get; }

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06001AAF RID: 6831
		public extern double LongTangent { get; }

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06001AB0 RID: 6832
		public extern double MinimumTransitionLength { get; }

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06001AB1 RID: 6833
		public extern double P { get; }

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06001AB2 RID: 6834
		public extern Point2d RadialPoint { get; }

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06001AB3 RID: 6835
		public extern double RadiusIn { get; }

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06001AB4 RID: 6836
		public extern double RadiusOut { get; }

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06001AB5 RID: 6837
		public extern double ShortTangent { get; }

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06001AB6 RID: 6838
		public extern double SPIAngle { get; }

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06001AB7 RID: 6839
		public extern Point2d SPIPoint { get; }

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06001AB8 RID: 6840
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06001AB9 RID: 6841
		public extern double SPIStation { get; }

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06001ABA RID: 6842
		public extern SpiralDirectionType Direction { get; }

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06001ABB RID: 6843
		public extern double TotalX { get; }

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06001ABC RID: 6844
		public extern double TotalY { get; }
	}
}
