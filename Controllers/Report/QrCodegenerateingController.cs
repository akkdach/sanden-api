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

namespace sanden_api.Controllers.Report
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodegenerateingController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;

        public QrCodegenerateingController(IConfiguration configuration, SandenDBContext dBContext)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
        }

        [HttpPost]
        public IActionResult CreateQRCode2(List<equipment_tntl> _param)
        {
            List<ResultQr> result = new List<ResultQr>();
            int i = 0;
            foreach (var item in _param)
            {
                QrCodeGenerator2 qrCodeGenerator = new QrCodeGenerator2();
                result.Add(new ResultQr
                {
                    item = item.EQUIPMENT,
                    qrBase64 = qrCodeGenerator.genQrBase64("http://"+_configuration["BaseUrl:workServer"]+ "/report/history-services-detail/" + item.EQUIPMENT)
                });
                i++;
            }
            return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = result });
        }
    }

    //Extension method to convert Bitmap to Byte Array
    public static class BitmapExtension
    {
        
        public static byte[] BitmapToByteArray(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }

    public class ResultQr
    {
        public string item { get; set; }
        public string qrBase64 { get; set; }
    }   

}
