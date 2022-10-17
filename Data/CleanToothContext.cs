

using Microsoft.EntityFrameworkCore;
using CleanTooth.Models;

namespace CleanTooth.Data
{
    public class CleanToothContext : DbContext
    {
        public CleanToothContext(DbContextOptions<CleanToothContext> options)
            : base(options)
        {
        }

        public DbSet<ToothPick> ToothPick { get; set; }
    }
}