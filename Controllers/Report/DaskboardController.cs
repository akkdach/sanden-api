using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using sanden_api.Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using sanden_api.Helpers;
namespace sanden_api.Controllers.Report
{

        [ApiController]
        [Route("[controller]")]
        public class DaskboardController : ControllerBase
        {
            private readonly IConfiguration _configuration;
            private readonly SandenDBContext _dbSanden;
            private readonly WebDBContext _webDb;

            public DaskboardController(IConfiguration configuration, SandenDBContext dBContext, WebDBContext webDB)
            {
                _configuration = configuration;
                _dbSanden = dBContext;
                _webDb = webDB;
            }

            [HttpGet]
            [Route("recenOrder/{TRADENAME}")]
            public ActionResult RecenOrder(string TRADENAME)
            {
                try
                {
                    var result = from a in _webDb.work_order
                                 join b in _webDb.work_order_customer_mas on a.ORDERID equals b.ORDERID
                                 where b.TRADENAME == TRADENAME
                                 select new
                                 {
                                     a.ORDERID,
                                     a.EQUIPMENT,
                                     a.ENTER_DATE,
                                     a.SHORT_TEXT,
                                     b.NAME_CO,
                                     b.CUST_NAME,
                                     a.ZZMOBILE_STATUS,
                                     imagesFontShop = ImageManagement.ConvertDisplayImageUrl(a.IMAGE_001)
                                 };


                    result = result.OrderByDescending(a => a.ENTER_DATE).Take(10);
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = result });
                }
                catch (Exception ex)
                {
                    return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
                }

            }


        [HttpGet]
        [Route("orderStatus/{TRADENAME}")]
        public ActionResult OrderStatus(string TRADENAME)
        {
            try
            {
                var result = from a in _webDb.work_order
                             join b in _webDb.work_order_customer_mas on a.ORDERID equals b.ORDERID
                             where b.TRADENAME == TRADENAME && a.ORDER_TYPE != null
                             group b by a.ORDER_TYPE into g
                             select new
                             {
                                 title = g.Key,
                                 value = g.Count(),
                                 icon= "iconsminds-arrow-refresh"
                             };


                result = result.OrderByDescending(a => a.value).Take(4);
                return new JsonResult(  result );
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }



        [HttpGet]
        [Route("orderNoti/{TRADENAME}")]
        public ActionResult OrderNiti(string TRADENAME)
        {
            try
            {
                var result = from a in _webDb.work_order
                             join b in _webDb.work_order_customer_mas on a.ORDERID equals b.ORDERID
                             join c in _webDb.work_order_historyorder_header on a.ORDERID equals c.ORDERID
                             where b.TRADENAME == TRADENAME && a.ORDER_TYPE != null
                             
                             select new
                             {
                                 a.ORDERID,
                                 c.NOTIF_ACT_TEXT,
                                 c.NOTIF_DATE
                             };


                result = result.OrderByDescending(a => a.NOTIF_DATE).Take(100);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpGet]
        [Route("orderChart/{TRADENAME}")]
        public ActionResult OrderChart(string TRADENAME)
        {
            try
            {
                var mon1 = _webDb.work_order
                    .Where(a => a.ENTER_DATE.Value.Month == 1)
                    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon2 = _webDb.work_order
                    .Where(a => a.ENTER_DATE.Value.Month == 2)
                    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon3 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 3)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon4 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 4)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon5 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 5)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon6 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 6)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon7 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 7)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon8 = _webDb.work_order
.Where(a => a.ENTER_DATE.Value.Month == 8)
.Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon9 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 9)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon10 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 10)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon11 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 11)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon12 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 12)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                int[] result = { mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10, mon11, mon12 };
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }


        [HttpGet]
        [Route("orderChart2/{TRADENAME}")]
        public ActionResult OrderChart2(string TRADENAME)
        {
            try
            {
                var mon1 = _webDb.work_order
                    .Where(a => a.ENTER_DATE.Value.Month == 1)
                    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon2 = _webDb.work_order
                    .Where(a => a.ENTER_DATE.Value.Month == 2)
                    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon3 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 3)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon4 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 4)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon5 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 5)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon6 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 6)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();


                var mon7 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 7)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon8 = _webDb.work_order
.Where(a => a.ENTER_DATE.Value.Month == 8)
.Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                var mon9 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 9)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon10 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 10)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon11 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 11)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();
                var mon12 = _webDb.work_order
    .Where(a => a.ENTER_DATE.Value.Month == 12)
    .Where(a => a.ENTER_DATE.Value.Year == DateTime.Now.Year).Count();

                int[] result = { mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10, mon11, mon12 };
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

    }

}
