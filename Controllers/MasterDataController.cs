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
    public class MasterDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;

        public MasterDataController(IConfiguration configuration, SandenDBContext dBContext)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
        }

        [HttpGet]
        [Route("users")]
        public ActionResult users()
        {
            try
            {
                var data = from a in _dbSanden.Users 
                           where a.status =="Y"
                           select new
                           {
                               username=a.username,
                               fname=a.fname,
                               lname=a.lname,
                               companyId = a.companyId,
                               role=a.role,
                               status=a.status
                           };
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = true, Message = "Users not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpGet]
        [Route("customers")]
        public ActionResult customers()
        {
            try
            {
                var data = _dbSanden.Customers.Where(a=>a.customerStatus=="Y").ToList();
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = true, Message = "Customers not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpGet]
        [Route("roles")]
        public ActionResult roles()
        {
            try
            {
                var data = _dbSanden.AspNetRoles;
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Role not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }



    }
}
