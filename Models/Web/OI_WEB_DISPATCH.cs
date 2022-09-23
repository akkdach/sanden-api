using System.ComponentModel.DataAnnotations;

namespace BevProFSServiceAPI.Models.Entity
{
    public class OI_WEB_DISPATCH
    {
        [Key]
        public int Id { get; set; }
        public int ORDER_INFORMATION_TO_WEB_ID { get; set; }
        public string IMAGE { get;set; }

    }
}
