# Imagem base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# cria usuário não root
RUN useradd -m appuser

# usuário da aplicação
USER appuser

# diretório de trabalho
WORKDIR /app

# porta
EXPOSE 8080

# build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["OrbitalAlert.API.csproj", "./"]

RUN dotnet restore "OrbitalAlert.API.csproj"

COPY . .

RUN dotnet build "OrbitalAlert.API.csproj" -c Release -o /app/build

# publish
FROM build AS publish

RUN dotnet publish "OrbitalAlert.API.csproj" -c Release -o /app/publish

# final
FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "OrbitalAlert.API.dll"]