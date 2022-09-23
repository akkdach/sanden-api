using Microsoft.Extensions.Configuration;

namespace sanden_api.Helpers
{
    public static class ImageManagement
    {
        static IConfiguration _configuration;
        static ImageManagement()
        {
        }
        
        public static string ConvertDisplayImageUrl(string url_image)
        {
            if (string.IsNullOrEmpty(url_image))
            {
                return "";
            }
            var brake_url = url_image.Split("/");

            var domain = brake_url[2];
            var file_name = brake_url[4];

            string URL_Result = "";

            if (domain == "10.1.1.76")
            {
                URL_Result = $"{_configuration["AppSettings:PicPath"]}/api/DisplayImage/ShowDispatch/{file_name}";
            }
            else
            {
                URL_Result = url_image;
            }
            return URL_Result;
        }
    }
}
