using FluentValidation;
using Services.Models.Request.Container;

namespace Services.Validation.Container;

public class GetContainerByIdValidator : AbstractValidator<GetContainerByIdModel>
{
    public GetContainerByIdValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotEqual(Guid.Empty);
    }
}