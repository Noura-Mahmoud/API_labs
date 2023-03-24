<br />
<div align="center">
  
  <h3 align="center">API task 2 </h3>

</div>

## Task Requirements
<br/>

## Steps

1. Create *ASP.NET Core Web API* project => uncheck *uncheck *Configur for HTTPS*
2. From *NuGet package manager*, install *Microsoft.EntityFrameworkCore.SqlServer*, *Microsoft.AspNetCore.Mvc.NewtonsoftJson*, *Microsoft.EntityFrameworkCore.Tools* and *Microsoft.EntityFrameworkCore.Proxies*
3. Create *Models* folder and add your entities
4. Create the *dbContext* file
5. Add the query string in *appSetting.json* file   
6. Add *DbService* in *program.cs*
7. In the *PMC*, *add-migration*, *update-database* 
8. Create *Controllers* folder and add Empty WebApi controller
9. Apply proper logic to actions
10. Add 
    ```C#
    builder.Services.AddControllers().AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
    ```
    and
    ```C#
    app.UseHttpsRedirection();
    ```
    in *program.cs*