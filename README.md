# Templates

![Templates](logo.png)

_[![NuGet version](https://img.shields.io/nuget/v/BullseyeBuild.Template)](https://www.nuget.org/packages/BullseyeBuild.Template)_

Dotnet templates collection

### Install template

Go to template folder:
```shell 
dotnet new --install .
```
### Uninstall template

Go to template folder:
```shell 
dotnet new --uninstall .
```

## Bullseye Build Template

Includes a build project to create tasks for your solution in .Net using [Bullseye](https://github.com/adamralph/bullseye) and [SimpleExec](https://github.com/adamralph/simple-exec).

Use this project as a starting point for your own build pipeline.

### Install template

```shell 
dotnet new bullseyebuild
```
### Targets
List Targets included:
```shell 
./build -t -i
```
Result:
```shell 
build
└─clean-build-output
clean-artifacts-output
clean-build-output
default
├─run-tests
│ └─build
│   └─clean-build-output
└─publish-artifacts
  └─generate-artifacts
    └─clean-artifacts-output
generate-artifacts
└─clean-artifacts-output
publish-artifacts
└─generate-artifacts
  └─clean-artifacts-output
restore-tools
run-tests
└─build
  └─clean-build-output
  ```
### Help:
```shell 
./build --help
```

### Debug
Open `build.csproj` with you favorite IDE and debug as usual

> You have to change  `Working Directory` and `Program arguments` in the configuration to Debug

---

<sub>[Temple](https://thenounproject.com/icon/temple-2623300/) by [Xinh Studio](https://thenounproject.com/xinhstudio/) from [the Noun Project](https://thenounproject.com/) </sub>