using CsvHelper;
using FluentValidation.Results;
using ImportFileCsv.App.Models;
using ImportFileCsv.App.Models.FluentValidator;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFileCsv.App.Infrastructure.Services.CsvHelper
{
    public class CsvHelperService : ICsvHelperService
    {
        private readonly BeneficiarioValidator _beneficiarioValidator = new BeneficiarioValidator();
        public async Task<List<string>> ImportFile(Stream file)
        {
            List<string> erros = new List<string>();
            List<BeneficiarioModel> listaBeneficiario = new List<BeneficiarioModel>();

            using ( StreamReader reader = new StreamReader(file, Encoding.GetEncoding("iso-8859-1")))

            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                if (csv.Read() && csv.ReadHeader())
                {
                    erros = ValidateHeaderFile(csv);
                    
                    if(!erros.Any())
                    {
                        listaBeneficiario = csv.GetRecords<BeneficiarioModel>().ToList();
                    }
                }
            }

            foreach (var row in listaBeneficiario)
            {
                erros = await ValidateRowFile(row);
            }

            return erros;
        }

        private async Task<List<string>> ValidateRowFile(BeneficiarioModel row)
        {
            ValidationResult results = await _beneficiarioValidator.ValidateAsync(row);
            return results.Errors.Select(l => l.ErrorMessage).ToList();
        }

        private List<string> ValidateHeaderFile(CsvReader csv)
        {
            List<string> mensagens = new List<string>();

            var objeto = new BeneficiarioModel();
            var props = objeto.GetType().GetProperties();

            if (!(csv.HeaderRecord.Length == 26))
            {
                mensagens.Add("Favor verificar as colunas necessárias para importação.");
            }

            for (int i = 0; i < props.Length; i++)
            {
                if (!csv.HeaderRecord.Contains(props[i].Name))
                {
                    mensagens.Add($"A Celula {i} está com nome {csv.HeaderRecord[i]}, favor corrigira para {props[i].Name}.");
                }
            }
            
            return mensagens;
        }
    }
}
