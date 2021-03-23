using FluentValidation;

namespace ImportFileCsv.App.Models.FluentValidator
{
    public class BeneficiarioValidator : AbstractValidator<BeneficiarioModel>
    {
        public BeneficiarioValidator()
        {
            RuleFor(x => x.Nome).NotNull().WithMessage("Nome é obrigatório.");
            RuleFor(x => x.Cpf).NotNull().Length(13).WithMessage("CPF é obrigatório.");
            RuleFor(x => x.DataNascimento).NotNull().WithMessage("Data Nascimento é obrigatório.");
            RuleFor(x => x.NomeMae).NotNull().WithMessage("Nome da Mãe é obrigatório.");
            RuleFor(x => x.EstadoCivil).NotNull().WithMessage("Estado Civil é obrigatório.");
            RuleFor(x => x.Documento).NotNull().WithMessage("Documento é obrigatório.");
            RuleFor(x => x.DocumentoTipo).NotNull().WithMessage("Documento Tipo é obrigatório.");
            RuleFor(x => x.OrgaoEmissor).NotNull().WithMessage("Orgão Emissor é obrigatório.");
            RuleFor(x => x.Email).NotNull().WithMessage("Email é obrigatório.");
        }
    }
}
