using System.ComponentModel.DataAnnotations;
using System;
namespace BevProFSServiceAPI.Models.Entity
{
	public class OI_SERVICE_TASK
	{
		[Key]
		public int? ID { get; set; }
		public int ORDER_INFORMATION_TO_WEB_ID {get;set;}
		public string REMARK { get;set; }
		public string K2_REMARK { get;set; }
		public string CONFIRM_REVIEW { get;set; }
		public string REVIEW_USER { get; set; }

	}

}
