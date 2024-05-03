# Добавление миграции
#### Linux/MacOS: 
dotnet-ef migrations add InitialCreate --startup-project WebApi/WebApi.csproj --project Infrastructure/Infrastructure.csproj --context DataContext

#### Windows:

---
# Применение миграции
#### Linux/MacOS:
dotnet-ef database update --startup-project WebApi/WebApi.csproj --project Infrastructure/Infrastructure.csproj --context DataContext

#### Windows:
