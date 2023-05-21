
# .NET7 Clean Architecture very basic template

## Create new migration
```
dotnet ef migrations add InitialCreate -p ./src/Infrastructure/Hello.Infrastructure -s ./src/API/Hello.WebApi --output-dir Store/Migrations
```

## Apply Migration
```
dotnet ef database update -p ./src/Infrastructure/Hello.Infrastructure -s ./src/API/Hello.WebApi
```

## Run the project
```
dotnet run --project ./src/API/Hello.WebApi
```