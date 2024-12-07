using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DFD RID: 3581
	public sealed class AlignmentEntityCollection : CivilWrapper<AeccDbAlignment>, IEnumerable<AlignmentEntity>
	{
		// Token: 0x17000D68 RID: 3432
		public extern AlignmentEntity this[int index]
		{
			get;
		}

		// Token: 0x06001ABE RID: 6846
		public extern AlignmentEntity EntityAtStation(double rawStation);

		// Token: 0x06001ABF RID: 6847
		public extern AlignmentEntity GetEntityByOrder(int index);

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06001AC0 RID: 6848
		public extern int Count { get; }

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06001AC1 RID: 6849
		public extern int FirstEntity { get; }

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06001AC2 RID: 6850
		public extern int LastEntity { get; }

		// Token: 0x06001AC3 RID: 6851
		public extern AlignmentEntity EntityAtId(int id);

		// Token: 0x06001AC4 RID: 6852
		public extern void Remove(AlignmentEntity entity);

		// Token: 0x06001AC5 RID: 6853
		public extern void RemoveAt(int index);

		// Token: 0x06001AC6 RID: 6854
		public extern void Clear();

		// Token: 0x06001AC7 RID: 6855
		public extern AlignmentLine AddFixedLine(int previousEntityId, double distance);

		// Token: 0x06001AC8 RID: 6856
		public extern AlignmentLine AddFixedLine(Point3d startPoint, Point3d endPoint);

		// Token: 0x06001AC9 RID: 6857
		public extern AlignmentLine AddFixedLine(int previousEntityId, Point3d startPoint, Point3d endPoint);

		// Token: 0x06001ACA RID: 6858
		public extern AlignmentArc AddFixedCurve(int previousEntityId, Point3d passThroughPoint);

		// Token: 0x06001ACB RID: 6859
		public extern AlignmentArc AddFixedCurve(Point3d passThroughPoint1, Vector3d directionAtPassThroughPoint1, double radius, [MarshalAs(UnmanagedType.U1)] bool isClockwise);

		// Token: 0x06001ACC RID: 6860
		public extern AlignmentArc AddFixedCurve(int previousEntityId, Point3d passThroughPoint1, Point3d passThroughPoint2, double radius, [MarshalAs(UnmanagedType.U1)] bool isClockwise, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180);

		// Token: 0x06001ACD RID: 6861
		public extern AlignmentArc AddFixedCurve(Point3d passThroughPoint1, Point3d passThroughPoint2, double radius, [MarshalAs(UnmanagedType.U1)] bool isClockwise);

		// Token: 0x06001ACE RID: 6862
		public extern AlignmentArc AddFixedCurve(Point3d passThroughPoint1, Point3d passThroughPoint2, Vector3d directionAtPassThroughPoint2);

		// Token: 0x06001ACF RID: 6863
		public extern AlignmentArc AddFixedCurve(Point3d passThroughPoint1, Vector3d directionAtPassThroughPoint1, Point3d passThroughPoint2);

		// Token: 0x06001AD0 RID: 6864
		public extern AlignmentArc AddFixedCurve(Point3d centerPoint, Point3d passThroughPoint, [MarshalAs(UnmanagedType.U1)] bool isClockwise);

		// Token: 0x06001AD1 RID: 6865
		public extern AlignmentArc AddFixedCurve(Point3d centerPoint, double radius, [MarshalAs(UnmanagedType.U1)] bool isClockwise);

		// Token: 0x06001AD2 RID: 6866
		public extern AlignmentArc AddFixedCurve(int previousEntityId, Point3d startPoint, Point3d middlePoint, Point3d endPoint);

		// Token: 0x06001AD3 RID: 6867
		public extern AlignmentLine AddFreeLine(int previousEntityId, int nextEntityId);

		// Token: 0x06001AD4 RID: 6868
		public extern AlignmentArc AddFreeCurve(int previousEntityId, int nextEntityId, Point3d passThroughPoint);

		// Token: 0x06001AD5 RID: 6869
		public extern AlignmentArc AddFreeCurve(int previousEntityId, int nextEntityId, double paramValue, CurveParamType paramType, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, CurveType curveType);

		// Token: 0x06001AD6 RID: 6870
		public extern AlignmentSCS AddFreeSpiral(int previousEntityId, int nextEntityId, double spParam, SpiralParamType spType, SpiralCurveType spiralCurveType, SpiralType spiralDefinition);

		// Token: 0x06001AD7 RID: 6871
		public extern AlignmentSCS AddFreeSCS(int previousEntityId, int nextEntityId, double spiral1Param, double spiral2Param, SpiralParamType spType, double radius, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AD8 RID: 6872
		public extern AlignmentLine AddFloatingLine(double length, int nextEntityId);

		// Token: 0x06001AD9 RID: 6873
		public extern AlignmentLine AddFloatingLine(Point3d passThroughPoint, int nextEntityId);

		// Token: 0x06001ADA RID: 6874
		public extern AlignmentLine AddFloatingLine(int previousEntityId, double length);

		// Token: 0x06001ADB RID: 6875
		public extern AlignmentLine AddFloatingLine(int previousEntityId, Point3d passThroughPoint);

		// Token: 0x06001ADC RID: 6876
		public extern AlignmentSTS AddFloatingLineWithSpiral(int attachEntityId, EntityAttachType attachType, double spParam, SpiralParamType spType, double tanLength, SpiralType spiralDefinition);

		// Token: 0x06001ADD RID: 6877
		public extern AlignmentSTS AddFloatingLineWithSpiral(int attachEntityId, EntityAttachType attachType, double spParam, SpiralParamType spType, Point3d passThroughPoint, SpiralType spiralDefinition);

		// Token: 0x06001ADE RID: 6878
		public extern AlignmentArc AddFloatingCurve(double radius, double paramValue, CurveParamType paramType, [MarshalAs(UnmanagedType.U1)] bool isClockwise, int nextEntityId);

		// Token: 0x06001ADF RID: 6879
		public extern AlignmentArc AddFloatingCurve(int previousEntityId, double radius, double paramValue, CurveParamType paramType, [MarshalAs(UnmanagedType.U1)] bool isClockwise);

		// Token: 0x06001AE0 RID: 6880
		public extern AlignmentArc AddFloatingCurve(int previousEntityId, Point3d passThroughPoint);

		// Token: 0x06001AE1 RID: 6881
		public extern AlignmentArc AddFloatingCurve(int previousEntityId, Point3d passThroughPoint, Vector3d directionAtPassThroughPoint);

		// Token: 0x06001AE2 RID: 6882
		public extern AlignmentArc AddFloatingCurve(Point3d passThroughPoint, double radius, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, CurveType curveType, int nextEntityId);

		// Token: 0x06001AE3 RID: 6883
		public extern AlignmentArc AddFloatingCurve(Point3d passThroughPoint, int nextEntityId);

		// Token: 0x06001AE4 RID: 6884
		public extern AlignmentArc AddFloatingCurve(Point3d passThroughPoint, Vector3d directionAtPassThroughPoint, int nextEntityId);

		// Token: 0x06001AE5 RID: 6885
		public extern AlignmentArc AddFloatingCurve(int previousEntityId, Point3d passThroughPoint, double radius, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, CurveType curveType);

		// Token: 0x06001AE6 RID: 6886
		public extern AlignmentSCS AddFloatingArcWithSpiral(int attachEntityId, EntityAttachType attachType, double spParam, SpiralParamType spType, double radius, double arcLength, [MarshalAs(UnmanagedType.U1)] bool isClockwise, SpiralType spiralDefinition);

		// Token: 0x06001AE7 RID: 6887
		public extern AlignmentSCS AddFloatingArcWithSpiral(int attachEntityId, EntityAttachType attachType, double spParam, SpiralParamType spType, double radius, Point3d passThroughPoint, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AE8 RID: 6888
		public extern AlignmentSpiral AddFixedSpiral(int previousEntityId, double startRadius, double endRadius, double length, SpiralType spiralDefinition);

		// Token: 0x06001AE9 RID: 6889
		public extern AlignmentSpiral AddFixedSpiral(int previousEntityId, double radius, double length, SpiralCurveType spiralCurveType, SpiralType spiralDefinition);

		// Token: 0x06001AEA RID: 6890
		public extern AlignmentSpiral AddFixedSpiral(int previousEntityId, Point3d startPoint, Point3d spiralPI, Point3d endPoint, SpiralType definitionType);

		// Token: 0x06001AEB RID: 6891
		public extern AlignmentSpiral AddFixedSpiral(int previousEntityId, Point3d startPoint, Point3d spiralPI, double startRadius, double endRadius, double length, [MarshalAs(UnmanagedType.U1)] bool isClockwise, SpiralType spiralDefinition);

		// Token: 0x06001AEC RID: 6892
		public extern AlignmentSpiral AddFixedSpiral(int previousEntityId, Point3d startPoint, Point3d spiralPI, double radius, double length, SpiralCurveType spiralCurveType, [MarshalAs(UnmanagedType.U1)] bool isClockwise, SpiralType spiralDefinition);

		// Token: 0x06001AED RID: 6893
		public extern AlignmentSpiral AddFloatSpiral(double radius, double length, int nextEntityId, [MarshalAs(UnmanagedType.U1)] bool isClockwise, SpiralType spiralDefinition);

		// Token: 0x06001AEE RID: 6894
		public extern AlignmentSpiral AddFloatSpiral(int previousEntityId, double radius, double length, [MarshalAs(UnmanagedType.U1)] bool isClockwise, SpiralType spiralDefinition);

		// Token: 0x06001AEF RID: 6895
		public extern AlignmentSTS AddFreeSSBetweenCurves(int previousEntityId, int nextEntityId, double spRatio, SpiralParamType spType, SpiralType spiralDefinition);

		// Token: 0x06001AF0 RID: 6896
		public extern AlignmentSCS AddFreeSSBetweenTangents(int previousEntityId, int nextEntityId, double spiral1Param, double spiral2Param, SpiralParamType spType, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AF1 RID: 6897
		public extern AlignmentSTS AddFreeSTS(int previousEntityId, int nextEntityId, double tanLength, SpiralType spiralDefinition);

		// Token: 0x06001AF2 RID: 6898
		public extern AlignmentSTS AddFreeSTS(int previousEntityId, int nextEntityId, double sp1Param, double sp2Param, SpiralParamType spType, SpiralType spiralDefinition);

		// Token: 0x06001AF3 RID: 6899
		public extern AlignmentSSCSS AddFloatingSSC(int previousEntityId, double sp1Param, double sp2Param, SpiralParamType spType, Point3d passThroughPoint1, Point3d passThroughPoint2, SpiralType spiralDefinition);

		// Token: 0x06001AF4 RID: 6900
		public extern AlignmentSSCSS AddFloatingSSC(int previousEntityId, double sp1Param, double sp2Param, SpiralParamType spType, double radius, Point3d passThroughPoint, SpiralType spiralDefinition);

		// Token: 0x06001AF5 RID: 6901
		public extern AlignmentSSCSS AddFloatingCSS(int nextEntityId, Point3d passThroughPoint1, Point3d passThroughPoint2, double sp3Param, double sp4Param, SpiralParamType spType, SpiralType spiralDefinition);

		// Token: 0x06001AF6 RID: 6902
		public extern AlignmentSSCSS AddFloatingCSS(int nextEntityId, double radius, Point3d passThroughPoint, double sp3Param, double sp4Param, SpiralParamType spType, SpiralType spiralDefinition);

		// Token: 0x06001AF7 RID: 6903
		public extern AlignmentSSCSS AddFreeSSCS(int previousEntityId, int nextEntityId, double sp1Param, double sp2Param, double radius, double sp3Param, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AF8 RID: 6904
		public extern AlignmentSSCSS AddFreeSCSS(int previousEntityId, int nextEntityId, double sp1Param, double radius, double sp3Param, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AF9 RID: 6905
		public extern AlignmentSSCSS AddFreeSSCSS(int previousEntityId, int nextEntityId, double sp1Param, double sp2Param, double radius, double sp3Param, double sp4Param, [MarshalAs(UnmanagedType.U1)] bool isGreaterThan180, SpiralType spiralDefinition);

		// Token: 0x06001AFA RID: 6906
		public extern AlignmentSCSCS AddFreeSCSCS(int previousEntityId, int nextEntityId, SCSCSConstraints constraintValue, SpiralType spiralDefinition);

		// Token: 0x06001AFB RID: 6907
		public extern AlignmentSCSSCS AddFreeSCSSCS(int previousEntityId, int nextEntityId, SCSSCSConstraints constraintValue, SpiralType spiralDefinition);

		// Token: 0x06001AFC RID: 6908
		public extern IEnumerator<AlignmentEntity> GetEnumerator();

		// Token: 0x06001AFD RID: 6909
		public extern IEnumerator GetObjectEnumerator();
	}
}
