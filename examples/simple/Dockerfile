FROM mcr.microsoft.com/dotnet/aspnet:5.0

COPY bin/Release/net5/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "simple.dll"]