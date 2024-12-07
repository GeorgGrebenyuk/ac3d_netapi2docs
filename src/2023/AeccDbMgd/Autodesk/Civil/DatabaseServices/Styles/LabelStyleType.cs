using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001DA RID: 474
	public enum LabelStyleType
	{
		// Token: 0x0400063F RID: 1599
		GeneralNote = 251704374,
		// Token: 0x04000640 RID: 1600
		GeneralLine,
		// Token: 0x04000641 RID: 1601
		GeneralCurve,
		// Token: 0x04000642 RID: 1602
		GeneralMarker = 251704407,
		// Token: 0x04000643 RID: 1603
		GeneralLink = 251704406,
		// Token: 0x04000644 RID: 1604
		GeneralShape = 251704408,
		// Token: 0x04000645 RID: 1605
		Point = 268481548,
		// Token: 0x04000646 RID: 1606
		SurfaceContour = 251704366,
		// Token: 0x04000647 RID: 1607
		SurfaceSlope,
		// Token: 0x04000648 RID: 1608
		SurfaceSpotElevation = 251704369,
		// Token: 0x04000649 RID: 1609
		SurfaceWatershed = 251704397,
		// Token: 0x0400064A RID: 1610
		ParcelArea = 251704370,
		// Token: 0x0400064B RID: 1611
		ParcelLine,
		// Token: 0x0400064C RID: 1612
		ParcelCurve,
		// Token: 0x0400064D RID: 1613
		AlignmentMajorStation = 251704321,
		// Token: 0x0400064E RID: 1614
		AlignmentMinorStation,
		// Token: 0x0400064F RID: 1615
		AlignmentGeometryPoint,
		// Token: 0x04000650 RID: 1616
		AlignmentProfileGeometryPoint = 251704832,
		// Token: 0x04000651 RID: 1617
		AlignmentStationEquation = 251704324,
		// Token: 0x04000652 RID: 1618
		AlignmentDesignSpeed,
		// Token: 0x04000653 RID: 1619
		AlignmentSuperelevationCriticalPoints = 251704331,
		// Token: 0x04000654 RID: 1620
		AlignmentStationOffset = 251704326,
		// Token: 0x04000655 RID: 1621
		AlignmentLine = 251704328,
		// Token: 0x04000656 RID: 1622
		AlignmentCurve = 251704330,
		// Token: 0x04000657 RID: 1623
		AlignmentSpiral = 251704329,
		// Token: 0x04000658 RID: 1624
		AlignmentTangentIntersection = 251704327,
		// Token: 0x04000659 RID: 1625
		AlignmentPointOfIntersection = 251704833,
		// Token: 0x0400065A RID: 1626
		ProfileMajorStation = 251704333,
		// Token: 0x0400065B RID: 1627
		ProfileMinorStation,
		// Token: 0x0400065C RID: 1628
		ProfileHorizontalGeometryPoint,
		// Token: 0x0400065D RID: 1629
		ProfileGradeBreaks = 251704340,
		// Token: 0x0400065E RID: 1630
		ProfileLine = 251704338,
		// Token: 0x0400065F RID: 1631
		ProfileCurve,
		// Token: 0x04000660 RID: 1632
		ProfileViewStationElevation = 251704346,
		// Token: 0x04000661 RID: 1633
		ProfileViewDepth,
		// Token: 0x04000662 RID: 1634
		ProfileViewProjection = 251704694,
		// Token: 0x04000663 RID: 1635
		SampleLineLabelStyles = 268607503,
		// Token: 0x04000664 RID: 1636
		SectionMajorOffset = 251704399,
		// Token: 0x04000665 RID: 1637
		SectionMinorOffset,
		// Token: 0x04000666 RID: 1638
		SectionGradeBreak,
		// Token: 0x04000667 RID: 1639
		SectionSegment,
		// Token: 0x04000668 RID: 1640
		SectionCorridorPoint = 251704729,
		// Token: 0x04000669 RID: 1641
		SectionViewOffsetElevation = 251704403,
		// Token: 0x0400066A RID: 1642
		SectionViewGrade,
		// Token: 0x0400066B RID: 1643
		SectionViewProjection = 251704695,
		// Token: 0x0400066C RID: 1644
		PipePlanProfile = 251704379,
		// Token: 0x0400066D RID: 1645
		PipeCrossSection = 251704412,
		// Token: 0x0400066E RID: 1646
		StructureLabelStyle = 251704380,
		// Token: 0x0400066F RID: 1647
		IntersectionLocationLabels = 251704697,
		// Token: 0x04000670 RID: 1648
		ViewFrame = 251704607,
		// Token: 0x04000671 RID: 1649
		MatchLineLeft,
		// Token: 0x04000672 RID: 1650
		MatchLineRight,
		// Token: 0x04000673 RID: 1651
		ProfileBandMajorIncrement = 268546560,
		// Token: 0x04000674 RID: 1652
		ProfileBandMinorIncrement = 268546576,
		// Token: 0x04000675 RID: 1653
		ProfileBandHGP = 268546592,
		// Token: 0x04000676 RID: 1654
		ProfileBandVGP = 268546608,
		// Token: 0x04000677 RID: 1655
		ProfileBandStationEquation = 268546624,
		// Token: 0x04000678 RID: 1656
		ProfileBandIncrementalDistance = 268546640,
		// Token: 0x04000679 RID: 1657
		ProfileBandVerticalGeometryUphillTangent = 268546816,
		// Token: 0x0400067A RID: 1658
		ProfileBandVerticalGeometryDownhillTangent = 268546832,
		// Token: 0x0400067B RID: 1659
		ProfileBandVerticalGeometryCrestCurve = 268546848,
		// Token: 0x0400067C RID: 1660
		ProfileBandVerticalGeometrySagCurve = 268546864,
		// Token: 0x0400067D RID: 1661
		ProfileBandHorizontalGeometryTangent = 268547072,
		// Token: 0x0400067E RID: 1662
		ProfileBandHorizontalGeometryCurve = 268547088,
		// Token: 0x0400067F RID: 1663
		ProfileBandHorizontalGeometrySpiral = 268547104,
		// Token: 0x04000680 RID: 1664
		ProfileBandHorizontalGeometryPointOfIntersection = 268547120,
		// Token: 0x04000681 RID: 1665
		ProfileBandSuperelevationDataNormalCrown = 268547328,
		// Token: 0x04000682 RID: 1666
		ProfileBandSuperelevationDataLevelCrown = 268547392,
		// Token: 0x04000683 RID: 1667
		ProfileBandSuperelevationDataReverseCrown = 268547360,
		// Token: 0x04000684 RID: 1668
		ProfileBandSuperelevationDataFullSuper = 268547376,
		// Token: 0x04000685 RID: 1669
		ProfileBandSuperelevationDataShoulderCritical = 268547616,
		// Token: 0x04000686 RID: 1670
		ProfileBandSuperelevationDataSlopeTransition = 268547408,
		// Token: 0x04000687 RID: 1671
		ProfileBandSectionalDataSampleLineLocation = 268547664,
		// Token: 0x04000688 RID: 1672
		ProfileBandSectionalDataIncrementalSectionData = 268547680,
		// Token: 0x04000689 RID: 1673
		ProfileBandPipeNetworkStructureLocation = 268547632,
		// Token: 0x0400068A RID: 1674
		ProfileBandPipeNetworkPipeLocation = 268547648,
		// Token: 0x0400068B RID: 1675
		SectionBandSegmentSurfaceLabels = 268563200,
		// Token: 0x0400068C RID: 1676
		SectionBandMajorIncrement = 268562944,
		// Token: 0x0400068D RID: 1677
		SectionBandMinorIncrement = 268562960,
		// Token: 0x0400068E RID: 1678
		SectionBandCenterline = 268562976,
		// Token: 0x0400068F RID: 1679
		SectionBandGradeBreaks = 268563008,
		// Token: 0x04000690 RID: 1680
		SectionBandSampleLineVertices = 268562992,
		// Token: 0x04000691 RID: 1681
		SectionBandIncrementalDistance = 268563024,
		// Token: 0x04000692 RID: 1682
		ProfileSagCurve = 251704341,
		// Token: 0x04000693 RID: 1683
		ProfileCrestCurve,
		// Token: 0x04000694 RID: 1684
		CatchmentArea = 251704720,
		// Token: 0x04000695 RID: 1685
		CatchmentFlowSegment,
		// Token: 0x04000696 RID: 1686
		PressurePipe = 251704725,
		// Token: 0x04000697 RID: 1687
		Fitting,
		// Token: 0x04000698 RID: 1688
		Appurtenance
	}
}
