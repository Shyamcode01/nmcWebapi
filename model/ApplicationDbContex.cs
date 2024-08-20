using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace NmcWbapi.model
{
    public class ApplicationDbContex:DbContext
    {
        public ApplicationDbContex(DbContextOptions options):base(options)
        {
            
        }
      
        public DbSet<nmcStudent> nmcStudents { get; set; }

    }
}
