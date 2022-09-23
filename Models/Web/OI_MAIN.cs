using System.ComponentModel.DataAnnotations;
using System;
namespace BevProFSServiceAPI.Models.Entity
{
	public class OI_MAIN
	{
		[Key]
		public int ID { get; set; } 
		public string WORK_ORDER { get; set; }
		public string APPROVE { get; set; }
		public string NOTIFICATION { get; set; }
		public string NAV_STATUS { get; set; }
		public string MOBILE_STATUS { get; set; }
		public string REASON_CODE { get; set; }
		public string REASON_DESCRIPTION { get; set; }
		public string MAINTENANCE_ACTIVITY_TYPE1 { get; set; }
		public string SERVICE_ITEM_NO { get; set; }
		public string SERVICE_ITEM_NO_MOBILE { get; set; }
		public string BILLING_NO { get; set; }
		public string PRODUCTION_FINISH_DATE_SLA1 { get; set; }
		public string SERVICE_ITEM_GROUP_CODE { get; set; }
		public string ACTUAL_ASSET_MODEL { get; set; }
        public int? SERVICE_AMOUNT { get; set; }
        public string SERVICE_ORDER_TYPE { get; set; }
		public string MAINTENANCE_ACTIVITY_TYPE2 { get; set; }
		public DateTime? CHECK_IN_ORDER_DATE { get;set; }
		public string CHECK_IN_ORDER_TIME { get; set; }
        public int? CHECK_IN_ORDER_MILE { get; set; }
        public DateTime? CHECK_OUT_ORDER_DATE { get; set; }
		public string CHECK_OUT_ORDER_TIME { get; set; }
		public string CUSTOMER_NAME_SIGN_OFF { get; set; }
		public DateTime? PRODUCTION_FINISH_DATE_SLA2 { get; set; }
		public string OBJECT_TYPE_TO_MOBILE { get; set; }
		public string FUALT_AREA_CODE { get; set; }
		public string DAMAGE_CODE_DESC { get; set; }
		public string FAULT_REASON_CODE_DESC { get; set; }
		public string RESOLUTION_CODE_DESC { get; set; }
		public string PROBLEM_CODE_DESC { get; set; }
		public string MAINTENANCE_ACTIVITY_DESC { get; set; }
		public DateTime? ACTUAL_ORDER_FINISH_DATETIME { get; set; }
		public string IMEI_CONNECTIVITY_DEVICE { get; set; }
		public string SIM_MOBILE_NUMBER { get; set; }
		public string SIM_ICCID { get; set; }
		public string SIM_SERVICE_PROVIDER { get; set; }
		public string CONNECTIVITY_DEVICE_TYPE { get; set; }
		public string CDE_CODE { get; set; }

		//public OI_MAIN()
  //      {
		//	SERVICE_AMOUNT = 0;
		//	CHECK_IN_ORDER_MILE = 0;
		//}
	}

	public class VV_OI_MAIN
	{
		public int ID { get; set; }
		public string? WORK_ORDER { get; set; }
		public string? APPROVE { get; set; }
		public string? NOTIFICATION { get; set; }
		public string? NAV_STATUS { get; set; }
		public string? MOBILE_STATUS { get; set; }
		public string? REASON_CODE { get; set; }
		public string? REASON_DESCRIPTION { get; set; }
		public string? MAINTENANCE_ACTIVITY_TYPE1 { get; set; }
		public string? SERVICE_ITEM_NO { get; set; }
		public string? SERVICE_ITEM_NO_MOBILE { get; set; }
		public string? BILLING_NO { get; set; }
		public string? PRODUCTION_FINISH_DATE_SLA1 { get; set; }
		public string? SERVICE_ITEM_GROUP_CODE { get; set; }
		public string? ACTUAL_ASSET_MODEL { get; set; }
		public int SERVICE_AMOUNT { get; set; }
		public string? SERVICE_ORDER_TYPE { get; set; }
		public string? MAINTENANCE_ACTIVITY_TYPE2 { get; set; }
		public DateTime? CHECK_IN_ORDER_DATE { get; set; }
		public string? CHECK_IN_ORDER_TIME { get; set; }
		public int CHECK_IN_ORDER_MILE { get; set; }
		public DateTime? CHECK_OUT_ORDER_DATE { get; set; }
		public string? CHECK_OUT_ORDER_TIME { get; set; }
		public string? CUSTOMER_NAME_SIGN_OFF { get; set; }
		public DateTime? PRODUCTION_FINISH_DATE_SLA2 { get; set; }
		public string? OBJECT_TYPE_TO_MOBILE { get; set; }
		public string? FUALT_AREA_CODE { get; set; }
		public string? DAMAGE_CODE_DESC { get; set; }
		public string? FAULT_REASON_CODE_DESC { get; set; }
		public string? RESOLUTION_CODE_DESC { get; set; }
		public string? PROBLEM_CODE_DESC { get; set; }
		public string? MAINTENANCE_ACTIVITY_DESC { get; set; }
		public DateTime? ACTUAL_ORDER_FINISH_DATETIME { get; set; }
		public string? IMEI_CONNECTIVITY_DEVICE { get; set; }
		public string? SIM_MOBILE_NUMBER { get; set; }
		public string? SIM_ICCID { get; set; }
		public string? SIM_SERVICE_PROVIDER { get; set; }
		public string? CONNECTIVITY_DEVICE_TYPE { get; set; }
		public string? CDE_CODE { get; set; }

	}
}
