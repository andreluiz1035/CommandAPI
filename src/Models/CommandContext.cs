using Microsoft.EntityFrameworkCore;

namespace CommanndAPI.Models
{
    public class CommandContext:DbContext
    {
        public class CommandContext(DbContextOptions<CommandContext>options):base(options)
            {
    
            }
        public DbSet<Command> CommandItems {get;set}
    }
}


}