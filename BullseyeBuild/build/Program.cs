using static Bullseye.Targets;

Target("make-tea", () => Console.WriteLine("Tea made."));
Target("drink-tea", DependsOn("make-tea"), () => Console.WriteLine("Ahh... lovely!"));
Target("walk-dog", () => Console.WriteLine("Walkies!"));
Target("default", DependsOn("drink-tea", "walk-dog"));

await RunTargetsAndExitAsync(args);