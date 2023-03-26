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
<br />


## Steps of API
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

<hr>
<hr>




## JWT
## Steps
1. In your API project, from *NuGet package manager*, install *Microsoft.AspNetCore.Identity.EntityFrameworkCore* and *Microsoft.AspNetCore.Authentication.JwtBearer*
2. Add *AppIdentityUser* calss that inherits from *IdentityUser*
3. Change the context file to make it inherits from *IdentityDbContext<AppIdentityUser>* to add tables for users and see changes we make in this class
4. Add migration and update database
5. Add empty API controller to controll accounts
6. Create your *RegisterUserDTO* class
7. In the controller class, inject *UserManager<AppIdentityUser>* into the ctor
8. Build your register function like 
  ```C#
  [HttpPost("register")]
        public async Task<IActionResult> Registeration(RegisterUserDTO userDto)
        {
            if(ModelState.IsValid)
            {
                //save
                AppIdentityUser user = new AppIdentityUser();
                user.UserName = userDto.UserName;
                user.Email = userDto.Email;
                IdentityResult result = await userManager.CreateAsync(user, userDto.Password);
                if(result.Succeeded)
                {
                    return Ok("Accounr Added");
                }
                return BadRequest(result.Errors);
            }
            return BadRequest(ModelState);
        }
  ```
9. Inject Identity service like
  ```C#
  builder.Services.AddIdentity<AppIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<InsDeptDbContextAPI>();
  ```

10. Create your *LoginUserDTO* class
11. Build login function like 
  ```C#
   public async Task<IActionResult> Login(LoginUserDTO userDto)
        { 
            if(ModelState.IsValid)
            {
                AppIdentityUser user = await userManager.FindByNameAsync(userDto.UserName);
                if(user!= null)
                {
                    bool isFound = await userManager.CheckPasswordAsync(user, userDto.Password);
                    if(isFound)
                    {
                        //claims Token
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                        claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

                        //get role
                        var roles = await userManager.GetRolesAsync(user);
                        foreach(var role in roles) 
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }

                        //credentials
                        SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
                        //it need the used algo and the key
                        SigningCredentials signingCredentials = new SigningCredentials(securityKey ,SecurityAlgorithms.HmacSha256);


                        //create token
                        //design token
                        JwtSecurityToken myToken = new JwtSecurityToken(
                            issuer: configuration["JWT:ValidIssuer"], // link of Web API 
                            audience: configuration["JWT:ValidAudience"], // default path for audience // consumer
                            claims: claims,
                            expires: DateTime.UtcNow.AddDays(1),
                            signingCredentials: signingCredentials
                            );
                        return Ok(new
                        {
                           token = new JwtSecurityTokenHandler().WriteToken(myToken),   
                           expiration = myToken.ValidTo
                        });
                    }
                }
                return Unauthorized(); // couldn't be found
                //check, create token
            }
            return Unauthorized();
        }
    
  ```
  And don't forget to add needed data to *appSetting.json* file

12. Add
  ```C#
  app.UseAuthentication();
  ```
  and 
  ```C#
  //Authorization with JWT token in Authentication check
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options=>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidateAudience =true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
            };
            });
  ```


## Windows Forms
## Steps
1. Create *Windows Forms App(.NET Framework)* project in visual studio
2. From *NuGet package manager*, install *Microsoft.AspNet.WebApi.Client*
3. Design your form
4. Do the business logic to link API with C#


## Web App
## Steps
1. Create *ASP .NET Web Application (.NET Framework)* project in visual studio => empty
2. From *NuGet package manager*, install *Jquery* libirary 
3. Create your Jquery ajax file like w3schools for example: https://www.w3schools.com/jquery/tryit.asp?filename=tryjquery_ajax_ajax 

4. Enable middleware to overcome CORS problem in the API project by adding  
  ```C#
    app.UseCors("myPolicy");
  ```
  and enable 
  ```C#
    app.UseStaticFiles();
  ```
then configure service method
  ```C#
  builder.Services.AddCors(CorsOptions =>
                {
                    CorsOptions.AddPolicy("myPolicy", CorsPolicyBuilder =>
                    {
                        CorsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    });
                }
            );
  ```
### Screenshots

![1](https://user-images.githubusercontent.com/61587804/227770744-c0dc3419-fcb5-40e5-9ad5-d7b5914f992d.png)

![2](https://user-images.githubusercontent.com/61587804/227770748-3474024a-6e56-45e4-9d6f-6bac840b2a2c.png)

![3](https://user-images.githubusercontent.com/61587804/227770753-5039e6e9-d5c2-4a36-a90f-db922bab64c8.png)

![4](https://user-images.githubusercontent.com/61587804/227770756-7c312ce6-3bf6-4702-a6e5-ea94100450ff.png)

![5](https://user-images.githubusercontent.com/61587804/227770757-eb4e1e8d-59a4-4a5e-b74c-6f3609fd7567.png)

![6](https://user-images.githubusercontent.com/61587804/227770762-61e549a3-6d5e-4762-8b20-fb1a3998adf8.png)

![7](https://user-images.githubusercontent.com/61587804/227770770-9285e17b-64a6-418c-adc7-8b973c04b4d2.png)

![8](https://user-images.githubusercontent.com/61587804/227770776-780940ce-127c-4e0c-aad1-fb905172137c.png)

![9](https://user-images.githubusercontent.com/61587804/227770778-34e83df5-78bc-4375-86a5-878cd9a8d955.png)

![10](https://user-images.githubusercontent.com/61587804/227770784-c0fafcc6-96e5-4528-b4cb-93f72cad9444.png)

![11](https://user-images.githubusercontent.com/61587804/227770787-c1d38095-5ab8-4e14-8b8c-46851487689e.png)

![12](https://user-images.githubusercontent.com/61587804/227770788-327091ee-d7f7-4d4a-9a1d-a875950ec48c.png)

![13](https://user-images.githubusercontent.com/61587804/227770790-b114f745-e654-40a8-ba10-11db8bb1ac90.png)

![14](https://user-images.githubusercontent.com/61587804/227770791-f2c4b38d-e506-410c-aa4b-3f0626f46687.png)

![15](https://user-images.githubusercontent.com/61587804/227770794-ef723c64-eeec-4524-9d90-2bc8cb6911bb.png)



<hr>
<hr>

## Web App Screenshots

![1](https://user-images.githubusercontent.com/61587804/227770878-4fc8837a-c27d-43e8-9764-009fdd0ce3a6.png)

![2](https://user-images.githubusercontent.com/61587804/227770879-7fc03489-afba-4eb0-9aca-f7e5467fbb4e.png)

![3](https://user-images.githubusercontent.com/61587804/227770880-0a7e7389-d0e9-46d2-8305-4b589a6e30e5.png)

![4](https://user-images.githubusercontent.com/61587804/227770884-c6c9ae3d-a895-4259-8a26-a52ffa8c381e.png)

![5](https://user-images.githubusercontent.com/61587804/227770886-a774c09c-fc2a-4ad1-90ed-cc16edc003be.png)

![6](https://user-images.githubusercontent.com/61587804/227770887-9c320592-a4a6-445a-a9dd-81ccfe1131e8.png)

![7](https://user-images.githubusercontent.com/61587804/227770889-34d8e201-a74b-464a-abce-3e68fa226699.png)
