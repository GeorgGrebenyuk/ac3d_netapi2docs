using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000007 RID: 7
	[Wrapper("AeccDbPressurePipe")]
	public sealed class PressurePipe : PressurePart
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600009D RID: 157
		// (set) Token: 0x0600009E RID: 158
		public extern Point3d EndPoint { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600009F RID: 159
		// (set) Token: 0x060000A0 RID: 160
		public extern Point3d StartPoint { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000A1 RID: 161
		public extern double Length2DCenterToCenter { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000A2 RID: 162
		public extern double Length3DCenterToCenter { get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000A3 RID: 163
		public extern double InnerDiameter { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000A4 RID: 164
		public extern double OuterDiameter { get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000A5 RID: 165
		public extern double NominalDiameter { get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000A6 RID: 166
		public extern double Slope { get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000A7 RID: 167
		public extern double WallThickness { get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000A8 RID: 168
		public extern double StartElevation { get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000A9 RID: 169
		public extern double EndElevation { get; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000AA RID: 170
		public extern PressurePartConnection StartConnection { get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000AB RID: 171
		public extern PressurePartConnection EndConnection { get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000AC RID: 172
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Use StartPartId instead.", false)]
		public extern ObjectId StartFittingId { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000AD RID: 173
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Use EndPartId instead.", false)]
		public extern ObjectId EndFittingId { get; }

		// Token: 0x1700006E RID: 110
		// (set) Token: 0x060000AE RID: 174
		public override extern string StyleName { set; }

		// Token: 0x1700006D RID: 109
		// (set) Token: 0x060000AF RID: 175
		public override extern ObjectId StyleId { set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000B0 RID: 176
		public extern ObjectId StartPartId { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000B1 RID: 177
		public extern ObjectId EndPartId { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000B2 RID: 178
		public extern double Bearing { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000B3 RID: 179
		public extern double StartStation { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000B4 RID: 180
		public extern double EndStation { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000B5 RID: 181
		public extern double StartOffset { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000B6 RID: 182
		public extern double EndOffset { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000B7 RID: 183
		public extern double MinimumCover { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000B8 RID: 184
		public extern double MaximumCover { get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000B9 RID: 185
		public extern double HorizontalRadius { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000BA RID: 186
		public extern double VerticalRadius { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000BB RID: 187
		public extern double ChordLength { get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000BC RID: 188
		public extern double StartDir { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000BD RID: 189
		public extern double EndDir { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000BE RID: 190
		public extern Point3d CenterPointLocation { get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000BF RID: 191
		public extern double Bulge { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000C0 RID: 192
		public extern bool IsCurve { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000C1 RID: 193
		public extern bool IsVerticalCurve { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000C2 RID: 194
		public extern bool IsVerticalSag { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C3 RID: 195
		public extern bool HasVerticalSegments { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060000C4 RID: 196
		public extern PipeVerticalSegment[] GetVerticalSegments();

		// Token: 0x060000C5 RID: 197
		public extern void ConnectToPipe(int portIndex, ObjectId pipeId, int pipePortIndex);
	}
}
