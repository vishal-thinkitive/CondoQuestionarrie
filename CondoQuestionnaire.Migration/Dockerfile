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

CMD dotnet run "CondoQuestionnaire.Migration.csproj"
