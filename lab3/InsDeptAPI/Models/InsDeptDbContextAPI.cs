using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InsDeptAPI.Models
{
    //public class InsDeptDbContextAPI: DbContext
    public class InsDeptDbContextAPI : IdentityDbContext<AppIdentityUser>
    {
        public InsDeptDbContextAPI(DbContextOptions options):base(options)
        {

        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
