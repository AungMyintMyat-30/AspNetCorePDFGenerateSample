using AspNetCorePDFGenerateSample.Model;
using AspNetCorePDFGenerateSample.Utility;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace AspNetCorePDFGenerateSample.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IConverter _converter;

        public ActionController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpPost("pdfcreate")]
        public IActionResult PdfGenerate()
        {

            string pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\");
            if (!Directory.Exists(pathBuilt))
            {
                Directory.CreateDirectory(pathBuilt);
            }
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", "Sample.pdf");

            GlobalSettings globalSettings = new()
            {
                ColorMode = DinkToPdf.ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Sample",
                Out = path
            };

            ObjectSettings objectSettings = new()
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", "pdf-styles.css") },
            };
            HtmlToPdfDocument pdf = new()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            _converter.Convert(pdf);

            return Ok(new APIRequestModel()
            {
                Data = "PDF Generate Successfully",
                Links = "/Sample.pdf"
            });
        }
    }
}
