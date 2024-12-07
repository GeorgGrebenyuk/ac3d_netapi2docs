using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000103 RID: 259
	[Wrapper("AeccDbGeneralLabel")]
	public class GeneralSegmentLabel : Label
	{
		// Token: 0x06000BA3 RID: 2979
		public static extern ObjectId Create(ObjectId featureId, double ratio);

		// Token: 0x06000BA4 RID: 2980
		public static extern ObjectId Create(ObjectId featureId, double ratio, ObjectId lineLabelStyleId, ObjectId curveLabelStyleId);

		// Token: 0x06000BA5 RID: 2981
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId featureId);

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000BA6 RID: 2982
		// (set) Token: 0x06000BA7 RID: 2983
		public virtual extern double Ratio { get; set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000BA8 RID: 2984
		// (set) Token: 0x06000BA9 RID: 2985
		public virtual extern ObjectId LineLabelStyleId { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000BAA RID: 2986
		// (set) Token: 0x06000BAB RID: 2987
		public virtual extern ObjectId CurveLabelStyleId { get; set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000BAC RID: 2988
		// (set) Token: 0x06000BAD RID: 2989
		public override extern string StyleName { get; set; }

		// Token: 0x06000BAE RID: 2990
		protected internal extern GeneralSegmentLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000BAF RID: 2991
		protected override extern void checkStyleId(ObjectId styleId);
	}
}
