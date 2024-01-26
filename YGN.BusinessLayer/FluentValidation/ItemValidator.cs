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
            RuleFor(x => x.ItemCode).NotEmpty().WithMessage("Malzeme kodu boş bırakılamaz.");
            RuleFor(x => x.ItemName).NotEmpty().WithMessage("Malzeme adı boş bırakılamaz.");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Birim fiyat boş bırakılamaz.");
        }
    }
}
