using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A0A RID: 2570
	public sealed class SurfaceAnalysisUserDefinedContourData : ISurfaceAnalysis
	{
		// Token: 0x06001343 RID: 4931
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x06001344 RID: 4932
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001345 RID: 4933
		// (set) Token: 0x06001346 RID: 4934
		public extern string Description { get; set; }

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001347 RID: 4935
		// (set) Token: 0x06001348 RID: 4936
		public extern double Elevation { get; set; }

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001349 RID: 4937
		// (set) Token: 0x0600134A RID: 4938
		public extern Color Color { get; set; }

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600134B RID: 4939
		// (set) Token: 0x0600134C RID: 4940
		public extern ObjectId LineTypeId { get; set; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600134D RID: 4941
		// (set) Token: 0x0600134E RID: 4942
		public extern LineWeight LineWeight { get; set; }

		// Token: 0x0600134F RID: 4943
		public extern SurfaceAnalysisUserDefinedContourData(double elevation, Color color, ObjectId lineTypeId, LineWeight lineWeight);

		// Token: 0x06001350 RID: 4944
		public extern SurfaceAnalysisUserDefinedContourData();

		// Token: 0x040013F4 RID: 5108
		private int <SyntheticNonEmptyStructMarker>;
	}
}
