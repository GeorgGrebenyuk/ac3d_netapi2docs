# ac3d_netapi2docs
The help documentation for AutoCAD Civil 3D .NET API (create from product's dll via Doxygen)

To show generated online-docs visit page: [https://georggrebenyuk.github.io/ac3d_netapi2docs/](https://georggrebenyuk.github.io/ac3d_netapi2docs/docs/docs_index.md).
To show local-documentation (\*.CHM) look folder `docs_chm`.

# The structire of repo

-`docs`: directory with generated HTML-help via Doxygen;
-`docs_chm`: directory for CHM-files;
-`libs`: directory for .NET DLL assemblies (`original` subfolder contains raw DLL as in product installation; `reference` subfolder contains reference-libraries (maked with [JetBrains Refasmer-library](https://github.com/JetBrains/Refasmer);
-`refasmer_cli`: compiled `RefasmerCliTool`-utility from JetBrains's project (look above);
- `src`: the directory with "source code" of AutoCAD Civil 3D .NET API, produced by reference assemblies and `dnSpy`-utility and cleaned by some auxiliary elements.

- `ac3d_icon.png`: the icon for Doxygen's projects;
`Doxyfile_ac3d`: Doxygen's configs for create documentation for specific version of Civil 3D .NET API;

# Short guide how create docs for need VERSION manually

1. Get libraries from installation folder (from folder like that `"C:\Program Files\Autodesk\AutoCAD VERSION\C3D"`, all assemblies with `Mgd` suffix);
2. Place libraries in `libs\original\VERSION` subfolder;
3. Create a script for Reasmer-utility like below:
```
"refasmer_cli\RefasmerCliTool" --public --omit-non-api-members=false --v --O  "libs\reference\2023" "libs\original\2023\AeccCogoMgd.dll" "libs\original\2023\AeccDataShortcutMgd.dll" "libs\original\2023\AeccDbMgd.dll" "libs\original\2023\AeccHydroCalcsMgd.dll" "libs\original\2023\AeccLogMgd.dll" "libs\original\2023\AeccPressurePipesMgd.dll" "libs\original\2023\AeccUiMgd.dll"
```
4. Open creted libraries in `libs\reference\VERSION` directory in any .NET decompile-utility, f.e. in `dnSpy` and decompile them to project in `src\VERSION`;
5. Clean some files and directories; I had been using Everithing-utility with next config `\src\2023" *_* | *$*  | *&*  | *-*  | std | msclr | *,*`;
6. Create a copy of Doxygen's config in root of repository and set the VERSION-folder in INPUT and OUTPUT tags. To create a local-CHM and html-collection you need edit config manually and run it;
7. Profit!