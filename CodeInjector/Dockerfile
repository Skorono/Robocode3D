FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CodeInjector/CodeInjector.csproj", "CodeInjector/"]
RUN dotnet restore "CodeInjector/CodeInjector.csproj"
COPY . .
WORKDIR "/src/CodeInjector"
RUN dotnet build "CodeInjector.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeInjector.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeInjector.dll"]
