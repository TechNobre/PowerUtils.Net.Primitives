dotnet tool restore
dotnet restore
dotnet build --no-restore
dotnet stryker -tp tests/PowerUtils.Net.Primitives.Tests/PowerUtils.Net.Primitives.Tests.csproj --reporter cleartext --reporter html -o