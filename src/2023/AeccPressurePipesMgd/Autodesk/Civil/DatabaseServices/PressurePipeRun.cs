using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200015B RID: 347
	public sealed class PressurePipeRun
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000181 RID: 385
		// (set) Token: 0x06000182 RID: 386
		public extern string Name { get; set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000183 RID: 387
		public extern ObjectId AlignmentId { get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000184 RID: 388
		public extern ObjectId ProfileId { get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000185 RID: 389
		public extern ObjectId ReferenceProfileId { get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000186 RID: 390
		public extern PressurePipeRunVerticalOffsetType VerticalOffsetType { get; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000187 RID: 391
		public extern double VerticalOffset { get; }

		// Token: 0x06000188 RID: 392
		public extern ObjectIdCollection GetPartIds();

		// Token: 0x06000189 RID: 393
		public extern ObjectId AddBendByPI(Point2d point2d);

		// Token: 0x0600018A RID: 394
		public extern void RemoveBendByPI(Point2d point2d);

		// Token: 0x0600018B RID: 395
		public extern ObjectId AddVerticalBendByPVI(double station, double elevation);

		// Token: 0x0600018C RID: 396
		public extern void RemoveVerticalBendByPVI(double station, double elevation);

		// Token: 0x0600018D RID: 397
		public extern PressurePipeRun Break(Point2d point2d, string newPipeRunName);

		// Token: 0x0600018E RID: 398
		public extern void Merge(PressurePipeRun pipeRun);

		// Token: 0x0600018F RID: 399
		public extern void FollowProfile(ObjectId profileId, double offsetValue, [MarshalAs(UnmanagedType.U1)] bool keepFollow);

		// Token: 0x06000190 RID: 400
		public extern void FollowProfile(ObjectId profileId, PressurePipeRunVerticalOffsetType offsetType, double offsetValue, [MarshalAs(UnmanagedType.U1)] bool keepFollow);

		// Token: 0x06000191 RID: 401
		public extern void SetVerticalOffsetType(PressurePipeRunVerticalOffsetType offsetType);

		// Token: 0x06000192 RID: 402
		public extern void ResetReferenceProfile();

		// Token: 0x040001DB RID: 475
		private int <SyntheticNonEmptyStructMarker>;
	}
}
