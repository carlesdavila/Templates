# Templates
dotnet templates

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
Create tasks for your solution in .Net using [Bullseye](https://github.com/adamralph/bullseye) and [SimpleExec](https://github.com/adamralph/simple-exec)

### Install template

```shell 
dotnet new bullseyebuild
```
### Help:
```shell 
./build --help
```

### Debug
Open `build.csproj` with you favorite IDE and debug as usual

> You have to change  `Working Directory` and `Program arguments` in the configuration to Debug
