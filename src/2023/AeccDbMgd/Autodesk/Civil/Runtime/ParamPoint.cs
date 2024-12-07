using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001222 RID: 4642
	public sealed class ParamPoint : ParamBase<5,Autodesk::AutoCAD::Geometry::Point3d,AcGePoint3d,Autodesk::Civil::Runtime::CastOp<Autodesk::AutoCAD::Geometry::Point3d,AcGePoint3d>\u0020>
	{
		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x060027A4 RID: 10148
		// (set) Token: 0x060027A5 RID: 10149
		public override extern ParamAccessType Access { get; set; }

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x060027A6 RID: 10150
		// (set) Token: 0x060027A7 RID: 10151
		public override extern string DisplayName { get; set; }

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x060027A8 RID: 10152
		// (set) Token: 0x060027A9 RID: 10153
		public override extern string Description { get; set; }

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x060027AA RID: 10154
		// (set) Token: 0x060027AB RID: 10155
		public override extern string Comment { get; set; }

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060027AC RID: 10156
		// (set) Token: 0x060027AD RID: 10157
		public override extern ushort DisplayOrder { get; set; }

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060027AE RID: 10158
		// (set) Token: 0x060027AF RID: 10159
		public override extern bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060027B0 RID: 10160
		// (set) Token: 0x060027B1 RID: 10161
		public override extern Point3d Value { get; set; }

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060027B2 RID: 10162
		// (set) Token: 0x060027B3 RID: 10163
		public extern double Station { get; set; }

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060027B4 RID: 10164
		// (set) Token: 0x060027B5 RID: 10165
		public extern double Offset { get; set; }

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060027B6 RID: 10166
		// (set) Token: 0x060027B7 RID: 10167
		public extern double Elevation { get; set; }

		// Token: 0x060027B8 RID: 10168
		public extern void SetPoint(double station, double offset, double elevation);

		// Token: 0x060027B9 RID: 10169
		public extern void GetPoint(ref double station, ref double offset, ref double elevation);
	}
}
