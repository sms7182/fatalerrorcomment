#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Relex.BrandReputation.WebApi/Relex.BrandReputation.WebApi.csproj", "Relex.BrandReputation.WebApi/"]
COPY ["Relex.BrandReputation.Domain/Relex.BrandReputation.Domain.csproj","Relex.BrandReputation.Domain/"]
COPY ["Relex.BrandReputation.Data/Relex.BrandReputation.Data.csproj","Relex.BrandReputation.Data/"]
COPY ["Relex.BrandReputation.Service/Relex.BrandReputation.Service.csproj","Relex.BrandReputation.Service/"]
COPY ["Relex.BrandReputation.Core/Relex.BrandReputation.Core.csproj","Relex.BrandReputation.Core/"]
RUN dotnet restore "Relex.BrandReputation.WebApi/Relex.BrandReputation.WebApi.csproj"
COPY . .
WORKDIR "/src/Relex.BrandReputation.WebApi"
RUN dotnet build "Relex.BrandReputation.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Relex.BrandReputation.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Relex.BrandReputation.WebApi.dll"]