\*Create Migration must be in Marlom.Data

* dotnet ef --startup-project ..\MarlomStore.Web\MarlomStore.Web.csproj --project .\MarlomStore.Data.csproj migrations add AddCategory
  #Update Database
* dotnet ef --startup-project ..\MarlomStore.Web\MarlomStore.Web.csproj --project .\MarlomStore.Data.csproj database update
