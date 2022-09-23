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
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace sanden_api.Helpers
{

    public class QrCodeGenerator2
    {

        public string genQrBase64(string QRCodeText)
        {
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(QRCodeText, QRCodeGenerator.ECCLevel.Q);
            QRCode QrCode = new QRCode(QrCodeInfo);
            Bitmap QrBitmap = QrCode.GetGraphic(60);
            byte[] BitmapArray = QrBitmap.BitmapToByteArray2();
            string QrUri = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitmapArray));
            return QrUri;
        }
    }

    //Extension method to convert Bitmap to Byte Array
    public static class BitmapExtension2
    {
        public static byte[] BitmapToByteArray2(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
