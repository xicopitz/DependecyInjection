#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /src
COPY ["Quid.DP.WebApi/Quid.DP.WebApi.csproj", "Quid.DP.WebApi/"]
RUN dotnet restore "Quid.DP.WebApi/Quid.DP.WebApi.csproj"
COPY . .
WORKDIR "/src/Quid.DP.WebApi"
RUN dotnet build "Quid.DP.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quid.DP.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Quid.DP.WebApi.dll"]