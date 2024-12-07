using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000DA RID: 218
	[Wrapper("AeccDbPartFamilyItem")]
	public sealed class PartFamily : DBObject
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060009E8 RID: 2536
		public extern DomainType Domain { get; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060009E9 RID: 2537
		public extern string GUID { get; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060009EA RID: 2538
		public override extern string Description { get; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060009EB RID: 2539
		public extern PartType PartType { get; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060009EC RID: 2540
		public extern BoundingShapeType BoundingShape { get; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060009ED RID: 2541
		public extern SweptShapeType SweptShape { get; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060009EE RID: 2542
		public extern int PartSizeCount { get; }

		// Token: 0x1700043C RID: 1084
		public extern ObjectId this[string description]
		{
			get;
		}

		// Token: 0x1700043D RID: 1085
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060009F1 RID: 2545
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.SizeFilterRecord constructor instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern SizeFilterRecord PartSizeFilter { get; }

		// Token: 0x060009F2 RID: 2546
		public extern void AddPartSize(SizeFilterRecord partSizeFilter);

		// Token: 0x060009F3 RID: 2547
		public extern void RemovePartSize(ObjectId partSizeId);

		// Token: 0x060009F4 RID: 2548
		public extern void RemovePartSize(int index);
	}
}
