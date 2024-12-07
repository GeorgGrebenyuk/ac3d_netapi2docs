using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000113 RID: 275
	[Wrapper("AeccDbParcelSegmentLabel")]
	public class ParcelSegmentLabel : GeneralSegmentLabel
	{
		// Token: 0x06000C31 RID: 3121
		public new static extern ObjectId Create(ObjectId featureId, double ratio);

		// Token: 0x06000C32 RID: 3122
		public new static extern ObjectId Create(ObjectId featureId, double ratio, ObjectId lineLabelStyleId, ObjectId curveLabelStyleId);

		// Token: 0x06000C33 RID: 3123
		public new static extern ObjectIdCollection GetAvailableLabelIds(ObjectId featureId);

		// Token: 0x17000534 RID: 1332
		// (set) Token: 0x06000C34 RID: 3124
		public override extern double Ratio { set; }

		// Token: 0x17000533 RID: 1331
		// (set) Token: 0x06000C35 RID: 3125
		public override extern ObjectId LineLabelStyleId { set; }

		// Token: 0x17000532 RID: 1330
		// (set) Token: 0x06000C36 RID: 3126
		public override extern ObjectId CurveLabelStyleId { set; }

		// Token: 0x17000531 RID: 1329
		// (set) Token: 0x06000C37 RID: 3127
		public override extern string StyleName { set; }

		// Token: 0x06000C38 RID: 3128
		protected internal extern ParcelSegmentLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000C39 RID: 3129
		protected override extern void checkStyleId(ObjectId styleId);
	}
}
