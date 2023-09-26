using CommanderGraphQL.Interfaces;
using CommanderGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGraphQL.Data
{
    public class CommanderDBContext : DbContext, ICommanderDBContext
    {
        public DbSet<Platform> Platforms { get; set; }

        public CommanderDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}