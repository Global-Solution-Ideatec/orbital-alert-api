# Imagem base para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagem para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia csproj
COPY ["OrbitalAlert.API.csproj", "./"]

# Restore
RUN dotnet restore "OrbitalAlert.API.csproj"

# Copia tudo
COPY . .

# Build
RUN dotnet build "OrbitalAlert.API.csproj" -c Release -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "OrbitalAlert.API.csproj" -c Release -o /app/publish

# Imagem final
FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "OrbitalAlert.API.dll"]