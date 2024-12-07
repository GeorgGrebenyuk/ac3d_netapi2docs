using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000045 RID: 69
	public class CaMgdPartSet : IDisposable
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E6 RID: 230
		public extern CaMgdPartDefinition PartDefinition { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E7 RID: 231
		public extern List<CaMgdPart> Parts { get; }

		// Token: 0x060000E8 RID: 232
		public extern int GetEngineeringPropertyIndex(string propertyName);

		// Token: 0x060000E9 RID: 233
		public extern int GetConnectionPointPropertyIndex(string propertyName);

		// Token: 0x060000EA RID: 234
		public extern CaMgdPart CreateNewPart(int connectionPointCount);

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EB RID: 235
		public extern string Industry { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EC RID: 236
		public extern string Domain { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000ED RID: 237
		public extern string PartType { get; }

		// Token: 0x060000EE RID: 238
		public extern List<string> GetPartFamilies();

		// Token: 0x060000EF RID: 239
		public extern List<string> GetPartFamilyNames();

		// Token: 0x060000F0 RID: 240
		public extern List<string> GetPartSizes(string partFamilyId);

		// Token: 0x060000F1 RID: 241
		public extern List<CaMgdContentValue> GetAvailableValues(string propertyName, CaMgdFilters filter);

		// Token: 0x060000F2 RID: 242
		public extern List<CaMgdContentValue> GetAvailableValues(string propertyName);

		// Token: 0x060000F3 RID: 243
		public extern List<CaMgdPart> GetAvailableParts(CaMgdFilters filter);

		// Token: 0x060000F4 RID: 244
		public unsafe extern CaMgdPartSet(CaPartSet* caPartSet);

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F5 RID: 245
		public unsafe extern CaPartSet* Value { get; }

		// Token: 0x060000F6 RID: 246
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000F7 RID: 247
		public sealed extern void Dispose();

		// Token: 0x060000F8 RID: 248
		protected override extern void Finalize();

		// Token: 0x04000465 RID: 1125
		private int <SyntheticNonEmptyStructMarker>;
	}
}
