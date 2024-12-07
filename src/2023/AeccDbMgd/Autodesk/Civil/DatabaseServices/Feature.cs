using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200003D RID: 61
	[Wrapper("AeccDbFeature")]
	public class Feature : Entity
	{
		// Token: 0x06000170 RID: 368
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsEditableFeature(ObjectId featureId);

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000171 RID: 369
		public extern bool IsEditable { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06000172 RID: 370
		protected internal extern Feature(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
