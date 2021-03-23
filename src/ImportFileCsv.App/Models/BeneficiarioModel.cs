using ImportFileCsv.Core.SharedKernel;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;

namespace ImportFileCsv.App.Models
{
    public class BeneficiarioModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public Sexo? Sexo { get; set; } = default;
        public EstadoCivil? EstadoCivil { get; set; } = default;
        public string Naturalidade { get; set; }
        public string Documento { get; set; }
        public DocumentoTipo DocumentoTipo { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string OrgaoEmissor { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string PisPasep { get; set; }
        public string ProfissaoFormacao { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public string CartaoNacionalSaude { get; set; }
        public string DN { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string OperadoraAnterior { get; set; }
        public string TempoPlanoAnterior { get; set; }
        public string AcomodacaoPlanoAnterior { get; set; }
        public PessoaTipo Parentesco { get; set; }
        public string Email { get; set; }
    }

    public class FileModel
    {
        [DisplayName("Selecione Arquivo .csv")]
        public IFormFile File { get; set; }
    }
}
