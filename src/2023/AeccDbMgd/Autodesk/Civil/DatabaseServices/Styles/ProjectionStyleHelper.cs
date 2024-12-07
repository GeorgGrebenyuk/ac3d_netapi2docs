using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200008B RID: 139
	internal class ProjectionStyleHelper
	{
		// Token: 0x0600062B RID: 1579
		public unsafe extern ProjectionStyleHelper(AeccDbProfileSectionEntityStyle* pProjectionOption);

		// Token: 0x0600062C RID: 1580
		public extern ObjectId InternalGetMarkerStyleId(uint attributeId);

		// Token: 0x0600062D RID: 1581
		public extern void InternalSetMarkerStyleId(ObjectId newVal, uint attributeId);

		// Token: 0x0600062E RID: 1582
		public extern string InternalGetMarkerStyleName(uint attributeId);

		// Token: 0x0600062F RID: 1583
		public extern void InternalSetMarkerStyleName(string newVal, uint attributeId);

		// Token: 0x06000630 RID: 1584
		public static extern void CheckArgValidBlock(ObjectId argOid);

		// Token: 0x06000631 RID: 1585
		public extern void SetBlockByName(string newValue, uint attributeId);

		// Token: 0x06000632 RID: 1586
		public static extern ObjectId GetDispRepOidFromName(string name);

		// Token: 0x06000633 RID: 1587
		public static extern string GetDispRepNameFromOid(ObjectId argOid);

		// Token: 0x06000634 RID: 1588
		public static extern void CheckArgValidDispRep(ObjectId argOid);

		// Token: 0x04000303 RID: 771
		private int <SyntheticNonEmptyStructMarker>;
	}
}
