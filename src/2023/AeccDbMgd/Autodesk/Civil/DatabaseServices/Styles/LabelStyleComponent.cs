using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AD RID: 173
	[Wrapper("AeccDbLabelStyle")]
	public class LabelStyleComponent : StyleBase
	{
		// Token: 0x060007BB RID: 1979
		protected internal extern LabelStyleComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
