# Making a New App
dotnet new console -o <file_name>

# Making a New Solution
dotnet new sln

Solutions will contain multiple projs

# Making a new Class Library
dotnet new classlib -o <Library_Name>

## Add Class Library to Solution
dotnet sln add <Library_Name>/<Library_Name>.csproj


# Add Library Reference to Proj
dotnet add ShowCase/ShowCase.csproj reference <Library_Name>/<Library_Name>.csproj





# Reference
https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-5-0