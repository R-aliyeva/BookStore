using Bookstore.Application.DTOs.CustomerDTOs;
using FluentValidation;

namespace Bookstore.Application.Validations.CustomerValidators;

public class CustomerVlaidator : AbstractValidator<CustomerCreateDTO>
{
    public CustomerVlaidator()
    {
        RuleFor(customer => customer.Name)
            .NotEmpty().WithMessage("Müştəri adı boş ola bilməz.");
        RuleFor(customer => customer.Address)
            .NotEmpty().WithMessage("Müştəri adresi boş ola bilməz.");
    }
}
