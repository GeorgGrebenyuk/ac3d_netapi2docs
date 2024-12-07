using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001137 RID: 4407
	public sealed class AppliedAssemblyCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<AppliedAssembly>
	{
		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06002479 RID: 9337
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600247A RID: 9338
		public extern int Count { get; }

		// Token: 0x170012FC RID: 4860
		public extern AppliedAssembly this[int index]
		{
			get;
		}

		// Token: 0x0600247C RID: 9340
		public extern AppliedAssembly GetItemAt(double station);

		// Token: 0x0600247D RID: 9341
		public extern double[] Stations();

		// Token: 0x0600247E RID: 9342
		public extern IEnumerator<AppliedAssembly> GetEnumerator();

		// Token: 0x0600247F RID: 9343
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A8B RID: 6795
		private int <SyntheticNonEmptyStructMarker>;
	}
}
