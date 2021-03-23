using ImportFileCsv.App.Infrastructure.Services.CsvHelper;
using ImportFileCsv.App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ImportFileCsv.App.Controllers
{
    public class ImportFileController : Controller
    {
        private readonly ICsvHelperService _csvHelper;

        public ImportFileController(ICsvHelperService csvHelper)
        {
            _csvHelper = csvHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("importfile")]
        [HttpPost]
        public async Task<IActionResult> ImportFile(FileModel fileModel)
        {
            if (fileModel == null)
                return Ok();

            var result = await _csvHelper.ImportFile(fileModel.File.OpenReadStream());

            return Ok();
        }

    }
}
