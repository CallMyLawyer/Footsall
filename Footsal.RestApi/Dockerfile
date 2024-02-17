FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Footsal.RestApi/Footsal.RestApi.csproj", "Footsal.RestApi/"]
RUN dotnet restore "Footsal.RestApi/Footsal.RestApi.csproj"
COPY . .
WORKDIR "/src/Footsal.RestApi"
RUN dotnet build "Footsal.RestApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Footsal.RestApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Footsal.RestApi.dll"]
