using System.ComponentModel.DataAnnotations;

namespace sanden_api.Models
{
    public class QRCodeModel
    {
        [Display(Name = "Enter QRCode Text")]
        public string QRCodeText { get; set; }
    }
}
