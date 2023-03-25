<br />
<div align="center">
  
  <h3 align="center">API task 3 </h3>

</div>

## Task Requirements
<br/>

Instructors
- Id
- Name
- Address
- Age
- Phone
- Email
- Password
- Salary
- DOB


Department
- Id
- Name
- Location
- Branches
- Description

![task](https://user-images.githubusercontent.com/61587804/227707440-823f6860-0d04-4177-9b6b-6f8c95cd1a10.jpeg)

## Steps
1. Create *ASP.NET Core Web API* project in visual studio
2. From *NuGet package manager*, install *Microsoft.EntityFrameworkCore.SqlServer* , *Microsoft.EntityFrameworkCore.Tools*
3. Create your classes with proper data annotation in *Models* folder
4. Create your context class, , which inherits from DbContext and pass the *DbContextOptions* to the base, then add the *DbSet* of Instructors and Departments
5. Add connection string in the *AppSetting* file
6. In the *Program.cs* file,
    after this line
    ```C#
    builder.Services.AddControllers();
    ```
    add
    ```C#
    var connectionString = builder.Configuration.GetConnectionString("InsDeptConn") ?? throw new InvalidOperationException("Connection string 'InsDeptConn' not found.");

    builder.Services.AddDbContext<MainDbContext>(
        op => op.UseSqlServer(connectionString)
        );
    ```

7. Open *"Package manager console"* and write *add-migration initial-migration* then *update-database*

8. Implement the controllers with actions using Entity Framework
9. You may need to modify the return of POST actions 
