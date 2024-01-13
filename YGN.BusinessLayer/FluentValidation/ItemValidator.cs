using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.FluentValidation
{
    public class ItemValidator:AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(x => x.ItemCode).NotEmpty().WithMessage("Material Code field cannot be left blank.");
        }
    }
}
