# Demo test c# with XUnit

* Create solution using *dotnet new sln*

```cmd
dotnet new sln
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

* Publish project

```cmd
dotnet publish test-app/test-app.csproj -c Release -o publish
```

* Docker build:

```cmd
docker build -f test-app/Dockerfile -t demo-test-xunit:1.0 test-app
```