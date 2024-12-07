using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F0 RID: 240
	[Wrapper("AeccDbAutoCorridorFeatureLine")]
	public class AutoCorridorFeatureLine : FeatureLine
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000AF5 RID: 2805
		public extern string CorridorFeaturelineCode { get; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000AF6 RID: 2806
		public extern string CorridorFeaturelineBaselineName { get; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000AF7 RID: 2807
		public extern string CorridorName { get; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000AF8 RID: 2808
		public extern bool CreateFeatureLineDynamicLink { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000AF9 RID: 2809
		public extern double FeatureLineStartCriteriaBeadStation { get; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000AFA RID: 2810
		public extern double FeatureLineEndCriteriaBeadStation { get; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000AFB RID: 2811
		public extern string CorridorFeaturelineRegionName { get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000AFC RID: 2812
		public extern string CorridorFeaturelineSide { get; }

		// Token: 0x06000AFD RID: 2813
		public extern string SourceObjectName();

		// Token: 0x06000AFE RID: 2814
		public extern void DetachCorridor();

		// Token: 0x06000AFF RID: 2815
		public extern void ReAttachCorridor();

		// Token: 0x06000B00 RID: 2816
		public extern AutoCorridorFeatureLine(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000B01 RID: 2817
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000B02 RID: 2818
		protected override extern void Finalize();
	}
}
