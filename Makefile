build:
	dotnet build

clean:
	dotnet clean

restore:
	dotnet restore

watch:
	dotnet watch --project RailwayWeb/RailwayWeb.csproj run

start:
	dotnet run --project RailwayWeb/RailwayWeb.csproj
