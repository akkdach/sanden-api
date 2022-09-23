using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class work_order_visit_insepctor
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(12)]
        public string ORDERID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACTUAL_FINISH_DATE { get; set; }

        [MaxLength(8)]
        public string ACTUAL_FINISH_TIME { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACTUAL_START_DATE { get; set; }

        [MaxLength(8)]
        public string ACTUAL_START_TIME { get; set; }

        [MaxLength(18)]
        public string ASSEMBLY { get; set; }

        [MaxLength(12)]
        public string ASSET_NO { get; set; }

        [MaxLength(1)]
        public int? CCP_FLAG { get; set; }

        [MaxLength(12)]
        public string CHANGED_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CHANGE_DATE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CHECKIN_DATETIME { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CHECKOUT_DATETIME { get; set; }

        [MaxLength(1)]
        public int? CLOSE_EVAL1 { get; set; }

        [MaxLength(1)]
        public int? CLOSE_EVAL2 { get; set; }

        [MaxLength(1)]
        public int? CLOSE_EVAL3 { get; set; }

        [MaxLength(1)]
        public int? CLOSE_EVAL4 { get; set; }

        [MaxLength(1)]
        public int? CLOSE_EVAL5 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL { get; set; }

        [MaxLength(255)]
        public string CLOSE_SIGNATURE_URL { get; set; }

        [MaxLength(1)]
        public int? CLOSE_TYPE { get; set; }

        [MaxLength(500)]
        public string COMMENT { get; set; }

        [MaxLength(4)]
        public string COMP_CODE { get; set; }

        [MaxLength(10)]
        public string COSTCENTER { get; set; }

        [MaxLength(4)]
        public string CO_AREA { get; set; }

        [MaxLength(10)]
        public string CUSTOMER { get; set; }

        [MaxLength(2)]
        public string DISTR_CHAN { get; set; }

        [MaxLength(2)]
        public string DIVISION { get; set; }

        [MaxLength(12)]
        public string ENTERED_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ENTER_DATE { get; set; }

        [MaxLength(18)]
        public string EQUIPMENT { get; set; }

        [MaxLength(20)]
        public string EQ_MODEL { get; set; }

        [MaxLength(4)]
        public string LOC_COMP_CODE { get; set; }

        [MaxLength(4)]
        public string LOC_CO_AREA { get; set; }

        [MaxLength(4)]
        public string MAINTPLANT { get; set; }

        [MaxLength(18)]
        public string MATERIAL { get; set; }

        public int? MILEAGE { get; set; }

        [MaxLength(8)]
        public string MN_WK_CTR { get; set; }

        [MaxLength(12)]
        public string NOTIF_NO { get; set; }

        [MaxLength(10)]
        public string OBJECTTYPE { get; set; }

        [MaxLength(4)]
        public string ORDER_TYPE { get; set; }

        [MaxLength(3)]
        public string PLANGROUP { get; set; }

        [MaxLength(4)]
        public string PLANPLANT { get; set; }

        [MaxLength(4)]
        public string PLANT { get; set; }

        [MaxLength(3)]
        public string PMACTTYPE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PRODUCTION_FINISH_DATE { get; set; }

        [MaxLength(8)]
        public string PRODUCTION_FINISH_TIME { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PRODUCTION_START_DATE { get; set; }

        [MaxLength(8)]
        public string PRODUCTION_START_TIME { get; set; }

        [MaxLength(10)]
        public string PROFIT_CTR { get; set; }

        [MaxLength(24)]
        public string PROJ_DEF { get; set; }

        [DataType(DataType.Date)]
        public DateTime? REFDATE { get; set; }

        [MaxLength(10)]
        public string RESPCCTR { get; set; }

        [MaxLength(10)]
        public string ROUTING_NO { get; set; }

        [MaxLength(4)]
        public string SALESORG { get; set; }

        [MaxLength(10)]
        public string SALES_ORD { get; set; }

        [MaxLength(18)]
        public string SERIALNO { get; set; }

        [MaxLength(3)]
        public int SERVICE_TIME { get; set; }

        [MaxLength(40)]
        public string SHORT_TEXT { get; set; }

        [MaxLength(1)]
        public int? SLA_FLAG { get; set; }

        [MaxLength(4)]
        public string SUB_NUMBER { get; set; }

        [MaxLength(40)]
        public string SYS_STATUS { get; set; }

        [MaxLength(40)]
        public string USERSTATUS { get; set; }

        [MaxLength(24)]
        public string WBS_ELEM { get; set; }

        [MaxLength(1)]
        public int? WEB_STATUS { get; set; }

        [MaxLength(500)]
        public string COMMENT2 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL2 { get; set; }

        [MaxLength(10)]
        public string CLOSE_FAILD_INSTALL_CAUSE { get; set; }

        [MaxLength(10)]
        public string CLOSE_FAILD_REMOVE_CAUSE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ASSIGNED_DATE { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL3 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL4 { get; set; }

        [MaxLength(500)]
        public string ERROR_MESSAGE { get; set; }

        [MaxLength(35)]
        public string BILL_NO { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PRODUCTION_FINISH_DATE1 { get; set; }

        [MaxLength(8)]
        public string PRODUCTION_FINISH_TIME1 { get; set; }

        [MaxLength(40)]
        public string AUARTTEXT { get; set; }

        [MaxLength(30)]
        public string ILATX { get; set; }

        [MaxLength(40)]
        public string EQKTX { get; set; }

        [DataType(DataType.Date)]
        public DateTime? INBDT { get; set; }

        [MaxLength(18)]
        public string ZZMATNR { get; set; }

        [MaxLength(18)]
        public string ZZEQUIPMENT { get; set; }

        [MaxLength(10)]
        public string CDE_CODE { get; set; }

        [MaxLength(30)]
        public string ZZIMEI_CON_DEVICE { get; set; }

        [MaxLength(30)]
        public string ZZSIM_MOBILE_NUMBER { get; set; }

        [MaxLength(30)]
        public string ZZSIM_ICCID { get; set; }

        [MaxLength(30)]
        public string ZZSIM_SERVICE_PROVIDER { get; set; }

        [MaxLength(30)]
        public string ZZCON_DEVICE_TYPE { get; set; }

        [MaxLength(4)]
        public string USIS_REASON { get; set; }

        [MaxLength(40)]
        public string USIS_REASON_TEXT { get; set; }

        [MaxLength(40)]
        public string ZZMOBILE_STATUS { get; set; }

        [MaxLength(40)]
        public string ZZCUS_NAME { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ZZ_CK_IN_ORD_DT { get; set; }

        [MaxLength(8)]
        public string ZZ_CK_IN_ORD_TM { get; set; }

        [MaxLength(10)]
        public int? ZZ_CK_IN_ORD_ML { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ZZ_CK_OUT_ORD_DT { get; set; }

        [MaxLength(8)]
        public string ZZ_CK_OUT_ORD_TM { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ZZ_CK_IN_DP_DT { get; set; }

        [MaxLength(8)]
        public string ZZ_CK_IN_DP_TM { get; set; }

        [MaxLength(10)]
        public int? ZZ_CK_IN_DP_ML { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ZZ_CK_OUT_DP_DT { get; set; }

        [MaxLength(8)]
        public string ZZ_CK_OUT_DP_TM { get; set; }

        [MaxLength(1)]
        public int? ZZ_CK_OUT_DP_ML { get; set; }

        [MaxLength(10)]
        public string ZZCDE_CODE { get; set; }

        [MaxLength(10)]
        public string SUCCESS_VERRIFY { get; set; }

        [MaxLength(10)]
        public string UNSUCCESS_SETUP { get; set; }

        [MaxLength(255)]
        public string CLOSE_SIGNATURE_URL2 { get; set; }

        public decimal? CHECK_IN_LATITUDE { get; set; }

        public decimal? CHECK_IN_LONGITUDE { get; set; }

        public decimal? CHECK_NAV_LATITUDE { get; set; }

        public decimal? CHECK_NAV_LONGITUDE { get; set; }

        [MaxLength(500)]
        public string COMMENT3 { get; set; }

        [MaxLength(255)]
        public string CHECK_IN_IMAGE1 { get; set; }

        [MaxLength(255)]
        public string CHECK_IN_IMAGE2 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL5 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL6 { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL7 { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CHECK_IN_DATE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CLOSE_SIGNATURE_DATE { get; set; }

        [MaxLength(255)]
        public string EMPLOYEE_ID { get; set; }

        [MaxLength(255)]
        public string CLOSE_IMAGE_URL8 { get; set; }

        [MaxLength(1)]
        public string APP_STATUS { get; set; }

        [MaxLength(50)]
        public string AAP_BY { get; set; }

        [DataType(DataType.Date)]
        public DateTime? APP_DATE { get; set; }

        [MaxLength(255)]
        public string IMAGE_001 { get; set; }

        [MaxLength(255)]
        public string IMAGE_002 { get; set; }

        [MaxLength(255)]
        public string IMAGE_003 { get; set; }

        [MaxLength(255)]
        public string IMAGE_004 { get; set; }

        [MaxLength(255)]
        public string IMAGE_005 { get; set; }

        [MaxLength(255)]
        public string IMAGE_006 { get; set; }

        [MaxLength(255)]
        public string IMAGE_007 { get; set; }

        [MaxLength(255)]
        public string IMAGE_008 { get; set; }

        [MaxLength(255)]
        public string IMAGE_009 { get; set; }

        [MaxLength(1)]
        public string TRAVEL_CHARGE { get; set; }

        [MaxLength(255)]
        public string IMAGE_010 { get; set; }

        [MaxLength(255)]
        public string IMAGE_011 { get; set; }

        [MaxLength(255)]
        public string IMAGE_012 { get; set; }

        [MaxLength(1)]
        public string APPROVE { get; set; }

        [MaxLength(40)]
        public string APPROVE_NAME { get; set; }

        [MaxLength(40)]
        public DateTime? APPROVE_DATE { get; set; }

        [MaxLength(1)]
        public string Warranty { get; set; }

        [MaxLength(1)]
        public string REFURBISH_STATUS { get; set; }

        [MaxLength(1)]
        public string REFURBISH_STATION { get; set; }

        [MaxLength(5)]
        public string MAINTEN_ACTIVITY_TYPE { get; set; }

        public string VanSupervisor { get; set; }

        public string OperationType { get; set; }

        [MaxLength(255)]
        public string LeadrSignatureUrl { get; set; }

        [MaxLength(255)]
        public string LeaderName { get; set; }

        [MaxLength(255)]
        public string WorkerSignatureUrl { get; set; }

        [MaxLength(255)]
        public string CustomerSignatureUrl { get; set; }

        [NotMapped]
        public WORK_ORDER_CUSTOMER_MAS CUSTOMER_MAS { get; set; }
        [NotMapped]
        public WORK_ORDER_TYPE WORK_ORDER_TYPE { get; set; }
    }
}
