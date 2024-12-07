using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001061 RID: 4193
	public sealed class SizeFilterRecord : IDisposable
	{
		// Token: 0x06002184 RID: 8580
		public extern SizeFilterRecord(PartFamily partFamily);

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002185 RID: 8581
		public extern int ParamCount { get; }

		// Token: 0x170010DE RID: 4318
		public extern SizeFilterField this[string name]
		{
			get;
		}

		// Token: 0x170010DF RID: 4319
		public extern SizeFilterField this[int index]
		{
			get;
		}

		// Token: 0x06002188 RID: 8584
		public extern SizeFilterField GetParamByContextAndIndex(PartContextType context, int index);

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06002189 RID: 8585
		public extern string PartFamilyGuid { get; }

		// Token: 0x0600218A RID: 8586
		public sealed extern void Dispose();

		// Token: 0x04001963 RID: 6499
		private int <SyntheticNonEmptyStructMarker>;
	}
}
