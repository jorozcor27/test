FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Tienda.sln .
COPY Tienda.API/Tienda.API.csproj Tienda.API/
RUN dotnet restore Tienda.API/Tienda.API.csproj

COPY Tienda.API/ Tienda.API/
WORKDIR /src/Tienda.API
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Tienda.API.dll"]
