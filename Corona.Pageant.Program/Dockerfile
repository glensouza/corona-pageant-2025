FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY . .
RUN dotnet restore "Corona.Pageant.Program/Corona.Pageant.Program.csproj"
RUN dotnet publish "Corona.Pageant.Program/Corona.Pageant.Program.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:9.0
ARG TARGETARCH
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Corona.Pageant.Program.dll"]
