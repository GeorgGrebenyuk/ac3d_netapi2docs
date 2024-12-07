using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000004 RID: 4
	[Wrapper("AeccNetworkPartConnection")]
	public class PressurePartConnection : DisposableWrapper
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600006D RID: 109
		public extern Point3d Position { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600006E RID: 110
		public extern Vector3d Direction { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600006F RID: 111
		public extern double EngagementLength { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000070 RID: 112
		public extern string EngagementLengthUnit { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000071 RID: 113
		public extern double NominalDiameter { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000072 RID: 114
		public extern string NominalDiameterUnit { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000073 RID: 115
		public extern double OutsideDiameter { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000074 RID: 116
		public extern string OutsideDiameterUnit { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000075 RID: 117
		public extern double WallThickness { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000076 RID: 118
		public extern string WallThicknessUnit { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000077 RID: 119
		public extern double Deflection { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000078 RID: 120
		public extern string DeflectionUnit { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000079 RID: 121
		public extern string JointEndType { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007A RID: 122
		public extern bool Open { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123
		public extern ObjectId ConnectedId { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007C RID: 124
		public extern int ConnectedIndex { get; }

		// Token: 0x0600007D RID: 125
		public override extern void DeleteUnmanagedObject();
	}
}
