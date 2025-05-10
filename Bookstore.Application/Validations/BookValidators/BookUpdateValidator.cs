using Bookstore.Application.DTOs.BookDTOs;
using FluentValidation;

namespace Bookstore.Application.Validations.NewFolder;

public class BookUpdateValidator : AbstractValidator<BookUpdateDTO>
{
    public BookUpdateValidator()
    {
        RuleFor(book => book.Name)
            .NotEmpty().WithMessage("Kitab adı boş ola bilməz.");
        RuleFor(book => book.Amount)
            .NotEmpty().WithMessage("Kitab adı boş ola bilməz.")
            .GreaterThan(0).WithMessage("Kitab miqdari 0 dan kicik ola bilmez");
    }
}
