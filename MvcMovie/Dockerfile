FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

WORKDIR /app
COPY "./MvcMovie.csproj" .
RUN dotnet restore "./MvcMovie.csproj"
COPY . .
RUN dotnet publish "./MvcMovie.csproj" -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["./MvcMovie"]
ENV ASPNETCORE_URLS=http://+:80