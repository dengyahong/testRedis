#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM  microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
EXPOSE 80
#EXPOSE 443
COPY ./publish .
ENTRYPOINT ["dotnet", "TestRedisConnect.dll"]