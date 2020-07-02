using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyWayGroceries.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Data.SqlClient;

namespace EasyWayGroceries.Controllers
{
    public class HomeController : Controller
    {
        //List<RegistrationModel> rm;
        private readonly EasyWayContext _dbContext;

        public HomeController(EasyWayContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult SaveRegistration(RegistrationModel model)
        {
            try
            {
                _dbContext.Add(model);
                _dbContext.SaveChanges();
                return Json("Success");
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            when ((ex.InnerException as SqlException)?.Number == 2627)
            {
                return Json("Duplicate");
            }
            catch (Exception ex) {
                return Json(ex);
            }
        }
        [HttpPost]
        public JsonResult Login(RegistrationModel EnteredData)
        {
                      
            var userExist = _dbContext.Registration.Where(u => u.EmailId == EnteredData.EmailId && u.Password == EnteredData.Password).FirstOrDefault();
            if (userExist != null)
            {
                return Json("Success");
            }
            else {
              return Json("Fail");
            }
          

           
        }
     
    }
}   