using Microsoft.EntityFrameworkCore;

namespace CSharpEF.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
        : base(options) 
        {

        }
    }
}
