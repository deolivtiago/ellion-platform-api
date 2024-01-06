using Microsoft.EntityFrameworkCore;

namespace EllionPlatform.Data
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
