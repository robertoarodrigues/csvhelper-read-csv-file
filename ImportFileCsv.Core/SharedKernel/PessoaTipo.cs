using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFileCsv.Core.SharedKernel
{
    public enum PessoaTipo : byte
    {
        Titular = 0,
        [Display(Name = "Cônjuge")]
        Conjuge = 1,
        Pai = 2,
        [Display(Name = "Mãe")]
        Mae = 3,
        [Display(Name = "Filho (a)")]
        Filho = 4,
        [Display(Name = "Irmão (ã)")]
        Irmao = 5,
        [Display(Name = "Avô (ó)")]
        Avo = 6,
        [Display(Name = "Neto (a)")]
        Neto = 7,
        [Display(Name = "Tio (a)")]
        Tio = 8,
        [Display(Name = "Primo (a)")]
        Primo = 9,
        [Display(Name = "Sobrinho (a)")]
        Sobrinho = 10,
        [Display(Name = "Agregado (a)")]
        Agregado = 11,
    }
}
