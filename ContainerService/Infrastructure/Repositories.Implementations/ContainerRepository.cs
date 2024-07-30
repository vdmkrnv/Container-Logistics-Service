using Domain;
using Exceptions.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Interfaces;

namespace Infrastructure.Repositories.Implementations;

public class ContainerRepository(DbContext context) : IContainerRepository
{
    public async Task<Guid> AddAsync(Container container)
    {
        try
        {
            container.Id = Guid.NewGuid();
            await context.Set<Container>().AddAsync(container);
            await context.SaveChangesAsync();

            return container.Id;
        }
        catch
        {
            throw new InfrastructureException
            {
                Title = "Failed to add container",
                Message = $"Container type invalid",
                StatusCode = StatusCodes.Status400BadRequest
            };
        } 
    }
    
    public async Task<Container> UpdateAsync(Container container)
    {
        var con = await context.Set<Container>()
            .FirstOrDefaultAsync(x => x.Id == container.Id && !x.IsDeleted);
        if (con != null)
        {
            context.Entry(con).CurrentValues.SetValues(container);
            await context.SaveChangesAsync();
            return con;
        }

        throw new InfrastructureException
        {
            Title = "Container not found",
            Message = $"Container with id {container.Id} not found",
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public async Task<Container> DeleteAsync(Container container)
    {
        var con = await context.Set<Container>()
            .FirstOrDefaultAsync(x => x.Id == container.Id && !x.IsDeleted);
        if (con != null)
        {
            con.IsDeleted = true;
            await context.SaveChangesAsync();
            return con;
        }
        
        throw new InfrastructureException
        {
            Title = "Container not found",
            Message = $"Container with id {container.Id} not found",
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public async Task<Container> GetByIdAsync(Container container)
    {
        var con = await context.Set<Container>()
            .FirstOrDefaultAsync(x => x.Id == container.Id && !x.IsDeleted);
        if (con != null)
            return con;
        
        throw new InfrastructureException
        {
            Title = "Container not found",
            Message = $"Container with id {container.Id} not found",
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public async Task<Container> GetByIsoAsync(Container container)
    {
        var con = await context.Set<Container>()
            .FirstOrDefaultAsync(x => x.IsoNumber == container.IsoNumber && !x.IsDeleted);
        if (con != null)
            return con;
        
        throw new InfrastructureException
        {
            Title = "Container not found",
            Message = $"Container with iso number {container.IsoNumber} not found",
            StatusCode = StatusCodes.Status404NotFound
        };
    }
    
    public async Task<List<Container>> GetByTypeIdAsync(int page, int pageSize, int typeId)
    {
        return await context.Set<Container>()
            .Where(x => x.TypeId == typeId && !x.IsDeleted)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}