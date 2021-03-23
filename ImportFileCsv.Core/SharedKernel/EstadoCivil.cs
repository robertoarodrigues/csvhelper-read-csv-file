using System.ComponentModel.DataAnnotations;

namespace ImportFileCsv.Core.SharedKernel
{
    public enum EstadoCivil : byte
    {
        [Display(Name = "Casado (a)")]
        Casado = 0,
        [Display(Name = "Divorciado (a)")]
        Divorciado = 1,
        [Display(Name = "Solteiro (a)")]
        Solteiro = 2,
        [Display(Name = "Viúvo (a)")]
        Viuvo = 3,
        [Display(Name = "Outros")]
        Outros = 4
    }
}
