using System;

namespace Autodesk.Civil
{
	// Token: 0x02000026 RID: 38
	public class PropertyString : Property<System::String\u0020^,AecRmCString,Autodesk::Civil::CastOp<System::String\u0020^,AecRmCString>\u0020>
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		public override extern string Value { get; set; }

		// Token: 0x060000FF RID: 255
		protected extern void PutValueSymbol<AcDbBlockTable>(string symbolName);

		// Token: 0x06000100 RID: 256
		protected extern string GetValueSymbol<AcDbBlockTable>();

		// Token: 0x06000101 RID: 257
		protected extern void PutValueSymbol<AcDbLayerTable>(string symbolName);

		// Token: 0x06000102 RID: 258
		protected extern string GetValueSymbol<AcDbLayerTable>();

		// Token: 0x06000103 RID: 259
		protected extern void PutValueSymbol<AcDbLinetypeTable>(string symbolName);

		// Token: 0x06000104 RID: 260
		protected extern string GetValueSymbol<AcDbLinetypeTable>();

		// Token: 0x06000105 RID: 261
		protected extern void PutValueSymbol<AcDbTextStyleTable>(string symbolName);

		// Token: 0x06000106 RID: 262
		protected extern string GetValueSymbol<AcDbTextStyleTable>();
	}
}
