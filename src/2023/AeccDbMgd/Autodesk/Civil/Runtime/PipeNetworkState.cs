using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x0200123F RID: 4671
	[Wrapper("AeccDbNetworkState")]
	public sealed class PipeNetworkState : RuntimeState
	{
		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06002861 RID: 10337
		public extern ParamLongCollection ParamsLong { get; }

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06002862 RID: 10338
		public extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06002863 RID: 10339
		public extern ParamBoolCollection ParamsBool { get; }

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06002864 RID: 10340
		public extern ObjectId CurrentPipeId { get; }

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06002865 RID: 10341
		public extern ObjectId CurrentStructureId { get; }

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06002866 RID: 10342
		public extern bool IsInLayoutMode { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06002867 RID: 10343
		// (set) Token: 0x06002868 RID: 10344
		public extern double LastPipeElevation { get; set; }

		// Token: 0x06002869 RID: 10345
		public extern string RuleResourceString(string resId);

		// Token: 0x0600286A RID: 10346
		public extern void SetErrorMsgOnCurrentPart(string paramKey, string errorMessage);

		// Token: 0x0600286B RID: 10347
		public extern void SetDoubleOnCurrentPart(string paramKey, double value);

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600286C RID: 10348
		public extern bool IsBreakingPipe { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600286D RID: 10349
		public extern bool IsConnectingToStructure { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600286E RID: 10350
		public extern bool IsCurrentPartBeingAdd { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600286F RID: 10351
		public extern bool IsLayoutUpStream { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06002870 RID: 10352
		public extern void SetAlignmentOnPart(string paramName, ObjectId alignmentId);

		// Token: 0x06002871 RID: 10353
		public extern void SetBoolOnPart(string paramName, [MarshalAs(UnmanagedType.U1)] bool value);

		// Token: 0x06002872 RID: 10354
		public extern void SetLongOnPart(string paramName, int value);

		// Token: 0x06002873 RID: 10355
		public extern void SetPointOnPart(string paramName, Point3d value);

		// Token: 0x06002874 RID: 10356
		public extern void SetProfileOnPart(string paramName, ObjectId profileId);

		// Token: 0x06002875 RID: 10357
		public extern void SetStringOnPart(string paramName, string value);

		// Token: 0x06002876 RID: 10358
		public extern void SetSurfaceOnPart(string paramName, ObjectId surfaceId);

		// Token: 0x04001B90 RID: 7056
		private int <SyntheticNonEmptyStructMarker>;
	}
}
