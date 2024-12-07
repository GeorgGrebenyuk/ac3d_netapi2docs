using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F9B RID: 3995
	public abstract class BaseLabelSetItem : CivilWrapper<AeccDbAlignStnLabelsDlgTemplate>
	{
		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06001F3D RID: 7997
		public extern LabelStyleType LabelStyleType { get; }

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06001F3E RID: 7998
		// (set) Token: 0x06001F3F RID: 7999
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06001F40 RID: 8000
		// (set) Token: 0x06001F41 RID: 8001
		public extern string LabelStyleName { get; set; }

		// Token: 0x06001F42 RID: 8002
		protected extern Dictionary<AlignmentPointType, bool> GetLabeledPointTypes<AeccAlignStation::GeometryPointStnType,Autodesk::Civil::AlignmentPointType>();

		// Token: 0x06001F43 RID: 8003
		protected extern Dictionary<ProfilePointType, bool> GetLabeledPointTypes<AeccAlignStation::GeometryPointStnType,Autodesk::Civil::ProfilePointType>();

		// Token: 0x06001F44 RID: 8004
		protected extern Dictionary<SuperelevationPointType, bool> GetLabeledPointTypes<AeccSuperElevationDataElement::TransitionPointType,Autodesk::Civil::SuperelevationPointType>();

		// Token: 0x06001F45 RID: 8005
		protected extern void SetLabeledPointTypes<AeccAlignStation::GeometryPointStnType,Autodesk::Civil::AlignmentPointType>(Dictionary<AlignmentPointType, bool> pointTypes);

		// Token: 0x06001F46 RID: 8006
		protected extern void SetLabeledPointTypes<AeccAlignStation::GeometryPointStnType,Autodesk::Civil::ProfilePointType>(Dictionary<ProfilePointType, bool> pointTypes);

		// Token: 0x06001F47 RID: 8007
		protected extern void SetLabeledPointTypes<AeccSuperElevationDataElement::TransitionPointType,Autodesk::Civil::SuperelevationPointType>(Dictionary<SuperelevationPointType, bool> pointTypes);

		// Token: 0x06001F48 RID: 8008
		protected extern void SetAttributeValue<AeccDbAlignStnLabelsDlgTemplate,double>(uint attributeId, double newValue);

		// Token: 0x06001F49 RID: 8009
		protected extern double GetAttributeValue<AeccDbAlignStnLabelsDlgTemplate,double>(uint attributeId);

		// Token: 0x06001F4A RID: 8010
		protected unsafe extern void ValidateDistance(double newValue, char* szSettingsRoot, AeccAttributeTypeInfo.RangeType nRangeType, uint nAttrId);

		// Token: 0x06001F4B RID: 8011
		protected unsafe extern void ValidatePlotHeight(double newValue, char* szSettingsRoot, AeccAttributeTypeInfo.RangeType nRangeType);

		// Token: 0x06001F4C RID: 8012
		protected extern double GetDrawingValue(double newValue);

		// Token: 0x06001F4D RID: 8013
		protected extern void SetAttributeValue<AeccDbVAlignStnLabelsDlgTemplate,double>(uint attributeId, double newValue);

		// Token: 0x06001F4E RID: 8014
		protected extern void SetAttributeValue<AeccDbVAlignStnLabelsDlgTemplate,int>(uint attributeId, int newValue);

		// Token: 0x06001F4F RID: 8015
		protected extern double GetAttributeValue<AeccDbVAlignStnLabelsDlgTemplate,double>(uint attributeId);

		// Token: 0x06001F50 RID: 8016
		protected extern int GetAttributeValue<AeccDbVAlignStnLabelsDlgTemplate,int>(uint attributeId);

		// Token: 0x06001F51 RID: 8017
		protected extern void SetAttributeValue<AeccDbSectionLabelsDlgTemplate,double>(uint attributeId, double newValue);

		// Token: 0x06001F52 RID: 8018
		protected extern void SetAttributeValue<AeccDbSectionLabelsDlgTemplate,int>(uint attributeId, int newValue);

		// Token: 0x06001F53 RID: 8019
		protected extern double GetAttributeValue<AeccDbSectionLabelsDlgTemplate,double>(uint attributeId);

		// Token: 0x06001F54 RID: 8020
		protected extern int GetAttributeValue<AeccDbSectionLabelsDlgTemplate,int>(uint attributeId);

		// Token: 0x06001F55 RID: 8021
		protected extern void SetAttributeValue<AeccDbAlignStnLabelsDlgTemplate,AcDbObjectId>(uint attributeId, AcDbObjectId newValue);

		// Token: 0x06001F56 RID: 8022
		protected unsafe extern AcDbObjectId* GetAttributeValue<AeccDbAlignStnLabelsDlgTemplate,AcDbObjectId>(AcDbObjectId*, uint attributeId);

		// Token: 0x0400186C RID: 6252
		private int <SyntheticNonEmptyStructMarker>;
	}
}
