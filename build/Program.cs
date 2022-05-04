using static Bullseye.Targets;
using static SimpleExec.Command;

const string artifactsDir = "artifacts";

Target(Targets.CleanArtifactsOutput, () =>
{
    if (Directory.Exists(artifactsDir)) Directory.Delete(artifactsDir, true);
});

Target(Targets.GenerateArtifacts, DependsOn(Targets.CleanArtifactsOutput), async () => { await RunAsync("dotnet", $"pack -o {Directory.CreateDirectory(artifactsDir).FullName} --nologo"); });

Target(Targets.RunTests, DependsOn(Targets.GenerateArtifacts), async () =>
{
    // Uninstall BullseyeBuild.Template
    await RunAsync("dotnet", "new --uninstall BullseyeBuild.Template");

    // Install BullseyeBuild.Template
    await RunAsync("dotnet", $"new --install {Path.Combine(artifactsDir, "BullseyeBuild.Template*.nupkg")}");
});

Target("default", DependsOn(Targets.RunTests));

await RunTargetsAndExitAsync(args);

internal static class Targets
{
    public const string CleanArtifactsOutput = "clean-artifacts-output";
    public const string GenerateArtifacts = "generate-artifacts";
    public const string RunTests = "run-tests";
}