using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x0200012A RID: 298
	public class DriveDataUtils
	{
		// Token: 0x06000125 RID: 293
		public static extern string Convert(string parameter, double value);

		// Token: 0x06000126 RID: 294
		public static extern ValueType ConvertBack(string parameter, string value);

		// Token: 0x06000127 RID: 295
		public unsafe static extern string ConvertDoubleToString(AeccAttributeTypeInfo* pTypeInfo, double value);

		// Token: 0x06000128 RID: 296
		public unsafe static extern ValueType ConvertStringToDouble(AeccAttributeTypeInfo* pTypeInfo, string value);

		// Token: 0x06000129 RID: 297
		public unsafe static extern AeccAttributeTypeInfo* GetTypeInfo(string parameter);

		// Token: 0x0600012A RID: 298
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsVisualStyle2D(IntPtr visualStyleId);

		// Token: 0x0600012B RID: 299
		public extern DriveDataUtils();
	}
}
