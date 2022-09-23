using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sanden_api.Models.Auth;
using sanden_api.Models.DBContext;
using Microsoft.Extensions.Configuration;
using sanden_api.Models;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using sanden_api.Helpers;
using BevProFSServiceAPI.Models.Entity;

namespace sanden_api.Controllers.Report
{
    [ApiController]
    [Route("[controller]")]
    public class WorkOrderhistoryController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        private readonly WebDBContext _webDb;

        public WorkOrderhistoryController(IConfiguration configuration, SandenDBContext dBContext,WebDBContext webDB)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
            _webDb = webDB;
        }

        [HttpGet]
        [Route("line/{equipment}")]
        public ActionResult line(string equipment)
        {
            try
            {

                var resultLine = from w in _webDb.work_order
                               join t in _webDb.work_order_type on w.ORDER_TYPE equals t.ORDER_TYPE
                               where w.EQUIPMENT == equipment
                             select new {
                                orderId = w.ORDERID,
                                workDate = w.ACTUAL_FINISH_DATE,
                                workTime = w.ACTUAL_FINISH_TIME,
                                sortText = w.SHORT_TEXT,
                                orderType = t.SHORT_TEXT,
                                wkCtr = w.MN_WK_CTR,
                                status = w.APP_STATUS
                             };
                resultLine = resultLine.OrderByDescending(a=>a.workDate);
                return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = resultLine });
            }
            catch(Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }
            
        }

        [HttpGet]
        [Route("orderlist/{traeCode}/{startDate}/{endDate}")]
        public ActionResult orderlist(string traeCode,DateTime startDate, DateTime endDate)
        {
            try
            {

                var resultLine = from w in _webDb.work_order
                                 join t in _webDb.work_order_type on w.ORDER_TYPE equals t.ORDER_TYPE
                                 join c in _webDb.work_order_customer_mas on w.ORDERID equals c.ORDERID
                                 where c.TRADENAME == traeCode && w.ASSIGNED_DATE >= startDate && w.ASSIGNED_DATE <= endDate
                                 select new
                                 {
                                     equipment=w.EQUIPMENT,
                                     orderId = w.ORDERID,
                                     workDate = w.ACTUAL_FINISH_DATE,
                                     workTime = w.SERVICE_TIME,
                                     sortText = w.SHORT_TEXT,
                                     orderType = t.SHORT_TEXT,
                                     wkCtr = w.MN_WK_CTR,
                                     status = w.APP_STATUS,
                                     custNameCo = c.NAME_CO,
                                     custAddr = c.BUILDING+' '+c.STREET+' '+c.CITY2+' '+c.CITY1,

                                 };
                resultLine = resultLine.OrderByDescending(a => a.workDate);
                return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = resultLine.Take(30000) });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }


        [HttpGet]
        [Route("head/{equipment}")]
        public ActionResult head(string equipment)
        {
            try
            {
                var resultHead = from a in _webDb.equipment_tntl
                                 where a.EQUIPMENT == equipment
                                 select new
                                 {
                                     equipment = a.EQUIPMENT,
                                     currenT_CUSTOMER = a.CURRENT_CUSTOMER,
                                     location = a.LOCATION,
                                     district = a.DISTRICT,
                                     citY1 = a.CITY1
                                 };
                return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = resultHead.FirstOrDefault() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }


    }




}
