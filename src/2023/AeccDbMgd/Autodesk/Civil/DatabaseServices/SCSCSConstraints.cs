using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E46 RID: 3654
	[Wrapper("AeccGeSCSCSConstraints")]
	public class SCSCSConstraints : CivilWrapper<AeccGeSCSCSConstraints>
	{
		// Token: 0x06001B78 RID: 7032
		public static extern SCSCSConstraints CreateByTan1Length(double extTan1Len, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B79 RID: 7033
		public static extern SCSCSConstraints CreateByStartPoint(Point2d startPoint, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7A RID: 7034
		public static extern SCSCSConstraints CreateByArc1Angle(double arc1Angle, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7B RID: 7035
		public static extern SCSCSConstraints CreateByArc1Length(double arc1Len, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7C RID: 7036
		public static extern SCSCSConstraints CreateByArc1PassPt(Point2d ptArc1PassThru, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7D RID: 7037
		public static extern SCSCSConstraints CreateByTan2Length(double extTan2Len, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7E RID: 7038
		public static extern SCSCSConstraints CreateByEndPoint(Point2d endPoint, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B7F RID: 7039
		public static extern SCSCSConstraints CreateByArc2Angle(double arc2Angle, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B80 RID: 7040
		public static extern SCSCSConstraints CreateByArc2Length(double arc2Len, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B81 RID: 7041
		public static extern SCSCSConstraints CreateByArc2PassPt(Point2d ptArc2PassThru, double sp1Param, double arc1Radius, double sp2Param, double arc2Radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);
	}
}
