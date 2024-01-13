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
<<<<<<<<< Temporary merge branch 1
            RuleFor(x => x.ItemCode).NotEmpty().WithMessage("Material Name field cannot be left blank.");
            RuleFor(x => x.ItemCode).NotEmpty().WithMessage("Unit Price field cannot be left blank.");
=========
            RuleFor(x => x.ItemName).NotEmpty().WithMessage("Material Name field cannot be left blank.");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Unit Price field cannot be left blank.");
>>>>>>>>> Temporary merge branch 2
        }
    }
}
