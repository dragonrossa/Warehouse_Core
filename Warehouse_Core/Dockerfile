#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Warehouse_Core/Warehouse_Core.csproj", "Warehouse_Core/"]
RUN dotnet restore "Warehouse_Core/Warehouse_Core.csproj"
COPY . .
WORKDIR "/src/Warehouse_Core"
RUN dotnet build "Warehouse_Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Warehouse_Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Warehouse_Core.dll"]