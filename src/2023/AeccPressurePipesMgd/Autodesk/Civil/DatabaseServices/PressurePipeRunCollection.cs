using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013A RID: 314
	public sealed class PressurePipeRunCollection : IEnumerable<PressurePipeRun>
	{
		// Token: 0x170000C3 RID: 195
		public extern PressurePipeRun this[string name]
		{
			get;
		}

		// Token: 0x170000C4 RID: 196
		public extern PressurePipeRun this[int index]
		{
			get;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000179 RID: 377
		public extern int Count { get; }

		// Token: 0x0600017A RID: 378
		public extern void Remove(PressurePipeRun pipeRun, [MarshalAs(UnmanagedType.U1)] bool removeParts, [MarshalAs(UnmanagedType.U1)] bool removePath);

		// Token: 0x0600017B RID: 379
		public extern void Remove(PressurePipeRun pipeRun, [MarshalAs(UnmanagedType.U1)] bool completely);

		// Token: 0x0600017C RID: 380
		public extern void RemoveAt(int index, [MarshalAs(UnmanagedType.U1)] bool removeParts, [MarshalAs(UnmanagedType.U1)] bool removePath);

		// Token: 0x0600017D RID: 381
		public extern void RemoveAt(int index, [MarshalAs(UnmanagedType.U1)] bool completely);

		// Token: 0x0600017E RID: 382
		public extern void createPipeRun(string name, Polyline path, PressurePartSize partSize, double depthOfCover, [MarshalAs(UnmanagedType.U1)] bool autoAddBends);

		// Token: 0x0600017F RID: 383
		public extern IEnumerator<PressurePipeRun> GetEnumerator();

		// Token: 0x06000180 RID: 384
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040001BB RID: 443
		private int <SyntheticNonEmptyStructMarker>;
	}
}
