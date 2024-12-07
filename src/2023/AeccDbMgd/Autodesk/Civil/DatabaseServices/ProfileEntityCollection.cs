using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F01 RID: 3841
	public sealed class ProfileEntityCollection : CivilWrapper<AeccDbVAlignment>, IEnumerable<ProfileEntity>
	{
		// Token: 0x17000E75 RID: 3701
		public extern ProfileEntity this[int index]
		{
			get;
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06001CD5 RID: 7381
		public extern int Count { get; }

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06001CD6 RID: 7382
		public extern uint FirstEntity { get; }

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06001CD7 RID: 7383
		public extern uint LastEntity { get; }

		// Token: 0x06001CD8 RID: 7384
		public extern ProfileEntity EntityAtId(uint id);

		// Token: 0x06001CD9 RID: 7385
		public extern IEnumerator<ProfileEntity> GetEnumerator();

		// Token: 0x06001CDA RID: 7386
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001CDB RID: 7387
		public extern void Remove(ProfileEntity entity);

		// Token: 0x06001CDC RID: 7388
		public extern void RemoveAt(int index);

		// Token: 0x06001CDD RID: 7389
		public extern void Clear();

		// Token: 0x06001CDE RID: 7390
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileTangent AddFixedTangent(Point3d startPoint, Point3d endPoint);

		// Token: 0x06001CDF RID: 7391
		public extern ProfileTangent AddFixedTangent(Point2d startPoint, Point2d endPoint);

		// Token: 0x06001CE0 RID: 7392
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileTangent AddFixedTangentWithPreviousEntity(uint previousEntityId, Point3d startPoint, Point3d endPoint);

		// Token: 0x06001CE1 RID: 7393
		public extern ProfileTangent AddFixedTangentWithPreviousEntity(uint previousEntityId, Point2d startPoint, Point2d endPoint);

		// Token: 0x06001CE2 RID: 7394
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileTangent AddFloatingTangent(uint entityId, Point3d passPoint, EntityAttachType attachType);

		// Token: 0x06001CE3 RID: 7395
		public extern ProfileTangent AddFloatingTangent(uint entityId, Point2d passPoint, EntityAttachType attachType);

		// Token: 0x06001CE4 RID: 7396
		public extern ProfileTangent AddFreeTangent(uint previousEntityId, uint nextEntityId);

		// Token: 0x06001CE5 RID: 7397
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByThreePoints(Point3d point, Point3d point2, Point3d point3);

		// Token: 0x06001CE6 RID: 7398
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByThreePoints(Point2d point, Point2d point2, Point2d point3);

		// Token: 0x06001CE7 RID: 7399
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndK(Point3d point1, Point3d point2, VerticalCurveType curveType, double k);

		// Token: 0x06001CE8 RID: 7400
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndK(Point2d point1, Point2d point2, VerticalCurveType curveType, double k);

		// Token: 0x06001CE9 RID: 7401
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndRadius(Point3d point1, Point3d point2, VerticalCurveType curType, double radius);

		// Token: 0x06001CEA RID: 7402
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndRadius(Point2d point1, Point2d point2, VerticalCurveType curType, double radius);

		// Token: 0x06001CEB RID: 7403
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByEntityEndAndThroughPoint(uint attachEntityId, Point3d passPoint);

		// Token: 0x06001CEC RID: 7404
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByEntityEndAndThroughPoint(uint attachEntityId, Point2d passPoint);

		// Token: 0x06001CED RID: 7405
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndStartGrade(Point3d point1, Point3d point2, double startGrade);

		// Token: 0x06001CEE RID: 7406
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndStartGrade(Point2d point1, Point2d point2, double startGrade);

		// Token: 0x06001CEF RID: 7407
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndEndGrade(Point3d point1, Point3d point2, double endGrade);

		// Token: 0x06001CF0 RID: 7408
		public extern ProfileParabolaSymmetric AddFixedSymmetricParabolaByTwoPointsAndEndGrade(Point2d point1, Point2d point2, double endGrade);

		// Token: 0x06001CF1 RID: 7409
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndK(uint attachEntityId, Point3d passPoint, double k, EntityAttachType attachType);

		// Token: 0x06001CF2 RID: 7410
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndK(uint attachEntityId, Point2d passPoint, double k, EntityAttachType attachType);

		// Token: 0x06001CF3 RID: 7411
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndRadius(uint attachEntityId, Point3d passPoint, double radius, EntityAttachType attachType);

		// Token: 0x06001CF4 RID: 7412
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndRadius(uint attachEntityId, Point2d passPoint, double radius, EntityAttachType attachType);

		// Token: 0x06001CF5 RID: 7413
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndGrade(uint attachEntityId, Point3d passPoint, double grade, EntityAttachType attachType);

		// Token: 0x06001CF6 RID: 7414
		public extern ProfileParabolaSymmetric AddFloatingSymmetricParabolaByThroughPointAndGrade(uint attachEntityId, Point2d passPoint, double grade, EntityAttachType attachType);

		// Token: 0x06001CF7 RID: 7415
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByLength(uint previousEntityId, uint nextEntityId, VerticalCurveType curveType, double length, [MarshalAs(UnmanagedType.U1)] bool preferFlat);

		// Token: 0x06001CF8 RID: 7416
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByK(uint previousEntityId, uint nextEntityId, VerticalCurveType curveType, double k);

		// Token: 0x06001CF9 RID: 7417
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByRadius(uint previousEntityId, uint nextEntityId, VerticalCurveType curveType, double radius);

		// Token: 0x06001CFA RID: 7418
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByPVIAndCurveLength(ProfilePVI attachProfilePVI, double curveLength);

		// Token: 0x06001CFB RID: 7419
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		[DeprecatedVersion(CivilVersion.Civil2011)]
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByPVIAndThroughPoint(ProfilePVI attachProfilePVI, Point3d passPoint);

		// Token: 0x06001CFC RID: 7420
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByPVIAndThroughPoint(ProfilePVI attachProfilePVI, Point2d passPoint);

		// Token: 0x06001CFD RID: 7421
		public extern ProfileParabolaSymmetric AddFreeSymmetricParabolaByPVIAndK(ProfilePVI attachProfilePVI, double k);

		// Token: 0x06001CFE RID: 7422
		public extern ProfileParabolaAsymmetric AddFreeAsymmetricParabolaByPVIAndLengths(ProfilePVI attachProfilePVI, double length1, double length2);

		// Token: 0x06001CFF RID: 7423
		[DeprecatedVersion(CivilVersion.Civil2011)]
		[Obsolete("Use the overload method which takes Point2d as parameter(s).", false)]
		public extern ProfileCircular AddFreeCircularCurveByPVIAndThroughPoint(ProfilePVI attachProfilePVI, Point3d passPoint);

		// Token: 0x06001D00 RID: 7424
		public extern ProfileCircular AddFreeCircularCurveByPVIAndThroughPoint(ProfilePVI attachProfilePVI, Point2d passPoint);

		// Token: 0x06001D01 RID: 7425
		public extern ProfileCircular AddFreeCircularCurveByPVIAndRadius(ProfilePVI attachProfilePVI, double radius);

		// Token: 0x06001D02 RID: 7426
		public extern ProfileCircular AddFreeCircularCurveByPVIAndLength(ProfilePVI attachProfilePVI, double length);
	}
}
