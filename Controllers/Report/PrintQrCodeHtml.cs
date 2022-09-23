using System.Text;
using sanden_api.Models;
using System;
using System.Collections.Generic;

namespace sanden_api.Controllers.Report
{
    public class PrintQrCodeHtml
    {

        public static string GetHTMLString(List<ResultQr> qr)
        {
            var sb = new StringBuilder();
            sb.Append(@" <html>");
            sb.Append(@"<head>");
            sb.Append(@"</head>");
            sb.Append(@"<body>");
            sb.Append(@"<table  width='100%' style='border:0px solid;padding:0px;' cellspacing='0' cellpadding='0'>");
            foreach(var item in qr)
            {
                sb.AppendFormat(@"<div><img src='{0}' ></div>",item.qrBase64);
            }
            sb.Append("</table>");

            sb.Append(@"</body>
                        </html>");
            return sb.ToString();
        }

    }
}
