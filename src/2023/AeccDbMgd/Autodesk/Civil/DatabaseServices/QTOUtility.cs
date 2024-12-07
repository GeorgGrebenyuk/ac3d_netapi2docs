using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001065 RID: 4197
	public sealed class QTOUtility
	{
		// Token: 0x0600219D RID: 8605
		public static extern void AddPayItemId(ObjectId oid, string payItemID);

		// Token: 0x0600219E RID: 8606
		public static extern StringCollection GetPayItemIds(ObjectId oid);

		// Token: 0x0600219F RID: 8607
		public static extern void DeletePayItemIds(ObjectId oid, StringCollection payItemIDs);

		// Token: 0x060021A0 RID: 8608
		public static extern void DeleteAllPayItemsIds(ObjectId oid);

		// Token: 0x060021A1 RID: 8609
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool OpenPayItemFile(PayItemFileFormat fileFormat, string strPayItemFilePath, string strPayItemCategorizationFilePath);

		// Token: 0x060021A2 RID: 8610
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool GenerateXMLReport(QTOGenerateDetail reportInfo, ref string reportFilePath, ref string[] generatedPayItemIds);

		// Token: 0x060021A3 RID: 8611
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool TransformXMLReport(string relXslFilePath, string strPayItemFilePath, string[] generatedPayItemIds, ref string outFormatFilePath);

		// Token: 0x060021A4 RID: 8612
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool TransformXMLReport(QTOReportFormat __unnamed000, string strPayItemFilePath, string[] generatedPayItemIds, ref string outFormatFilePath);

		// Token: 0x060021A5 RID: 8613
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool DrawXMLReport(QTOReportFormat __unnamed000, string strPayItemFilePath, string[] generatedPayItemIds);

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x060021A6 RID: 8614
		public static extern string PayItemFilePath { get; }

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x060021A7 RID: 8615
		public static extern PayItemFileFormat PayItemFileFormat { get; }

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x060021A8 RID: 8616
		public static extern string PayItemCategorizationPath { get; }
	}
}
