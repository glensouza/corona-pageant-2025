FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY Corona.Pageant.Web .
RUN dotnet restore "Corona.Pageant.Web.csproj"
RUN dotnet publish "Corona.Pageant.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:9.0
ARG TARGETARCH
EXPOSE 8080
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Corona.Pageant.Web.dll"]
