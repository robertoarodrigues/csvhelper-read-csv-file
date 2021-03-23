using ImportFileCsv.App.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ImportFileCsv.App.Infrastructure.Services.CsvHelper
{
    public interface ICsvHelperService
    {
        Task<List<string>> ImportFile(Stream file);
    }
}
