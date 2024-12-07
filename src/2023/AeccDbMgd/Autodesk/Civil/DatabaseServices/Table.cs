using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000064 RID: 100
	[Wrapper("AeccDbScheduleTable")]
	public class Table : Entity
	{
		// Token: 0x0600045A RID: 1114
		protected internal extern Table(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
