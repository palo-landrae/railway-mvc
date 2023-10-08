build:
	dotnet build
	dotnet build IRailway/IRailway.csproj
	dotnet build RailwayBusLogic/RailwayBusLogic.csproj

clean:
	dotnet clean

restore:
	dotnet restore

watch:
	dotnet watch --project RailwayWeb/RailwayWeb.csproj run

start:
	dotnet run --project RailwayWeb/RailwayWeb.csproj
