using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C5 RID: 197
	[Wrapper("AeccDbNetworkPart")]
	public abstract class Part : GeoEntity
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060008B2 RID: 2226
		// (set) Token: 0x060008B3 RID: 2227
		public virtual extern Point3d Position { get; set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060008B4 RID: 2228
		public virtual extern PartType PartType { get; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060008B5 RID: 2229
		public virtual extern ParamBoolCollection ParamsBool { get; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060008B6 RID: 2230
		public virtual extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060008B7 RID: 2231
		public virtual extern ParamLongCollection ParamsLong { get; }

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060008B8 RID: 2232
		public virtual extern ParamStringCollection ParamsString { get; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060008B9 RID: 2233
		public virtual extern string PartSubType { get; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060008BA RID: 2234
		public extern DomainType Domain { get; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060008BB RID: 2235
		public override extern string Name { get; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060008BC RID: 2236
		public virtual extern string PartSizeName { get; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060008BD RID: 2237
		public virtual extern string PartDescription { get; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060008BE RID: 2238
		public virtual extern string Material { get; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060008BF RID: 2239
		public extern double WallThickness { get; }

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060008C0 RID: 2240
		public extern ObjectId NetworkId { get; }

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060008C1 RID: 2241
		public extern string NetworkName { get; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060008C2 RID: 2242
		// (set) Token: 0x060008C3 RID: 2243
		public extern ObjectId RefAlignmentId { get; set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060008C4 RID: 2244
		public extern string RefAlignmentName { get; }

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060008C5 RID: 2245
		// (set) Token: 0x060008C6 RID: 2246
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Part.RefSurfaceId instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern ObjectId SurfaceId { get; set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060008C7 RID: 2247
		// (set) Token: 0x060008C8 RID: 2248
		public extern ObjectId RefSurfaceId { get; set; }

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060008C9 RID: 2249
		public extern string RefSurfaceName { get; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060008CA RID: 2250
		public extern int ConnectedPartCount { get; }

		// Token: 0x060008CB RID: 2251
		public extern void AddToProfileView(ObjectId profileViewId);

		// Token: 0x060008CC RID: 2252
		public extern void RemoveFromAllProfileViews();

		// Token: 0x060008CD RID: 2253
		public extern void RemoveFromProfileView(ObjectId profileViewId);

		// Token: 0x060008CE RID: 2254
		public extern ObjectIdCollection GetProfileViewsDisplayingMe();

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060008CF RID: 2255
		public extern ObjectId ProfileViewPartId { get; }

		// Token: 0x060008D0 RID: 2256
		public extern void AddToSectionView(ObjectId sectionViewId);

		// Token: 0x060008D1 RID: 2257
		public extern void RemoveFromAllSectionViews();

		// Token: 0x060008D2 RID: 2258
		public extern void RemoveFromSectionView(ObjectId sectionViewId);

		// Token: 0x060008D3 RID: 2259
		public extern ObjectIdCollection GetSectionViewsDisplayingMe();

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060008D4 RID: 2260
		public extern ObjectId SectionViewPartId { get; }

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060008D5 RID: 2261
		public extern ObjectId PartDefId { get; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060008D6 RID: 2262
		// (set) Token: 0x060008D7 RID: 2263
		public extern PartDataRecord PartData { get; set; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060008D8 RID: 2264
		// (set) Token: 0x060008D9 RID: 2265
		public virtual extern ObjectId RuleSetStyleId { get; set; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060008DA RID: 2266
		// (set) Token: 0x060008DB RID: 2267
		public virtual extern string RuleSetStyleName { get; set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060008DC RID: 2268
		// (set) Token: 0x060008DD RID: 2269
		public extern bool OverrideRuleSet { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060008DE RID: 2270
		public extern ObjectIdCollection GetOverriddenRuleIds();

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060008DF RID: 2271
		public extern Solid3d Solid3dBody { get; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060008E0 RID: 2272
		public extern ObjectId PartFamilyId { get; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060008E1 RID: 2273
		public extern string PartFamilyName { get; }

		// Token: 0x060008E2 RID: 2274
		public extern void SwapPartFamilyAndSize(ObjectId partFamilyId, ObjectId partSizeId);

		// Token: 0x060008E3 RID: 2275
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ApplyRules();

		// Token: 0x060008E4 RID: 2276
		protected internal extern Part(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x060008E5 RID: 2277
		protected extern double InnerGetPropertyDoubleValue(AeccNetworkEnums.Context networkEnum, AeccNetworkEnums.PartType partType);

		// Token: 0x060008E6 RID: 2278
		protected extern double InnerGetPropertyDoubleValue(uint attributeId, AeccNetworkEnums.PartType partType);

		// Token: 0x060008E7 RID: 2279
		protected extern string InnerGetPropertyStringValue(AeccNetworkEnums.Context networkEnum);

		// Token: 0x060008E8 RID: 2280
		protected extern string InnerGetPropertyStringValue(uint attributeId);

		// Token: 0x060008E9 RID: 2281
		protected unsafe abstract void ApplyResizing(AeccDataRecord* record);

		// Token: 0x060008EA RID: 2282
		protected unsafe abstract AeccDbTreeOid* GetRuleSetStylesRoot(AeccDbTreeOid*);

		// Token: 0x060008EB RID: 2283
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04000307 RID: 775
		private int <SyntheticNonEmptyStructMarker>;
	}
}
