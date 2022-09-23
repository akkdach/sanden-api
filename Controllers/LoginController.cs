using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sanden_api.Models.Auth;
using sanden_api.Models.DBContext;
using Microsoft.Extensions.Configuration;


namespace sanden_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger, IConfiguration configuration,SandenDBContext dBContext)
        {
            _logger = logger;
            _configuration = configuration;
            _dbSanden = dBContext;
        }

        [HttpPost]
        public ActionResult Login([FromBody] Login _param)
        {
            var data = _dbSanden.Users
                .FirstOrDefault(a=>
                a.username == _param.username && 
                a.password == _param.password);
            if(data == null)
            {
                return new JsonResult(new { IsSuccess = false, Message = "Username or password  is invalid.", DataResult = "" });
            }
            else
            {
                var userData = from a in _dbSanden.Users
                               join b in _dbSanden.Customers on a.companyId equals b.customerId
                               where a.companyId == data.companyId
                               select new LoginResult
                               {
                                   username = a.username,
                                   fname = a.fname,
                                   lname = a.lname,
                                   companyId = data.companyId,
                                   role = a.role,
                                   customerName=b.customerName,
                                   customerAddress=b.customerAddress,
                                   customerContactName=b.customerContactName,
                                   customerContactNumber=b.customerContactNumber,
                                   customerEmail=b.customerEmail,
                                   branchId=b.branchId,
                                   branchName=b.branchName,
                                   taxId=b.taxId,
                                   logo=b.logo,
                                   tradCode=b.tradCode,
                                   customerCodeWeb=b.customerCodeWeb
                               };
                
                if (userData == null)
                {
                    return new JsonResult(new { IsSuccess = false,  Message = "Please set customer data.", DataResult = userData });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = true,  Message = "Login Success", DataResult = userData.FirstOrDefault() });
                }
                
            }
        }
    }
}
