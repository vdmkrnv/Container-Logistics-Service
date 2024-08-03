using AutoMapper;
using Domain;
using Exceptions.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Services.Models.Request.Container;
using Services.Models.Response.Container;
using Services.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services.Implementations;

public class ContainerService(
    IContainerRepository containerRepository,
    IMapper mapper,
    IValidator<CreateContainerModel> createContainerValidator,
    IValidator<UpdateContainerModel> updateContainerValidator,
    IValidator<DeleteContainerModel> deleteContainerValidator,
    IValidator<GetContainerByIdModel> getContainerByIdValidator,
    IValidator<GetContainerByIsoModel> getContainerByIsoValidator,
    IValidator<GetContainersByTypeIdModel> getContainersByTypeIdValidator) : IContainerService
{
    public async Task<Guid> Add(CreateContainerModel model)
    {
        var validationResult = await createContainerValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };

        var id = await containerRepository.AddAsync(mapper.Map<Container>(model));
        
        return id;
    }

    public async Task<ContainerModel> Update(UpdateContainerModel model)
    {
        var validationResult = await updateContainerValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var container = await containerRepository.UpdateAsync(mapper.Map<Container>(model));
        var result = mapper.Map<ContainerModel>(container);
        
        return result;
    }

    public async Task<ContainerModel> Delete(DeleteContainerModel model)
    {
        var validationResult = await deleteContainerValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var container = await containerRepository.DeleteAsync(mapper.Map<Container>(model));
        var result = mapper.Map<ContainerModel>(container);
        
        return result;
    }

    public async Task<ContainerModel> GetById(GetContainerByIdModel model)
    {
        var validationResult = await getContainerByIdValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var container = await containerRepository.GetByIdAsync(mapper.Map<Container>(model));
        var result = mapper.Map<ContainerModel>(container);
        
        return result;
    }

    public async Task<ContainerModel> GetByIso(GetContainerByIsoModel model)
    {
        var validationResult = await getContainerByIsoValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var container = await containerRepository.GetByIsoAsync(mapper.Map<Container>(model));
        var result = mapper.Map<ContainerModel>(container);
        
        return result;
    }

    public async Task<List<ContainerModel>> GetByTypeId(GetContainersByTypeIdModel model)
    {
        var validationResult = await getContainersByTypeIdValidator.ValidateAsync(instance: model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var containers = await containerRepository
            .GetByTypeIdAsync(
                page: model.Page, 
                pageSize: model.PageSize, 
                typeId: model.TypeId);
        var result = mapper.Map<List<ContainerModel>>(source: containers);
        
        return result;
    }
}