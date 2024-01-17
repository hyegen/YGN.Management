using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.FluentValidation
{
    public class ClientValidator: AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Cari Adı boş bırakılamaz.");
            RuleFor(x => x.ClientSurname).NotEmpty().WithMessage("Cari soyadı boş bırakılamaz.");
        }
    }
}
