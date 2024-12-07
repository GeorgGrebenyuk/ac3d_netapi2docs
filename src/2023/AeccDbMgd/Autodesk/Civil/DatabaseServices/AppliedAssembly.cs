using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200112C RID: 4396
	public sealed class AppliedAssembly : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x0600243A RID: 9274
		public extern ObjectId CorridorId { get; }

		// Token: 0x0600243B RID: 9275
		public extern AppliedSubassemblyCollection GetAppliedSubassemblies();

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x0600243C RID: 9276
		public extern CalculatedPointCollection Points { get; }

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x0600243D RID: 9277
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AppliedAssembly.GetPointsByCode instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern CalculatedPointCollection PointsByCode { get; }

		// Token: 0x0600243E RID: 9278
		public extern CalculatedPointCollection GetPointsByCode(string code);

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x0600243F RID: 9279
		public extern CalculatedLinkCollection Links { get; }

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06002440 RID: 9280
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AppliedAssembly.GetLinksByCode instead.", false)]
		public extern CalculatedLinkCollection LinksByCode { get; }

		// Token: 0x06002441 RID: 9281
		public extern CalculatedLinkCollection GetLinksByCode(string code);

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06002442 RID: 9282
		public extern CalculatedShapeCollection Shapes { get; }

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06002443 RID: 9283
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AppliedAssembly.GetShapesByCode instead.", false)]
		public extern CalculatedShapeCollection ShapesByCode { get; }

		// Token: 0x06002444 RID: 9284
		public extern CalculatedShapeCollection GetShapesByCode(string code);

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06002445 RID: 9285
		public extern ObjectId AssemblyId { get; }

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06002446 RID: 9286
		public extern double AdjustedElevation { get; }

		// Token: 0x04001A83 RID: 6787
		private int <SyntheticNonEmptyStructMarker>;
	}
}
