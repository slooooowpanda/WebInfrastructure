dotnet test "test\Infrastructure\Skeleton.Common.Tests" -c %1
dotnet test "test\Infrastructure\Skeleton.CQRS.Implementations.Tests" -c %1
dotnet test "test\Infrastructure\Skeleton.Dapper.Tests" -c %1
dotnet test "test\Infrastructure\Skeleton.Web.Tests" -c %1
dotnet test "test\Web.Tests" -c %1
