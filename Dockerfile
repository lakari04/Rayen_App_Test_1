FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rayen_App_Test_1/Rayen_App_Test_1.csproj", "Rayen_App_Test_1/"]
RUN dotnet restore "Rayen_App_Test_1/Rayen_App_Test_1.csproj"
COPY . .
WORKDIR "/src/Rayen_App_Test_1"
RUN dotnet build "Rayen_App_Test_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rayen_App_Test_1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rayen_App_Test_1.dll"]
