using System.Linq;

using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MinVer;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[GitHubActions(
    "continuous",
    GitHubActionsImage.UbuntuLatest,
    On = new[] { GitHubActionsTrigger.Push, },
    InvokedTargets = new[] { nameof(Clean), nameof(PublishToNuget) },
    AutoGenerate = true,
    FetchDepth = 0,
    ImportSecrets = new[] { "NUGET_API_KEY" })]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    public Build()
    {
        OutputPath = RootDirectory / "out";
    }

    [Parameter]
    readonly string NugetApiKey;

    [Solution(GenerateProjects = true)]
    readonly Solution Solution;

    [MinVer]
    readonly MinVer MinVer;

    readonly AbsolutePath OutputPath;

    Target Clean => _ => _
        .Executes(() =>
        {
            OutputPath.CreateOrCleanDirectory();
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(settings => settings
                .SetProjectFile(Solution.Bld_Libnl_Net));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(settings => settings
                .SetNoRestore(true)
                .SetProjectFile(Solution.Bld_Libnl_Net)
                .SetConfiguration(Configuration));
        });

    Target Publish => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetPack(settings => settings
                .SetConfiguration(Configuration)
                .SetNoBuild(true)
                .SetProject(Solution.Bld_Libnl_Net)
                .SetOutputDirectory(OutputPath)
                .SetVersion(MinVer.PackageVersion));
        });

    Target PublishToNuget => _ => _
        .DependsOn(Publish)
        .Executes(() =>
        {
            DotNetNuGetPush(settings => settings
                .SetApiKey(NugetApiKey)
                .SetTargetPath(OutputPath.GlobFiles("*.nupkg").First())
                .SetSource("https://api.nuget.org/v3/index.json"));
        });

}
