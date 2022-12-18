# Demo test c# with XUnit

* Create solution using *dotnet new sln*

```cmd
dotnet new sln
```

* Using **dotnet new --list** show templates enabled:

```cmd
dotnet new --list
```

* Create and add project to solution using *dotnet new console* and *dotnet sln add*

```cmd
dotnet new console -o test-app
dotnet sln add test-app/test-app.csproj
```

* Create and add test project **XUnit** using *dotnet new xunit*

```cmd
dotnet new xunit -o test-proj
dotnet sln add test-proj/test-proj.csproj
```

* Reference **test-app** in **test-proj** using *dotnet add [target project] reference [destination project]*

```cmd
dotnet add test-proj/test-proj.csproj reference test-app/test-app.csproj
```

* Execute test using *dotnet test*

```cmd
dotnet test test-proj/test-proj.csproj
```

* Add version control, create .gitignore file, using comand *dotnet new gitignore*

```cmd
dotnet new gitignore
```

* Optional use extension **.NET Core Test Explorer**

## Publish project

Using **dotnet publish**, in folder *publish*

```cmd
dotnet publish test-app/test-app.csproj -c Release -o publish
```

* Docker build:

Using [dockerfile](test-app/Dockerfile) with publish generated, previously publish using **dotnet publish**:

```cmd
docker build -f publish/Dockerfile -t demo-test-xunit:1.0 publish 
```

This Dockerfile uses multi-stage builds, which optimizes the final size of the image by layering the build and leaving only required artifacts. For more information, see Docker Docs: [multi-stage builds](https://docs.docker.com/build/building/multi-stage/).

In this case, use [Dockerfile.multi](test-app/Dockerfile.multi)

```cmd
docker build -f test-app/Dockerfile.multi -t demo-test-xunit-md:1.0 test-app
```

