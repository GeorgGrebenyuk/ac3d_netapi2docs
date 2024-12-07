using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F3 RID: 243
	public abstract class AlignmentSubEntity : DisposableWrapper
	{
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000B45 RID: 2885
		public abstract AlignmentSubEntityType SubEntityType { get; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000B46 RID: 2886
		// (set) Token: 0x06000B47 RID: 2887
		public extern double Length { get; set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000B48 RID: 2888
		public extern Point2d StartPoint { get; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000B49 RID: 2889
		public extern Point2d EndPoint { get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000B4A RID: 2890
		public extern double StartStation { get; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000B4B RID: 2891
		public extern double EndStation { get; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000B4C RID: 2892
		// (set) Token: 0x06000B4D RID: 2893
		public extern string CurveGroupIndex { get; set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000B4E RID: 2894
		// (set) Token: 0x06000B4F RID: 2895
		public extern string CurveGroupSubEntityIndex { get; set; }

		// Token: 0x06000B50 RID: 2896
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ValidateDesignCheck(AlignmentDesignCheck designCheck);

		// Token: 0x06000B51 RID: 2897
		public extern Collection<AlignmentDesignCheck> DesignChecks();

		// Token: 0x06000B52 RID: 2898
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x06000B53 RID: 2899
		protected override extern void DeleteUnmanagedObject();

		// Token: 0x0400031A RID: 794
		private int <SyntheticNonEmptyStructMarker>;
	}
}
