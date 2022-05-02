using static Bullseye.Targets;
using static SimpleExec.Command;

const string artifactsDir = "artifacts";

Target(Targets.CleanArtifactsOutput, () =>
{
    if (Directory.Exists(artifactsDir)) Directory.Delete(artifactsDir, true);
});

Target(Targets.GenerateArtifacts, DependsOn(Targets.CleanArtifactsOutput), async () =>
{
    await RunAsync("dotnet", $"pack -o {Directory.CreateDirectory(artifactsDir).FullName} --nologo");
});

Target("default", DependsOn(Targets.GenerateArtifacts));

await RunTargetsAndExitAsync(args);

internal static class Targets
{
    public const string CleanArtifactsOutput = "clean-artifacts-output";
    public const string GenerateArtifacts = "generate-artifacts";
}