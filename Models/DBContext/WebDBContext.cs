using Microsoft.EntityFrameworkCore;
using BevProFSServiceAPI.Models.Entity;
using BevProFSServiceAPI.Models.Entity;
namespace sanden_api.Models.DBContext
{
    public class WebDBContext : DbContext
    {
        public DbSet<equipment_tntl> equipment_tntl { get; set; }
        public DbSet<WORK_ORDER_CUSTOMER_MAS> work_order_customers { get; set; }




        public DbSet<STORAGE_LOCATION> storage_location { get; set; }
        public DbSet<STORAGE_LOCATION_STOCK> storage_location_stock { get; set; }
        public DbSet<SPARE_PART_REQUEST> spare_part_request { get; set; }
        public DbSet<SPARE_PART_REQUEST_ITEM> spare_part_request_item { get; set; }
        public DbSet<WORK_CENTER> work_center { get; set; }
        public DbSet<WORK_LOG> work_log { get; set; }
        public DbSet<WORK_ORDER> work_order { get; set; }
        public DbSet<WorkOrderInspector> work_order_inspector { get; set; }
        public DbSet<WORK_ORDER_COMPONENT> work_order_component { get; set; }
        public DbSet<WORK_ORDER_CUSTOMER_MAS> work_order_customer_mas { get; set; }
        public DbSet<WORK_ORDER_HISTORY_SPAREPART> work_order_history_sparepart { get; set; }
        public DbSet<WORK_ORDER_HISTORYORDER_HEADER> work_order_historyorder_header { get; set; }
        public DbSet<WORK_ORDER_NOTIFICATION_HEADER> work_order_notification_header { get; set; }
        public DbSet<WORK_ORDER_OPERATION> work_order_operation { get; set; }
        public DbSet<WORK_ORDER_PM_CHECKING_LIST> work_order_pm_checking_list { get; set; }
        public DbSet<WORK_ORDER_TYPE> work_order_type { get; set; }
        public DbSet<MaterialCostMaster> MaterialCostMaster { get; set; }
        public DbSet<MATERIAL_MASTER> material_master { get; set; }
        public WebDBContext(DbContextOptions<WebDBContext> options):base(options){

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MaterialCostMaster>().HasKey(table => new {
                table.MATERIAL,
                table.TRADE_CODE
            });

            builder.Entity<ServiceCostMaster>().HasKey(table => new {
                table.COST_NO,
                table.TRADE_CODE,
                table.SERVICE_ZONE_CODE,
                table.ORDERTIME_END,
            });
        }
    }
}
