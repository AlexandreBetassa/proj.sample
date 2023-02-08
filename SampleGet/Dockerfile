#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SampleGet/SampleGet.csproj", "SampleGet/"]
RUN dotnet restore "SampleGet/SampleGet.csproj"
COPY . .
WORKDIR "/src/SampleGet"
RUN dotnet build "SampleGet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleGet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleGet.dll"]