using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sanden_api.Models.Auth;
using sanden_api.Models.DBContext;
using Microsoft.Extensions.Configuration;
using sanden_api.Models;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using sanden_api.Helpers;
using BevProFSServiceAPI.Models.Entity;
using DinkToPdf.Contracts;
using DinkToPdf;
using System.Threading;

namespace sanden_api.Controllers.Report
{
    [ApiController]
    [Route("[controller]")]
    public class PrintQrCodeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        IConverter _converter;

        public PrintQrCodeController(IConfiguration configuration, SandenDBContext dBContext, IConverter converter)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
            _converter = converter;

        }

        [HttpPost]
        public IActionResult print(List<equipment_tntl> _param)
        {
            try
            {
                List<ResultQr> result = new List<ResultQr>();
                int i = 0;
                foreach (var item in _param)
                {
                    QrCodeGenerator2 qrCodeGenerator = new QrCodeGenerator2();
                    result.Add(new ResultQr
                    {
                        item = item.EQUIPMENT,
                        qrBase64 = qrCodeGenerator.genQrBase64(item.EQUIPMENT)
                    });
                    i++;
                }

                var globalSettings = new GlobalSettings
                {
                    ColorMode = DinkToPdf.ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10 },
                    DocumentTitle = "Print Qr Code"
                };
                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = PrintQrCodeHtml.GetHTMLString(result),
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 8,
                        Center = "Operation Visit", Line = false },

                    FooterSettings = { FontName = "Arial", FontSize = 8, Line = true, Right = "Page [page] of [toPage]" }
                };
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };

                var file = _converter.Convert(pdf);
                return File(file, "application/pdf");
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex.Message, DataResult = "" });
            }
        }

    }

}
