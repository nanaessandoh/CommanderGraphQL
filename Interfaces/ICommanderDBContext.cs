using CommanderGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGraphQL.Interfaces
{
    public interface ICommanderDBContext
    {
        DbSet<Platform> Platforms { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}