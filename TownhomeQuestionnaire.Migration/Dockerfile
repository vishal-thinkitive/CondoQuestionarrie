FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TownhomeQuestionnaire.Migration/TownhomeQuestionnaire.Migration.csproj", "TownhomeQuestionnaire.Migration/"]
RUN dotnet restore "TownhomeQuestionnaire.Migration/TownhomeQuestionnaire.Migration.csproj"
COPY . .
WORKDIR "/src/TownhomeQuestionnaire.Migration"
RUN dotnet build "TownhomeQuestionnaire.Migration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TownhomeQuestionnaire.Migration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TownhomeQuestionnaire.Migration.dll"]
