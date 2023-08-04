using Microsoft.EntityFrameworkCore;
using SimpleAPP.Models;

namespace SimpleAPP
{
    public class SimpleAPPDbContext :DbContext
    {
        
        public SimpleAPPDbContext(DbContextOptions<SimpleAPPDbContext> options):base(options)
        {
            
        }
        DbSet<Student>Studnets { get; set; }
    }
}
