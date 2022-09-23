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
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        private readonly WebDBContext _dbWeb;

        public CustomerController(IConfiguration configuration, SandenDBContext dBContext, WebDBContext ebWeb)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
            _dbWeb = ebWeb;
        }


        [HttpGet]
        [Route("select")]
        public ActionResult select(string customer)
        {
            try
            {
                var data = from a in _dbWeb.work_order_customers
                           group a by a.CUSTOMER into g
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
    }
}
