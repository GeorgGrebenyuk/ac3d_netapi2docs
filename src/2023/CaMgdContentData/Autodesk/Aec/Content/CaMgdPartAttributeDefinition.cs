using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000043 RID: 67
	public class CaMgdPartAttributeDefinition : IDisposable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C9 RID: 201
		public extern string TableName { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CA RID: 202
		public extern string ColumnName { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CB RID: 203
		public extern CaMgdTypeUsage TypeUsage { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CC RID: 204
		public extern CaMgdContentAttributeType AttributeType { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CD RID: 205
		public extern CaMgdContentValue DefaultValue { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CE RID: 206
		public extern string DisplayName { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CF RID: 207
		public extern string Description { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D0 RID: 208
		public extern int Unit { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D1 RID: 209
		public extern CaMgdMeasuringUnitType UnitType { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D2 RID: 210
		public extern bool IsRequired { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D3 RID: 211
		public extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D4 RID: 212
		public extern bool IsSystem { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000D5 RID: 213
		public extern bool IsReferenceKey { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D6 RID: 214
		public extern CaMgdForeignKeyInfo ForeignKeyInfo { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D7 RID: 215
		public extern int ColumnIndex { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D8 RID: 216
		public unsafe extern CaPartAttributeDefinition* Value { get; }

		// Token: 0x060000D9 RID: 217
		public unsafe extern CaMgdPartAttributeDefinition(CaPartAttributeDefinition* caPartAttributeDefinition);

		// Token: 0x060000DA RID: 218
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000DB RID: 219
		public sealed extern void Dispose();

		// Token: 0x060000DC RID: 220
		protected override extern void Finalize();

		// Token: 0x04000463 RID: 1123
		private int <SyntheticNonEmptyStructMarker>;
	}
}
