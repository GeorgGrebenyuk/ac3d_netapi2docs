using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200003C RID: 60
	[Wrapper("AeccDbGeo")]
	public class GeoEntity : Entity
	{
		// Token: 0x0600016F RID: 367
		protected internal extern GeoEntity(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
