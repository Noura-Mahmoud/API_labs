using Microsoft.EntityFrameworkCore;

namespace InsDeptAPI.Models
{
    public class InsDeptDbContextAPI: DbContext
    {
        public InsDeptDbContextAPI(DbContextOptions options):base(options)
        {

        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
