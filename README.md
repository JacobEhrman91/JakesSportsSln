# JakesSportsSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstrating purpose

## Build Script

        dotnet new globaljson --sdk-version 5.0.103 --output JakesSportsSln/SportsGoods
        dotnet new web --no-https --output JakesSportsSln/SportsGoods --framework net5.0
        dotnet new sln -o JakesSportsSln
        dotnet sln JakesSportsSln add JakesSportsSln/SportsGoods
        dotnet new xunit -o JakesSportsSln/SportsGoods.Tests --framework net5.0
        dotnet sln JakesSportsSln add JakesSportsSln/SportsGoods.Tests 
        dotnet add JakesSportsSln/SportsGoods.Tests reference JakesSportsSln/SportsGoods 
