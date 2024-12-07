using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011DF RID: 4575
	[Wrapper("AcDbDatabase")]
	public sealed class SubassemblyCollection : CivilWrapper<AcDbDatabase>, IEnumerable<ObjectId>
	{
		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060026A0 RID: 9888
		public extern int Count { get; }

		// Token: 0x170013C7 RID: 5063
		public extern ObjectId this[string subassemblyName]
		{
			get;
		}

		// Token: 0x170013C8 RID: 5064
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x060026A3 RID: 9891
		public extern ObjectIdCollection GetSubassemblyIdsByName(string subassemblyName);

		// Token: 0x060026A4 RID: 9892
		public extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x060026A5 RID: 9893
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060026A6 RID: 9894
		public extern ObjectId Add(string subassemblyName, ObjectId entityId, double midOrdinateDist, LinkCreationType linkCreationOption);

		// Token: 0x060026A7 RID: 9895
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(ObjectId subassemblyId);

		// Token: 0x060026A8 RID: 9896
		public extern void RemoveAt(int index);

		// Token: 0x060026A9 RID: 9897
		public extern ObjectId ImportSubassembly(string subassemblyName, string atcFilePath, string itemId, Point3d location);

		// Token: 0x060026AA RID: 9898
		public extern ObjectId ImportStockSubassembly(string subassemblyName, string className, Point3d location);
	}
}
