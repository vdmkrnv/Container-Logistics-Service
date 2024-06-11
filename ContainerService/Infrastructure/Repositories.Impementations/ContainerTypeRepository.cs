using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Impementations;

/// <summary>
/// Репозиторий для типов контейнеров.
/// </summary>
public class ContainerTypeRepository : Repository<ContainerType>, IContainerTypeRepository
{
    public ContainerTypeRepository(DbContext dbContext) : base(dbContext) { }
}