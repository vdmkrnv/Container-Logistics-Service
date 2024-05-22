using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using Services.Services.Contracts.Container;

namespace Infrastructure.Repositories.Implementations;

public class ContainerRepository : Repository<Container>, IContainerRepository
{
    public ContainerRepository(DbContext dbContext) : base(dbContext) { }

    public async Task UpdateEngagedStatus(UpdatingContainerDto updatingContainerDto)
    {
        throw new NotImplementedException();
    }
}