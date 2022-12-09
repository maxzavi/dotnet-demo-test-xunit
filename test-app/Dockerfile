FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app
COPY  . /app/.
ENV TZ=America/New_York
ENTRYPOINT ["dotnet", "test-app.dll"]