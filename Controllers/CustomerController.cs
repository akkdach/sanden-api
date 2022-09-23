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

namespace sanden_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;

        public CustomerController(IConfiguration configuration, SandenDBContext dBContext)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
        }

        [HttpGet]
        [Route("get/{customerId}")]
        public ActionResult Get(int customerId)
        {
            try
            {
                var data = from a in _dbSanden.Customers
                           where a.customerId == customerId
                           select a;
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

        [HttpGet]
        [Route("list")]
        public ActionResult list()
        {
            try
            {
                var data = from a in _dbSanden.Customers
                           select a;
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
        [Route("create")]
        public ActionResult Create(Customers _param)
        {
            try
            {
                Customers data = new Customers
                {
                    customerCodeWeb=_param.customerCodeWeb,
                    customerName = _param.customerName,
                    customerAddress = _param.customerAddress,
                    customerContactName = _param.customerContactName,
                    customerContactNumber = _param.customerContactNumber,
                    customerEmail = _param.customerEmail,
                    branchId = _param.branchId,
                    branchName = _param.branchName,
                    taxId = _param.taxId,
                    logo = "",
                    tradCode = _param.tradCode,
                    customerStatus = _param.customerStatus
                };
                _dbSanden.Customers.Add(data);
                _dbSanden.SaveChanges();
                return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });

            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpPut]
        [Route("update")]
        public ActionResult update([FromBody] Customers _param)
        {
            try
            {
                var data = _dbSanden.Customers.FirstOrDefault(a => a.customerId == _param.customerId);
                if (data != null)
                {

                    data.customerId = _param.customerId;
                    data.customerCodeWeb = _param.customerCodeWeb;
                    data.customerName = _param.customerName;
                    data.customerAddress = _param.customerAddress;
                    data.customerContactName = _param.customerContactName;
                    data.customerContactNumber = _param.customerContactNumber;
                    data.customerEmail = _param.customerEmail;
                    data.branchId = _param.branchId;
                    data.branchName = _param.branchName;
                    data.taxId = _param.taxId;
                    data.logo = "";
                    data.tradCode = _param.tradCode;
                    data.customerStatus = _param.customerStatus;
                    _dbSanden.SaveChanges();
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Customer not found.", DataResult = "" });
                }

            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpDelete]
        [Route("Delete/{customerId}")]
        public ActionResult Delete(int customerId)
        {
            try
            {
                var data = _dbSanden.Customers.FirstOrDefault(a => a.customerId == customerId);
                if (data != null)
                {
                    _dbSanden.Customers.Remove(data);
                    _dbSanden.SaveChanges();
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Customer not found.", DataResult = "" });
                }


            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

    }
}
