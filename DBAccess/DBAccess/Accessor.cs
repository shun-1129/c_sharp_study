using DBAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DBAccess
{
    public class Accessor : DbContext
    {
        private string _ConnectionString = "";

        public Accessor(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public DbSet<m_sex> m_sexs {  get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_ConnectionString);
        }
    }
}