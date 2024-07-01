using Microsoft.EntityFrameworkCore;
using Practice2.Models;

namespace Practice2.Data
{
    public class CommanderContext : DbContext
    {
          public CommanderContext(DbContextOptions<CommanderContext> options) : base(options) 
          { 

          }

        public DbSet<Command> Commands { get; set; }
    }
}
