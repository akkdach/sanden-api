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
using sanden_api.Helpers;
using Microsoft.EntityFrameworkCore;
using BevProFSServiceAPI.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;


namespace sanden_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        private readonly WebDBContext _webDbContext;
        private readonly IUriService uriService;


        public MaterialController(IConfiguration configuration, SandenDBContext dBContext, WebDBContext webDbContext)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
            _webDbContext = webDbContext;
        }


        [HttpGet]
        [Route("list/{tradeCode}")]
        public ActionResult list(string tradeCode)
        {
            try
            {
                var pagedData = from m in _webDbContext.MaterialCostMaster
                                join s in _webDbContext.storage_location_stock on m.MATERIAL equals s.MATERIAL
                                where m.TRADE_CODE == tradeCode && !string.IsNullOrEmpty(m.MATERIAL)
                                select new
                                {
                                    material = m.MATERIAL,
                                    maT_DESC = m.MAT_DESC,
                                    uniT_COST = m.UNIT_COST,
                                    UNIT_PRICE = m.UNIT_PRICE,
                                    qty = s.ZNEW
                                };
                List<MaterialResult> resultData = pagedData.GroupBy(g => g.material).Select(a => new MaterialResult
                {
                    material = a.Max(x=>x.material),
                    maT_DESC = a.Max(x=>x.maT_DESC),
                    uniT_COST = a.Max(a=>a.uniT_COST),
                    uniT_PRICE = a.Max(a=>a.UNIT_PRICE),
                    qty = a.Sum(a => a.qty).ToString()
                }).ToList();

                //var dataResult = _webDbContext.storage_location_stock.GroupBy(g=>g.MATERIAL).Select(new {)
                //int i = 0;
                //foreach (var row in pagedData)
                //{
                //    pagedData[i].qty = _webDbContext.storage_location_stock.f
                //    i++;
                //}
                return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = resultData });
            }
            catch (Exception ex)
            {

                return new JsonResult(new { IsSuccess = false, Message = ex.Message, DataResult = "" });
            }
        }
    }

    public class MaterialCostMasterSearch
    {
        public string Trade_Code { get; set; }
    }

    public class MaterialResult {
        public string material { get; set; }
        public string maT_DESC { get; set; }
        public double uniT_COST { get; set; }
        public double uniT_PRICE { get; set; }
        public string qty { get; set; }
    }
}
