using FluentValidation;
using Think.Erp.Api.Domain.Commands;

namespace Think.Erp.Api.Validation
{
    public class UpdateEntityCommandValidation : AbstractValidator<UpdateEntityCommand>
    {
        public UpdateEntityCommandValidation()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("O campo nome é de preenchimento obrigatório.");
        }
    }

}