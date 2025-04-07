FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Corona.Pageant.Program/Corona.Pageant.Program.csproj", "Corona.Pageant.Program/"]
RUN dotnet restore "Corona.Pageant.Program/Corona.Pageant.Program.csproj"
COPY . .
WORKDIR "/src/Corona.Pageant.Program"
RUN dotnet build "Corona.Pageant.Program.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Corona.Pageant.Program.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Corona.Pageant.Program.dll"]
