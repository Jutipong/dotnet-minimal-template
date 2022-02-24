## Tools & SDK
```bash
* Visual Studio Code
* NET Core SDK 6
```

## Create
```bash
//new solution
dotnet new sln -o dotnet_minimal_template

//new api
dotnet new webapi -minimal -o api
dotnet sln add ./api/api.csproj

//new mstest
dotnet new mstest -o test  
dotnet sln add ./test/test.csproj
```

## EF Core Install
```bash
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

## Extensions
```bash
https://marketplace.visualstudio.com/items?itemName=adrianwilczynski.add-reference
https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer
https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet
https://marketplace.visualstudio.com/items?itemName=Fudge.auto-using
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp
https://marketplace.visualstudio.com/items?itemName=kreativ-software.csharpextensions
https://marketplace.visualstudio.com/items?itemName=kishoreithadi.dotnet-core-essentials
https://marketplace.visualstudio.com/items?itemName=patcx.vscode-nuget-gallery
https://marketplace.visualstudio.com/items?itemName=aliasadidev.nugetpackagemanagergui
https://marketplace.visualstudio.com/items?itemName=logerfo.sln-support
https://marketplace.visualstudio.com/items?itemName=pflannery.vscode-versionlens
https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer
https://marketplace.visualstudio.com/items?itemName=VisualZoran.vz-dotnet-file-templates
https://marketplace.visualstudio.com/items?itemName=VisualZoran.vz-file-templates
```

