using System.ComponentModel.DataAnnotations;
using System;
namespace BevProFSServiceAPI.Models.Entity
{
	public class OI_QI
	{
		[Key]
		public int ID { get; set; }
		public int ORDER_INFORMATION_TO_WEB_ID { get; set; }
		public string? Work_Order { get; set; }
		public string? TASTE_CHECK { get; set; }
		public decimal? TASTE_PASS { get; set; }
		public decimal? TASTE_SAT { get; set; }
		public decimal? BRIX_RATIO_CHECK { get; set; }
		public decimal? BRIX_RATIO_PASS { get; set; }
		public decimal? BRIX_RATIO_SAT { get; set; }
		public decimal? TEMP_CHECK { get; set; }
		public decimal? TEMP_PASS { get; set; }
		public decimal? TEMP_SAT { get; set; }
		public decimal? OV_CARBO_CHECK { get; set; }
		public decimal? OV_CARBO_Pass { get; set; }
		public decimal? OV_CARBO_Sat { get; set; }
		public decimal? AGE_CHECK { get; set; }
		public decimal? AGE_PASS { get; set; }
		public decimal? AGE_SAT { get; set; }
		public decimal? QI_RESULT { get; set; }
		public string? DEFECT_1 { get; set; }
		public string? DEFECT_2 { get; set; }
		public string? DEFECT_3 { get; set; }
		public string? DEFECT_4 { get; set; }
		public string? DEFECT_5 { get; set; }
		public string? DEFECT_6 { get; set; }
		public string? DEFECT_7 { get; set; }
		public string? DEFECT_8 { get; set; }
		public string? DEFECT_9 { get; set; }
		public string? DEFECT_10 { get; set; }
	}
}
