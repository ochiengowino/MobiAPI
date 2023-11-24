using Microsoft.EntityFrameworkCore;
using MobiAPI.Models;

namespace MobiAPI.Context
{
    public class ApiContext: DbContext 
    {

        public DbSet<Transactions>CustomerTransactions { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
