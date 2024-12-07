using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001194 RID: 4500
	public sealed class AssemblyCollection : CivilWrapper<AcDbDatabase>, IEnumerable<ObjectId>
	{
		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x060025A3 RID: 9635
		public extern int Count { get; }

		// Token: 0x1700138A RID: 5002
		public extern ObjectId this[string assemblyName]
		{
			get;
		}

		// Token: 0x1700138B RID: 5003
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x060025A6 RID: 9638
		public extern ObjectId Add(string assemblyName, AssemblyType type, Point3d location, ObjectId styleId, ObjectId codeSetStyleId);

		// Token: 0x060025A7 RID: 9639
		public extern ObjectId Add(string assemblyName, AssemblyType type, Point3d location);

		// Token: 0x060025A8 RID: 9640
		public extern ObjectId ImportAssembly(string assemblyName, Database sourceDatabase, string sourceAssemblyName, Point3d location);

		// Token: 0x060025A9 RID: 9641
		public extern ObjectId ImportAssembly(string assemblyName, string atcFilePath, string itemId, Point3d location);

		// Token: 0x060025AA RID: 9642
		public extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x060025AB RID: 9643
		public extern IEnumerator GetObjectEnumerator();
	}
}
