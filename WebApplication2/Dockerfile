

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
COPY *.csproj .
RUN dotnet restore 
COPY . ./


RUN dotnet publish --no-restore -c Release -o out


FROM mcr.microsoft.com/dotnet/asp.net:5.0

WORKDIR /app
COPY --from=publish-env /app/out .
ENTRYPOINT ["dotnet", "WebApplication2.dll"]