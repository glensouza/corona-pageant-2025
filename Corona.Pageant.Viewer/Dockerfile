FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY . .
RUN dotnet restore "./Corona.Pageant.Viewer/Corona.Pageant.Viewer.csproj"
RUN dotnet publish "./Corona.Pageant.Viewer/Corona.Pageant.Viewer.csproj" -c Release -o /app/publish

FROM nginx:stable
EXPOSE 8086
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .
COPY Corona.Pageant.Viewer/nginx.conf /etc/nginx/nginx.conf
