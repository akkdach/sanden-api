using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sanden_api.Models.Auth;
using sanden_api.Models.DBContext;
using Microsoft.Extensions.Configuration;
using BevProFSServiceAPI.Models.Entity;

namespace sanden_api.Controllers.Web
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        private readonly WebDBContext _dbWeb;

        public EquipmentController(IConfiguration configuration, SandenDBContext dBContext, WebDBContext ebWeb)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
            _dbWeb = ebWeb;
        }

        [HttpGet]
        [Route("customer/select")]
        public ActionResult listcustomer()
        {
            try
            {
                var data = from a in _dbWeb.equipment_tntl
                           group a by a.CURRENT_CUSTOMER into g
                           select new
                           {
                              customer = g.Key
                           };
                           
                          
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Data not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true, Message = "Please set customer data.", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }
        }

        [HttpPost]
        [Route("list")]
        public ActionResult list(searchEqForm searchEqForm)
        {
            try
            {
                var data = from a in _dbWeb.equipment_tntl
                           select new
                           {
                               equipment = a.EQUIPMENT,
                               currenT_CUSTOMER = a.CURRENT_CUSTOMER,
                               district = a.DISTRICT,
                               citY1 = a.CITY1
                           };
                if(!string.IsNullOrEmpty(searchEqForm.customer))
                {
                    data = data.Where(a => a.currenT_CUSTOMER == searchEqForm.customer);
                }

                if (!string.IsNullOrEmpty(searchEqForm.equipment))
                {
                    data = data.Where(a => a.equipment == searchEqForm.equipment);
                }
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Data not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true, Message = "Please set customer data.", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }
    }

    public class searchEqForm
    {
        public string customer { get; set; }
        public string equipment { get; set; }
    }
}
