# Use Microsoft's official runtime .NET image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use Microsoft's official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy your project and restore as distinct layers
COPY ["SimpleAppCdCi.csproj", "./"]
RUN dotnet restore "SimpleAppCdCi.csproj"

COPY . .
WORKDIR "/src/."
RUN dotnet build "SimpleAppCdCi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleAppCdCi.csproj" -c Release -o /app/publish

# Final stage, copy the publish output to runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Configure the entrypoint
ENTRYPOINT ["dotnet", "SimpleAppCdCi.dll"]
