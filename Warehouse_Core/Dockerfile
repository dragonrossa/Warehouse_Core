#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app/client_app
EXPOSE 80
#EXPOSE 443
#EXPOSE 8080

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
WORKDIR /app/client_app
#COPY --from=publish /app/publish .
RUN npm install
RUN npm run build
ENTRYPOINT ["dotnet", "Warehouse_Core.dll"]



## make the 'app' folder the current working directory
#WORKDIR /app/client_app
#
## copy both 'package.json' and 'package-lock.json' (if available)
#COPY package*.json ./
#
## install project dependencies
#RUN npm install
#
## copy project files and folders to the current working directory (i.e. 'app' folder)
##COPY . .
#
## build app for production with minification
#RUN npm run build
#
#