FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["CondoQuestionnaire.Migration/CondoQuestionnaire.Migration.csproj", "CondoQuestionnaire.Migration/"]
COPY ["CondoQuestionnaire.Core/CondoQuestionnaire.Core.csproj", "CondoQuestionnaire.Core/"]
COPY ["CondoQuestionnaire.Shared/CondoQuestionnaire.Shared.csproj", "CondoQuestionnaire.Shared/"]

RUN dotnet restore "CondoQuestionnaire.Migration/CondoQuestionnaire.Migration.csproj"

COPY ["CondoQuestionnaire.Migration/", "CondoQuestionnaire.Migration/"]
COPY ["CondoQuestionnaire.Core/", "CondoQuestionnaire.Core/"]
COPY ["CondoQuestionnaire.Shared/", "CondoQuestionnaire.Shared/"]

WORKDIR "/src/CondoQuestionnaire.Migration"
RUN dotnet build "CondoQuestionnaire.Migration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CondoQuestionnaire.Migration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "CondoQuestionnaire.Migration.dll"]
