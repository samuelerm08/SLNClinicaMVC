using Microsoft.EntityFrameworkCore;

namespace Clinica.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbClinicaContext(DbContextOptions<DbClinicaContext> options) : base (options) { }        
    }
}
