using DemoDotnetCore3.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDotnetCore3.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}