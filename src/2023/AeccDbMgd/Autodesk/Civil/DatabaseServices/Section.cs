using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200005E RID: 94
	[Wrapper("AeccDbSection")]
	public class Section : GeoEntity
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000415 RID: 1045
		public extern ObjectId SampleLineId { get; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000416 RID: 1046
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Section.SampleLineId instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern ObjectId ParentId { get; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000417 RID: 1047
		public virtual extern ObjectId SourceId { get; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000418 RID: 1048
		public extern SectionPointCollection SectionPoints { get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000419 RID: 1049
		// (set) Token: 0x0600041A RID: 1050
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x1700014E RID: 334
		// (set) Token: 0x0600041B RID: 1051
		public override extern string StyleName { set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600041C RID: 1052
		public extern double Station { get; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600041D RID: 1053
		// (set) Token: 0x0600041E RID: 1054
		public extern SectionUpdateType UpdateMode { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600041F RID: 1055
		public extern SectionSourceType SourceType { get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000420 RID: 1056
		public extern double LeftOffset { get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000421 RID: 1057
		public extern double RightOffset { get; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000422 RID: 1058
		// (set) Token: 0x06000423 RID: 1059
		public extern double LeftSwathWidth { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000424 RID: 1060
		// (set) Token: 0x06000425 RID: 1061
		public extern double RightSwathWidth { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000426 RID: 1062
		public extern double MinmumElevation { get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000427 RID: 1063
		public extern double MaximumElevation { get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000428 RID: 1064
		public extern string SourceName { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000429 RID: 1065
		public virtual extern ObjectId CorridorSurfaceId { get; }

		// Token: 0x0600042A RID: 1066
		protected internal extern Section(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
