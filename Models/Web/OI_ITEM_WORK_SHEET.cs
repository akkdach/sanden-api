using System;
using System.ComponentModel.DataAnnotations;

namespace BevProFSServiceAPI.Models.Entity
{
    public class OI_ITEM_WORK_SHEET
    {
		[Key]
		public int ID { get; set; }
		public int ORDER_INFORMATION_TO_WEB_ID { get; set; }
		public int? LINE_NO { get; set; }
		public string TYPE { get; set; }
		public string NO { get; set; }
		public string DESCRIPTION { get; set; }
		public string ACTIVITY_TYPE { get; set; }
		public string LOCATION_CODE { get; set; }
		public DateTime? ACTUAL_START_DATE { get; set; }
		public string ACTUAL_START_TIME { get; set; }
		public DateTime? ACTUAL_FINISH_DATE { get; set; }
		public string ACTUAL_FINISH_TIME { get; set; }

		public int? ACTUAL_WORK { get; set; }
		public int? QUANTITY { get; set; }
		public int? QUANTITY_SHIPPED { get;set; }
		public int? UNIT_PRICE_EXCL_VAT { get; set; }
		public string MOVEMENT_TYPE { get; set; }
		public string BILL_TO_CUSTOMER_NO { get; set; }
		public DateTime? POSTING_DATE { get; set; }
		public string WORK_TYPE_CODE { get; set; }
		public string UNIT_OF_MEASURE_CODE { get; set; }
		public string BIN_CODE { get; set; }
		public string WORK_TYPE_DESCRIPTION { get; set; }
		public string WORK_CENTER { get; set; }
		public string ACTIVITY_PRICE { get; set; }
		public string REASON_CODE { get; set; }
    }
}
