using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DataShortcuts
{
	// Token: 0x02000015 RID: 21
	public class DataShortcuts : IDisposable
	{
		// Token: 0x06000003 RID: 3
		public static extern void SetWorkingFolder(string newVal);

		// Token: 0x06000004 RID: 4
		public static extern void CreateProjectFolder(string nameFolder, string descrFolder, string pathTemplate, [MarshalAs(UnmanagedType.U1)] bool setAsCurrent);

		// Token: 0x06000005 RID: 5
		public static extern void CreateProjectFolder(string nameFolder, string descrFolder, [MarshalAs(UnmanagedType.U1)] bool setAsCurrent);

		// Token: 0x06000006 RID: 6
		public static extern void CreateProjectFolder(string nameFolder, [MarshalAs(UnmanagedType.U1)] bool setAsCurrent);

		// Token: 0x06000007 RID: 7
		public static extern void SetCurrentProjectFolder(string nameNewDataFolder);

		// Token: 0x06000008 RID: 8
		public static extern IList<string> GetOtherProjectFolders();

		// Token: 0x06000009 RID: 9
		public static extern string GetCurrentProjectFolder();

		// Token: 0x0600000A RID: 10
		public static extern void Validate();

		// Token: 0x0600000B RID: 11
		public static extern string GetAssociateShortcutProjectIdFromDrawing(Database drawing);

		// Token: 0x0600000C RID: 12
		public static extern void AssociateDSProject(string projectId, Database drawing, [MarshalAs(UnmanagedType.U1)] bool isSave);

		// Token: 0x0600000D RID: 13
		public static extern void AssociateDSProject(string projectId, string dwgFilePath);

		// Token: 0x0600000E RID: 14
		public static extern void AssociateDSProject(string projectId);

		// Token: 0x0600000F RID: 15
		public static extern void GetAllProjectFolders(ref string currentProject, ref List<string> otherProjects);

		// Token: 0x06000010 RID: 16
		public static extern string GetWorkingFolder();

		// Token: 0x06000011 RID: 17
		public static extern string GetDescriptionDataShorcutProjectFolder(string nameFolder);

		// Token: 0x06000012 RID: 18
		public static extern string GetDescriptionDataShorcutProjectFolder();

		// Token: 0x06000013 RID: 19
		public static extern ObjectIdCollection CreateReference(Database hostDrawing, string sourceDrawingFilename, string entityName, DataShortcutEntityType dsEntityType);

		// Token: 0x06000014 RID: 20
		public static extern ObjectIdCollection CreateReference(Database hostDrawing, Database sourceDrawing, string entityName, DataShortcutEntityType dsEntityType);

		// Token: 0x06000015 RID: 21
		public static extern string GetDSProjectId(string projectPath);

		// Token: 0x06000016 RID: 22
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool RepairBrokenDRef(ObjectId brokenDRefId, string targetDwgFullPath);

		// Token: 0x06000017 RID: 23
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool RepairBrokenDRef(ObjectId brokenDRefId, string targetDwgFullPath, [MarshalAs(UnmanagedType.U1)] bool autoRepairOther);

		// Token: 0x06000018 RID: 24
		public static extern DataShortcuts.DataShortcutManager CreateDataShortcutManager(ref bool isValidCreation);

		// Token: 0x06000019 RID: 25
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool SaveDataShortcutManager(ref DataShortcuts.DataShortcutManager manager);

		// Token: 0x0600001A RID: 26
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600001B RID: 27
		public sealed extern void Dispose();

		// Token: 0x02000016 RID: 22
		public class DataShortcutManager : IDisposable
		{
			// Token: 0x0600001C RID: 28
			[return: MarshalAs(UnmanagedType.U1)]
			public extern bool SetSelectItemAtIndex(int index, [MarshalAs(UnmanagedType.U1)] bool isSelected);

			// Token: 0x0600001D RID: 29
			[return: MarshalAs(UnmanagedType.U1)]
			public extern bool HasExpired();

			// Token: 0x0600001E RID: 30
			public extern int GetExportableItemsCount();

			// Token: 0x0600001F RID: 31
			public extern DataShortcuts.DataShortcutManager.ExportableItem GetExportableItemAt(int index);

			// Token: 0x06000020 RID: 32
			public extern string GetItemNameAt(int index);

			// Token: 0x06000021 RID: 33
			public extern IList<int> GetDependentItemsIndexList(int index);

			// Token: 0x06000022 RID: 34
			public extern IList<int> GetDirectChildrenItemsIndexList(int index);

			// Token: 0x06000023 RID: 35
			public extern IList<int> GetRecursiveChildrenItemsIndexList(int index);

			// Token: 0x06000024 RID: 36
			public extern IList<int> GetCurrentlySelectedItemsIndexList();

			// Token: 0x06000025 RID: 37
			public extern int GetParentItemIndex(int index);

			// Token: 0x06000026 RID: 38
			[return: MarshalAs(UnmanagedType.U1)]
			public extern bool IsItemAtIndexAlreadyPublished(int index);

			// Token: 0x06000027 RID: 39
			public extern int GetPublishedItemsCount();

			// Token: 0x06000028 RID: 40
			public extern DataShortcuts.DataShortcutManager.PublishedItem GetPublishedItemAt(int index);

			// Token: 0x06000029 RID: 41
			[return: MarshalAs(UnmanagedType.U1)]
			public extern bool RepairBrokenDataShortcut(int index, string targetDwgFullPath, [MarshalAs(UnmanagedType.U1)] bool autoRepairOther);

			// Token: 0x0600002A RID: 42
			[return: MarshalAs(UnmanagedType.U1)]
			public extern bool RepairBrokenDataShortcut(int index, string targetDwgFullPath);

			// Token: 0x0600002B RID: 43
			public extern ObjectIdCollection CreateReference(int index, Database hostDrawing);

			// Token: 0x0600002C RID: 44
			[HandleProcessCorruptedStateExceptions]
			protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

			// Token: 0x0600002D RID: 45
			public sealed extern void Dispose();

			// Token: 0x0600002E RID: 46
			protected override extern void Finalize();

			// Token: 0x04000013 RID: 19
			private int <SyntheticNonEmptyStructMarker>;

			// Token: 0x02000017 RID: 23
			public class ExportableItem
			{
				// Token: 0x17000009 RID: 9
				// (get) Token: 0x0600002F RID: 47
				public extern int Index { get; }

				// Token: 0x17000008 RID: 8
				// (get) Token: 0x06000030 RID: 48
				public extern string Name { get; }

				// Token: 0x17000007 RID: 7
				// (get) Token: 0x06000031 RID: 49
				public extern string Description { get; }

				// Token: 0x17000006 RID: 6
				// (get) Token: 0x06000032 RID: 50
				public extern DataShortcutEntityType DSEntityType { get; }

				// Token: 0x17000005 RID: 5
				// (get) Token: 0x06000033 RID: 51
				public extern bool IsExported { [return: MarshalAs(UnmanagedType.U1)] get; }

				// Token: 0x17000004 RID: 4
				// (get) Token: 0x06000034 RID: 52
				public extern DataShortcuts.DataShortcutManager.ExportableItem ParentItem { get; }

				// Token: 0x17000003 RID: 3
				// (get) Token: 0x06000035 RID: 53
				public extern IList<DataShortcuts.DataShortcutManager.ExportableItem> DirectChildrenItems { get; }

				// Token: 0x17000002 RID: 2
				// (get) Token: 0x06000036 RID: 54
				public extern IList<DataShortcuts.DataShortcutManager.ExportableItem> RecursiveChildrenItems { get; }

				// Token: 0x17000001 RID: 1
				// (get) Token: 0x06000037 RID: 55
				public extern IList<DataShortcuts.DataShortcutManager.ExportableItem> DependentItems { get; }

				// Token: 0x06000038 RID: 56
				public extern ExportableItem(int index, string name, string description, DataShortcutEntityType dsEntityType, [MarshalAs(UnmanagedType.U1)] bool isExported);

				// Token: 0x04000014 RID: 20
				private int <SyntheticNonEmptyStructMarker>;
			}

			// Token: 0x02000018 RID: 24
			public class PublishedItem
			{
				// Token: 0x06000039 RID: 57
				public extern PublishedItem();

				// Token: 0x04000015 RID: 21
				public string Name;

				// Token: 0x04000016 RID: 22
				public string SourceFileName;

				// Token: 0x04000017 RID: 23
				public string SourceLocation;

				// Token: 0x04000018 RID: 24
				public string Description;

				// Token: 0x04000019 RID: 25
				public DataShortcutEntityType DSEntityType;

				// Token: 0x0400001A RID: 26
				public bool IsBroken;
			}
		}
	}
}
