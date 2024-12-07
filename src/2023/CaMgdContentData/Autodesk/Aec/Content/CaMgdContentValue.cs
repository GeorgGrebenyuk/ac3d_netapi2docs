using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200003E RID: 62
	public class CaMgdContentValue : IDisposable
	{
		// Token: 0x0600005B RID: 91
		public unsafe extern CaMgdContentValue(CaContentValue* contentValue);

		// Token: 0x0600005C RID: 92
		public unsafe extern CaMgdContentValue(CaContentValue* contentValue, [MarshalAs(UnmanagedType.U1)] bool selfOwned);

		// Token: 0x0600005D RID: 93
		public extern CaMgdContentValue(CaMgdContentValue src);

		// Token: 0x0600005E RID: 94
		public unsafe extern CaMgdContentValue(void* blob, int len);

		// Token: 0x0600005F RID: 95
		public extern CaMgdContentValue(string str);

		// Token: 0x06000060 RID: 96
		public extern CaMgdContentValue(double d);

		// Token: 0x06000061 RID: 97
		public extern CaMgdContentValue([MarshalAs(UnmanagedType.U1)] bool b);

		// Token: 0x06000062 RID: 98
		public extern CaMgdContentValue(int i);

		// Token: 0x06000063 RID: 99
		public extern CaMgdContentValue(long i);

		// Token: 0x06000064 RID: 100
		public extern CaMgdContentValue();

		// Token: 0x06000065 RID: 101
		public extern int Type();

		// Token: 0x06000066 RID: 102
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsNull();

		// Token: 0x06000067 RID: 103
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsValid();

		// Token: 0x06000068 RID: 104
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool AsBool();

		// Token: 0x06000069 RID: 105
		[return: MarshalAs(UnmanagedType.U1)]
		public extern implicit operator bool();

		// Token: 0x0600006A RID: 106
		public extern int AsInt();

		// Token: 0x0600006B RID: 107
		public extern long AsInt64();

		// Token: 0x0600006C RID: 108
		public extern implicit operator long();

		// Token: 0x0600006D RID: 109
		public extern double AsReal();

		// Token: 0x0600006E RID: 110
		public extern implicit operator double();

		// Token: 0x0600006F RID: 111
		public extern string AsString();

		// Token: 0x06000070 RID: 112
		public extern implicit operator string();

		// Token: 0x06000071 RID: 113
		public unsafe extern byte* AsBlob();

		// Token: 0x06000072 RID: 114
		public extern int BlobLen();

		// Token: 0x06000073 RID: 115
		public extern void Reset();

		// Token: 0x06000074 RID: 116
		public unsafe extern void Reset(void* blob, int len, [MarshalAs(UnmanagedType.U1)] bool own);

		// Token: 0x06000075 RID: 117
		public extern void Reset(string str, [MarshalAs(UnmanagedType.U1)] bool own);

		// Token: 0x06000076 RID: 118
		public extern void Reset(float d);

		// Token: 0x06000077 RID: 119
		public extern void Reset(double d);

		// Token: 0x06000078 RID: 120
		public extern void Reset([MarshalAs(UnmanagedType.U1)] bool b);

		// Token: 0x06000079 RID: 121
		public extern void Reset(int i);

		// Token: 0x0600007A RID: 122
		public extern void Reset(long i);

		// Token: 0x0600007B RID: 123
		public extern void Invalidate();

		// Token: 0x0600007C RID: 124
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DuckTypeLess(CaMgdContentValue rhs);

		// Token: 0x0600007D RID: 125
		public static extern void Add(CaMgdContentValue res, CaMgdContentValue a, CaMgdContentValue b);

		// Token: 0x0600007E RID: 126
		public static extern void Sub(CaMgdContentValue res, CaMgdContentValue a, CaMgdContentValue b);

		// Token: 0x0600007F RID: 127
		public static extern void Mul(CaMgdContentValue res, CaMgdContentValue a, CaMgdContentValue b);

		// Token: 0x06000080 RID: 128
		public static extern void Div(CaMgdContentValue res, CaMgdContentValue a, CaMgdContentValue b);

		// Token: 0x06000081 RID: 129
		public static extern void Neg(CaMgdContentValue res);

		// Token: 0x06000082 RID: 130
		public static extern CaMgdContentValue op_Assign(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000083 RID: 131
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator <(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000084 RID: 132
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator >(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000085 RID: 133
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator >=(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000086 RID: 134
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator <=(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000087 RID: 135
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(string __unnamed000, CaMgdContentValue lhs);

		// Token: 0x06000088 RID: 136
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(double d, CaMgdContentValue lhs);

		// Token: 0x06000089 RID: 137
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==([MarshalAs(UnmanagedType.U1)] bool b, CaMgdContentValue lhs);

		// Token: 0x0600008A RID: 138
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(int i, CaMgdContentValue lhs);

		// Token: 0x0600008B RID: 139
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(long i, CaMgdContentValue lhs);

		// Token: 0x0600008C RID: 140
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, string __unnamed001);

		// Token: 0x0600008D RID: 141
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, double d);

		// Token: 0x0600008E RID: 142
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, [MarshalAs(UnmanagedType.U1)] bool b);

		// Token: 0x0600008F RID: 143
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, int i);

		// Token: 0x06000090 RID: 144
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, long i);

		// Token: 0x06000091 RID: 145
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x06000092 RID: 146
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(string __unnamed000, CaMgdContentValue lhs);

		// Token: 0x06000093 RID: 147
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(double d, CaMgdContentValue lhs);

		// Token: 0x06000094 RID: 148
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=([MarshalAs(UnmanagedType.U1)] bool b, CaMgdContentValue lhs);

		// Token: 0x06000095 RID: 149
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(int i, CaMgdContentValue lhs);

		// Token: 0x06000096 RID: 150
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(long i, CaMgdContentValue lhs);

		// Token: 0x06000097 RID: 151
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, string __unnamed001);

		// Token: 0x06000098 RID: 152
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, double d);

		// Token: 0x06000099 RID: 153
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, [MarshalAs(UnmanagedType.U1)] bool b);

		// Token: 0x0600009A RID: 154
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, int i);

		// Token: 0x0600009B RID: 155
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, long i);

		// Token: 0x0600009C RID: 156
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(CaMgdContentValue lhs, CaMgdContentValue rhs);

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009D RID: 157
		public unsafe extern CaContentValue* Value { get; }

		// Token: 0x0600009E RID: 158
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600009F RID: 159
		public sealed extern void Dispose();

		// Token: 0x060000A0 RID: 160
		protected override extern void Finalize();

		// Token: 0x0400045F RID: 1119
		private int <SyntheticNonEmptyStructMarker>;
	}
}
