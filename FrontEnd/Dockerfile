FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/nightly/sdk:5.0 AS build
WORKDIR /src
COPY dinamico.csproj .
RUN ["dotnet", "restore"]
COPY . .
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM nginx AS final
COPY --from=publish /app/publish/wwwroot /usr/share/nginx/html
