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
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SandenDBContext _dbSanden;

        public UserController(IConfiguration configuration, SandenDBContext dBContext)
        {
            _configuration = configuration;
            _dbSanden = dBContext;
        }

        [HttpGet]
        [Route("get/{username}")]
        public ActionResult Get(string username)
        {
            try
            {

                var data = from a in _dbSanden.Users 
                           where a.username == username
                           select new
                           {
                               username=a.username,
                               fname=a.fname,
                               lname=a.lname,
                               companyId = a.companyId,
                               role=a.role,
                               status=a.status,
                               createBy=a.createBy,
                               createAt=a.createAt
                           };
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess =true, Message = "Data not found.", DataResult = "" });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = false, Message = "success", DataResult = data });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpGet]
        [Route("get")]
        public ActionResult List()
        {
            try
            {
                var data = from a in _dbSanden.Users
                           join b in _dbSanden.Customers on a.companyId equals b.customerId
                           select new
                           {
                               username = a.username,
                               fname = a.fname,
                               lname = a.lname,
                               companyId = a.companyId,
                               role = a.role,
                               status = a.status,
                               password="",
                               customerName = b.customerName
                           };
                if (data == null)
                {
                    return new JsonResult(new { IsSuccess = true, Message = "Data not found.", DataResult = "" });
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

        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] Users _param)
        {
            try
            {

                Users data = new Users
                {
                    username=_param.username,
                    password= _param.password,
                    fname=_param.fname,
                    lname=_param.lname,
                    companyId=_param.companyId,
                    role=_param.role,
                    status=_param.status,
                    createBy=_param.createBy,
                    createAt=DateTime.Now
                };
                _dbSanden.Users.Add(data);
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
        public ActionResult update( Users _param)
        {
            try
            {
                if (_param.username == "admin")
                {
                    return new JsonResult(new { IsSuccess = false, Message = "Con not edit admin", DataResult = "" });

                }
                var data = _dbSanden.Users.FirstOrDefault(a => a.username == _param.username);
                if (data != null)
                {
                    data.username = _param.username;
                    data.password = _param.password;
                    data.fname = _param.fname;
                    data.lname = _param.lname;
                    data.companyId = _param.companyId;
                    data.role = _param.role;
                    data.status = _param.status;
                    data.createBy = _param.createBy;
                    data.createAt = DateTime.Now;
                    _dbSanden.SaveChanges();
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = false, Message = "User not found.", DataResult = "" });
                }

            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }

        [HttpDelete]
        [Route("Delete/{username}")]
        public ActionResult Delete(string username)
        {
            try
            {
                var data = _dbSanden.Users.FirstOrDefault(a => a.username == username);
                if (data != null)
                {
                    _dbSanden.Users.Remove(data);
                    _dbSanden.SaveChanges();
                    return new JsonResult(new { IsSuccess = true, Message = "success", DataResult = data });
                }
                else
                {
                    return new JsonResult(new { IsSuccess = false, Message = "User not found.", DataResult = "" });
                }


            }
            catch (Exception ex)
            {
                return new JsonResult(new { IsSuccess = false, Message = ex, DataResult = "" });
            }

        }



    }
}
