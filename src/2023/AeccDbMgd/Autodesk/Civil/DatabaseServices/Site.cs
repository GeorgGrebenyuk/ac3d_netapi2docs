using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020006E6 RID: 1766
	[Wrapper("AeccDbFace")]
	public sealed class Site : Entity
	{
		// Token: 0x06000E05 RID: 3589
		public extern ObjectIdCollection GetAlignmentIds();

		// Token: 0x06000E06 RID: 3590
		public extern ObjectIdCollection GetParcelIds();

		// Token: 0x06000E07 RID: 3591
		public extern ObjectIdCollection GetFeatureLineIds();

		// Token: 0x06000E08 RID: 3592
		public static extern ObjectId Create(CivilDocument document, string siteName);

		// Token: 0x06000E09 RID: 3593
		public extern void UseAllClassifications();

		// Token: 0x06000E0A RID: 3594
		public extern void UseNoneClassification();

		// Token: 0x06000E0B RID: 3595
		public extern void UseCustomClassification(UDPClassification udpClassification);

		// Token: 0x06000E0C RID: 3596
		public extern void UseCustomClassification(string name);

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000E0D RID: 3597
		public extern string UDPClassificationName { get; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000E0E RID: 3598
		public extern UDPClassificationApplyType UDPClassificationApplyType { get; }
	}
}
