using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001133 RID: 4403
	[DefaultMember("Item")]
	internal class AssemblyOwnedFilteredCalculatedLinkProvider : CalculatedLinkProvider
	{
		// Token: 0x0600246B RID: 9323
		public unsafe extern AssemblyOwnedFilteredCalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x0600246C RID: 9324
		protected override extern int calculateCount();

		// Token: 0x0600246D RID: 9325
		protected unsafe override extern pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);
	}
}
