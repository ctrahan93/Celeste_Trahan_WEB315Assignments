Author: Celeste Trahan
Date: 28-02-2022
Project Purpose: To create a Razor WebApp Project in ASP.NET 5 
Project Theme: Musicians
Project Title: Celestes Favourite Musicians 

Log of commands in terminal and processes 
1. dotnet new webapp -o CelestesFavouriteMusicians
2. code -r CelestesFavouriteMusicians 
3. dotnet dev-certs https --trust 
4. dotnet run loaded webpage to ensure it worked
5. Editted the index.cshtml page to change welcome message to the theme name and saved changes
6. ctrl+c to shut down the application 
7. dotnet run to reload and see if the changes worked 
8. added @DateTime.Now to the index.cshtml page and author of project
9. ctrl+c to shut down application
10. dotnet run to reload and see if date and time display on index page 
11. Created Models folder and Musicians.cs class and added properties
12. dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
13. dotnet-aspnet-codegenerator razorpage -m Musicians -dc CelestesFavouriteMusiciansContext -udl -outDir Pages/Musicians --referenceScriptLibraries -sqlite
14. dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
15. Change titles on index page, ctrl+c and dotnet run to verify changes 
16. Added link to index file on nav bar under Musicians 
17. Seeded Data by creating Seed_Data_Musicians.cs 
18. ctrl+C and dotnet run to verify the seeded data 
19. Added display name to Musicians.cs for Number of Awards and Number of Albums, ctrl+c and dotnet run to validate changes. 