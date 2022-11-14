using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandValidator:AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandCommandValidator()
        {
            //Brandler icin validasyonları burada tanımlıyoruz
            RuleFor(c=>c.Name).NotEmpty();
            RuleFor(c=>c.Name).MinimumLength(2);
            RuleFor(c=>c.Name).MaximumLength(50);

        }
    }
}
