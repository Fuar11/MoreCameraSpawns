using BuildInfo = MoreCameraSpawns.BuildInfo;

[assembly: AssemblyTitle(BuildInfo.Name)]

[assembly: AssemblyVersion(BuildInfo.Version)]
[assembly: AssemblyFileVersion(BuildInfo.Version)]

[assembly: MelonInfo(typeof(MoreCameraSpawns.Main), BuildInfo.GUIName, BuildInfo.Version, BuildInfo.Author)]
[assembly: MelonGame("Hinterland", "TheLongDark")]

[assembly: VerifyLoaderVersion(BuildInfo.MelonLoaderVersion, true)]
[assembly: MelonIncompatibleAssemblies(null)]
