FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 1000
EXPOSE 1001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

COPY ["eCommerce.WebApi.csproj", "./"]
RUN dotnet restore "./eCommerce.WebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "eCommerce.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eCommerce.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eCommerce.WebApi.dll"]
