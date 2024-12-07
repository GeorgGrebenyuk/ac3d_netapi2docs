using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E48 RID: 3656
	[Wrapper("AeccGeSCSSCSConstraints")]
	public class SCSSCSConstraints : CivilWrapper<AeccGeSCSSCSConstraints>
	{
		// Token: 0x06001B85 RID: 7045
		public static extern SCSSCSConstraints CreateByStartPoint(Point2d startPoint, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B86 RID: 7046
		public static extern SCSSCSConstraints CreateByArc1Angle(double arc1Angle, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B87 RID: 7047
		public static extern SCSSCSConstraints CreateByArc1Length(double arc1Len, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B88 RID: 7048
		public static extern SCSSCSConstraints CreateByArc1PassPt(Point2d ptArc1PassThru, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B89 RID: 7049
		public static extern SCSSCSConstraints CreateByEndPoint(Point2d endPoint, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B8A RID: 7050
		public static extern SCSSCSConstraints CreateByArc2Angle(double arc2Angle, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B8B RID: 7051
		public static extern SCSSCSConstraints CreateByArc2Length(double arc2Len, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);

		// Token: 0x06001B8C RID: 7052
		public static extern SCSSCSConstraints CreateByArc2PassPt(Point2d ptArc2PassThru, double sp1Param, double arc1Radius, double sp2Param, double sp3Param, double arc2Radius, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isParamAValue);
	}
}
