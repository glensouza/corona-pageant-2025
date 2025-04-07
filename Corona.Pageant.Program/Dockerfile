FROM mcr.microsoft.com/dotnet/sdk:9.0-noble-arm64v8mcr.microsoft.com/dotnet/sdk:9.0-noble-arm64v8 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Corona.Pageant.Program/Corona.Pageant.Program.csproj"
RUN dotnet build "Corona.Pageant.Program/Corona.Pageant.Program.csproj" -c Release -o /app/build
RUN dotnet publish "Corona.Pageant.Program/Corona.Pageant.Program.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0-noble-arm64v8
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Corona.Pageant.Program.dll"]
