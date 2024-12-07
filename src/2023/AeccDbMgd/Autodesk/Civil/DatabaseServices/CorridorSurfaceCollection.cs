using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001116 RID: 4374
	public sealed class CorridorSurfaceCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CorridorSurface>
	{
		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06002409 RID: 9225
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x0600240A RID: 9226
		public extern int Count { get; }

		// Token: 0x170012D5 RID: 4821
		public extern CorridorSurface this[string surfaceName]
		{
			get;
		}

		// Token: 0x170012D6 RID: 4822
		public extern CorridorSurface this[int index]
		{
			get;
		}

		// Token: 0x0600240D RID: 9229
		public extern string[] SurfaceNames();

		// Token: 0x0600240E RID: 9230
		public extern CorridorSurface Add(string corridorSurfaceName);

		// Token: 0x0600240F RID: 9231
		public extern CorridorSurface Add(string corridorSurfaceName, ObjectId styleId);

		// Token: 0x06002410 RID: 9232
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CorridorSurface corridorSurface);

		// Token: 0x06002411 RID: 9233
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string corridorSurfaceName);

		// Token: 0x06002412 RID: 9234
		public extern void RemoveAt(int index);

		// Token: 0x06002413 RID: 9235
		public extern IEnumerator<CorridorSurface> GetEnumerator();

		// Token: 0x06002414 RID: 9236
		public extern IEnumerator GetObjectEnumerator();
	}
}
