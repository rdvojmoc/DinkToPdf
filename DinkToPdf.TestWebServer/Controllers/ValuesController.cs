using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DinkToPdf.TestWebServer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IConverter _converter;

        public ValuesController(IConverter converter)
        {
            _converter = converter;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    PaperSize = PaperKind.A3,
                    Orientation = Orientation.Landscape,
                },

                Objects = {
                    new ObjectSettings()
                    {
                        Page = "http://google.com/",
                    },
                     new ObjectSettings()
                    {
                        Page = "https://github.com/",
                         
                    }
                }
            };
           
            byte[] pdf = _converter.Convert(doc);


            return new FileContentResult(pdf, "application/pdf");
        }
    }
}
