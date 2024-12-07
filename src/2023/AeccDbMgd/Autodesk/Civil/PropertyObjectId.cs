using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x02000029 RID: 41
	public class PropertyObjectId : Property<Autodesk::AutoCAD::DatabaseServices::ObjectId,AcDbObjectId,Autodesk::Civil::CastOp<Autodesk::AutoCAD::DatabaseServices::ObjectId,AcDbObjectId>\u0020>
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000115 RID: 277
		// (set) Token: 0x06000116 RID: 278
		public override extern ObjectId Value { get; set; }

		// Token: 0x06000117 RID: 279
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040002E0 RID: 736
		private int <SyntheticNonEmptyStructMarker>;
	}
}
