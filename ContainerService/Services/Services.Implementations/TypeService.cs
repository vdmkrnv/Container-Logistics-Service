using AutoMapper;
using Exceptions.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Services.Models.Request.Type;
using Services.Models.Response.Type;
using Services.Repositories.Interfaces;
using Services.Services.Interfaces;
using Type = Domain.Type;

namespace Services.Services.Implementations;

public class TypeService(
    ITypeRepository typeRepository,
    IMapper mapper,
    IValidator<CreateTypeModel> createTypeValidator,
    IValidator<UpdateTypeModel> updateTypeValidator,
    IValidator<DeleteTypeModel> deleteTypeValidator,
    IValidator<GetTypeByIdModel> getTypeByIdValidator,
    IValidator<GetAllTypesModel> getAllTypesValidator) : ITypeService
{
    public async Task<int> Add(CreateTypeModel model)
    {
        var validationResult = await createTypeValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var id = await typeRepository.AddAsync(mapper.Map<Type>(model));
        
        return id;
    }

    public async Task<TypeModel> Update(UpdateTypeModel model)
    {
        var validationResult = await updateTypeValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var type = await typeRepository.UpdateAsync(mapper.Map<Type>(model));
        var result = mapper.Map<TypeModel>(type);
        
        return result;
    }

    public async Task<TypeModel> Delete(DeleteTypeModel model)
    {
        var validationResult = await deleteTypeValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var type = await typeRepository.DeleteAsync(mapper.Map<Type>(model));
        var result = mapper.Map<TypeModel>(type);
        
        return result;
    }

    public async Task<TypeModel> GetById(GetTypeByIdModel model)
    {
        var validationResult = await getTypeByIdValidator.ValidateAsync(model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var type = await typeRepository.GetByIdAsync(mapper.Map<Type>(model));
        var result = mapper.Map<TypeModel>(type);
        
        return result;
    }

    public async Task<List<TypeModel>> GetAll(GetAllTypesModel model)
    {
        var validationResult = await getAllTypesValidator.ValidateAsync(instance: model);
        if (!validationResult.IsValid)
            throw new ServiceException
            {   
                Title = "Model invalid",
                Message = "Model validation failed",
                StatusCode = StatusCodes.Status400BadRequest
            };
        
        var types = await typeRepository.GetAllAsync(
            page: model.Page, 
            pageSize: model.PageSize);
        var result = mapper.Map<List<TypeModel>>(source: types);
        
        return result;
    }
}