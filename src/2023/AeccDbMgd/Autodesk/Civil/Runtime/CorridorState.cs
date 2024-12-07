using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001235 RID: 4661
	[Wrapper("AeccDbRoadwayState")]
	public sealed class CorridorState : RuntimeState
	{
		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06002821 RID: 10273
		public extern ParamLongCollection ParamsLong { get; }

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06002822 RID: 10274
		public extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06002823 RID: 10275
		public extern ParamBoolCollection ParamsBool { get; }

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06002824 RID: 10276
		public extern ParamStringCollection ParamsString { get; }

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06002825 RID: 10277
		public extern ParamPointCollection ParamsPoint { get; }

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06002826 RID: 10278
		public extern ParamSurfaceCollection ParamsSurface { get; }

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06002827 RID: 10279
		public extern ParamAlignmentCollection ParamsAlignment { get; }

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06002828 RID: 10280
		public extern ParamProfileCollection ParamsProfile { get; }

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06002829 RID: 10281
		public extern ParamOffsetTargetCollection ParamsOffsetTarget { get; }

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600282A RID: 10282
		public extern ParamElevationTargetCollection ParamsElevationTarget { get; }

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600282B RID: 10283
		public extern ParamLongCollection ParamsLongGlobal { get; }

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600282C RID: 10284
		public extern ParamDoubleCollection ParamsDoubleGlobal { get; }

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600282D RID: 10285
		public extern ParamBoolCollection ParamsBoolGlobal { get; }

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600282E RID: 10286
		public extern ParamStringCollection ParamsStringGlobal { get; }

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600282F RID: 10287
		public extern ParamPointCollection ParamsPointGlobal { get; }

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06002830 RID: 10288
		public extern ParamSurfaceCollection ParamsSurfaceGlobal { get; }

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06002831 RID: 10289
		public extern ParamAlignmentCollection ParamsAlignmentGlobal { get; }

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06002832 RID: 10290
		public extern ParamProfileCollection ParamsProfileGlobal { get; }

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06002833 RID: 10291
		public extern ParamOffsetTargetCollection ParamsOffsetTargetGlobal { get; }

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06002834 RID: 10292
		public extern ParamElevationTargetCollection ParamsElevationTargetGlobal { get; }

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06002835 RID: 10293
		public extern PointCollection Points { get; }

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06002836 RID: 10294
		public extern LinkCollection Links { get; }

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06002837 RID: 10295
		public extern ShapeCollection Shapes { get; }

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06002838 RID: 10296
		// (set) Token: 0x06002839 RID: 10297
		public extern CorridorLayoutModeDisplay LayoutModeDisplayType { get; set; }

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600283A RID: 10298
		public extern CorridorMode Mode { get; }

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600283B RID: 10299
		public extern double CurrentRegionStartStation { get; }

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600283C RID: 10300
		public extern double CurrentRegionEndStation { get; }

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600283D RID: 10301
		public extern double CurrentStation { get; }

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600283E RID: 10302
		public extern double CurrentOffset { get; }

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600283F RID: 10303
		public extern double CurrentElevation { get; }

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06002840 RID: 10304
		public extern ObjectId CurrentBaselineId { get; }

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06002841 RID: 10305
		public extern ObjectId CurrentAlignmentId { get; }

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06002842 RID: 10306
		public extern ObjectId CurrentProfileId { get; }

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06002843 RID: 10307
		public extern ObjectId CurrentSubassemblyId { get; }

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06002844 RID: 10308
		public extern string CurrentSubassemblyName { get; }

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06002845 RID: 10309
		public extern ObjectId CurrentAssemblyId { get; }

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06002846 RID: 10310
		public extern string CurrentAssemblyName { get; }

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06002847 RID: 10311
		public extern ObjectId CurrentCorridorId { get; }

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06002848 RID: 10312
		public extern string CurrentCorridorName { get; }

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06002849 RID: 10313
		public extern bool CurrentAlignmentIsOffsetAlignment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x0600284A RID: 10314
		public extern bool CurrentAssemblyOffsetIsFixed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600284B RID: 10315
		public extern double CurrentAssemblyFixedOffset { get; }

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600284C RID: 10316
		public extern double CurrentAssemblyFixedElevation { get; }

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600284D RID: 10317
		public extern double CurrentSubassemblyOffset { get; }

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600284E RID: 10318
		public extern double CurrentSubassemblyElevation { get; }

		// Token: 0x0600284F RID: 10319
		public extern IPoint IntersectSurface(ObjectId surfaceId, ObjectId alignmentId, IPoint origin, [MarshalAs(UnmanagedType.U1)] bool lookRight, double slope);

		// Token: 0x06002850 RID: 10320
		public extern IPoint IntersectSurface(ObjectId surfaceId, ObjectId alignmentId, IPoint origin, [MarshalAs(UnmanagedType.U1)] bool lookRight, double slope, double maxDistance);

		// Token: 0x06002851 RID: 10321
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsAboveSurface(ObjectId surfaceId, ObjectId alignmentId, IPoint point);

		// Token: 0x06002852 RID: 10322
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsAboveSurface(ObjectId surfaceId, ObjectId alignmentId, IPoint point, double minimumAmountAbove);

		// Token: 0x06002853 RID: 10323
		public extern SampledSectionLinkCollection SampleSection(ObjectId surfaceId, ObjectId alignmentId, IPoint point1, IPoint point2);

		// Token: 0x06002854 RID: 10324
		public extern void RecordError(CorridorError error, CorridorErrorLevel errorLevel, string description, string source, [MarshalAs(UnmanagedType.U1)] bool showInEventViewer);

		// Token: 0x06002855 RID: 10325
		public extern IPoint IntersectLink(IPoint origin, [MarshalAs(UnmanagedType.U1)] bool lookRight, double slope, string linkCode);

		// Token: 0x06002856 RID: 10326
		public extern IPoint IntersectAlignment(ObjectId targetAlignmentId, ObjectId alignmentId, IPoint origin, [MarshalAs(UnmanagedType.U1)] bool lookRight);

		// Token: 0x06002857 RID: 10327
		public extern IPoint IntersectAlignment(ObjectId targetAlignmentId, ObjectId alignmentId, IPoint origin, [MarshalAs(UnmanagedType.U1)] bool lookRight, double maxDistance);

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06002858 RID: 10328
		public extern double CurrentAssemblyOffset { get; }

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06002859 RID: 10329
		public extern double CurrentAssemblyElevation { get; }

		// Token: 0x0600285A RID: 10330
		public extern void SoeToXyz(ObjectId alignmentId, double station, double offset, double elevation, ref double X, ref double Y, ref double Z);

		// Token: 0x0600285B RID: 10331
		public extern void XyzToSoe(ObjectId alignmentId, double X, double Y, double Z, ref double station, ref double offset, ref double elevation);

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600285C RID: 10332
		public extern string ResourceString { get; }

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x0600285D RID: 10333
		public extern string ResourceString { get; }

		// Token: 0x0600285E RID: 10334
		public extern void SetAxisOfRotationInformation([MarshalAs(UnmanagedType.U1)] bool isPotentialPivot, double superElevationSlope, SuperelevationCrossSegmentType superElevationSlopeType, [MarshalAs(UnmanagedType.U1)] bool isReversedSlope);

		// Token: 0x0600285F RID: 10335
		public extern void SetAxisOfRotationSERange(double dApplySE_StartOffset, double dApplySE_EndOffset);

		// Token: 0x06002860 RID: 10336
		public extern void SetAxisOfRotationCrownPoint(uint nCrownPointIndex);

		// Token: 0x04001B51 RID: 6993
		private int <SyntheticNonEmptyStructMarker>;
	}
}
