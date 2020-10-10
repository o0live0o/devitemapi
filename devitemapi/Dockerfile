#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#https://github.com/dotnet/dotnet-docker/blob/master/samples/aspnetapp/Dockerfile
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["devitemapi/devitemapi.csproj", "devitemapi/"]
RUN dotnet restore "devitemapi/devitemapi.csproj"
COPY . .
WORKDIR "/src/devitemapi"
RUN dotnet build "devitemapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "devitemapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "devitemapi.dll"]

