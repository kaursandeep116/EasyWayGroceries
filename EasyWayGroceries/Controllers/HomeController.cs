using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyWayGroceries.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Data.SqlClient;
using System.Web;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
                int count = _dbContext.Registration.Count();
                model.CustomerId = 10000 + count;
                model.IsVerified = "No";
                model.ActivationCode = System.Guid.NewGuid().ToString();
                _dbContext.Add(model);
                _dbContext.SaveChanges();
                SendActivationEmail(model,"register");
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

            RegistrationModel userExist = _dbContext.Registration.Where(u => u.EmailId == EnteredData.EmailId && u.Password == EnteredData.Password).FirstOrDefault();
            if (userExist != null)
            {
                if (userExist.IsVerified == "Yes")
                {
                    HttpContext.Session.SetObjectAsJson("UserDetails", userExist);
                  //  HttpContext.Session.SetString("CustId", userExist.CustomerId.ToString());

                    return Json("Success");
                }
                else {
                    return Json("Not Verified");
                }
            }
            else {
              return Json("Fail");
            }          
        }
        public void SendActivationEmail(RegistrationModel user, string mode)
        {
            using (MailMessage mm = new MailMessage("developer.sandeep116@gmail.com", user.EmailId))
            {
                
                EmailBody(mm, mode,user);
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("developer.sandeep116@gmail.com", "simrankaurks");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
            }
        }
        public IActionResult Activation()
        {
               string activationCode = HttpContext.Request.Query["id"];
               RegistrationModel userActivation = _dbContext.Registration.Where(p => p.ActivationCode == activationCode).FirstOrDefault();
            if (userActivation != null)
            {
                userActivation.IsVerified = "Yes";
                userActivation.ActivationCode = System.Guid.NewGuid().ToString();
                _dbContext.Update(userActivation);
                _dbContext.SaveChanges();
                ViewData["Message"] = "Thank you very much for verifying your Email.";
                return View();
            }
            else {
                ViewData["Message"] = "Link Already Used!";
                return View();
            }
                
        }

        [HttpPost]

        public IActionResult ResetLink(RegistrationModel model)
        {

                var userExist = _dbContext.Registration.Where(u => u.EmailId == model.EmailId).FirstOrDefault();
                if (userExist != null)
                {
                _dbContext.Update(userExist);
                _dbContext.SaveChanges();
                SendActivationEmail(userExist,"reset");
                return Json("Success");
                }
                else
                {
                    return Json("Fail");
                }
            
        }
        public IActionResult PasswordReset()
        {
            string activationCode = HttpContext.Request.Query["id"];
            RegistrationModel userActivation = _dbContext.Registration.Where(p => p.ActivationCode == activationCode).FirstOrDefault();
            if (userActivation != null)
            {
                ViewData["Message"] = "valid";
                return View();
            }
            else {
                ViewData["Message"] = "used";
                return View();
            }
               
            
        }
        [HttpPost]
        public IActionResult PasswordReset(RegistrationModel model)
        {
            RegistrationModel user = _dbContext.Registration.Where(p => p.ActivationCode == model.ActivationCode).FirstOrDefault();
            if (user != null)
            {
                user.ActivationCode = System.Guid.NewGuid().ToString();
                user.Password = model.Password;
                _dbContext.Update(user);
                _dbContext.SaveChanges();
                return Json("Success");
            }
            else
            {
                return Json("Fail");
            }

        }
        public void EmailBody(MailMessage mm, string mode, RegistrationModel user) {
            if (mode == "register")
            {
                mm.Subject = "Account Activation";
                string body = "Hello " + user.UserName + ",";
                body += "<p>Thank you for Registring with EasyWay Groceries. We are here to deliver your Groceries.</p>";
                body += "<p>Please click the following link to activate your account</p>";
                body += "<p><a href = '" + string.Format("https://localhost:44345/Home/Activation?id=" + user.ActivationCode) + "'>Click here to activate your account.</a> <p>";
                body += "Thanks";
                mm.Body = body;
                mm.IsBodyHtml = true;
            }
            else if (mode == "reset")

            {
                mm.Subject = "Password Reset";
                string body = "Hello " + user.UserName + ",";
                body += "<p>Please click the following link to reset your password</p>";
                body += "<p><a href = '" + string.Format("https://localhost:44345/Home/PasswordReset?id=" + user.ActivationCode) + "'>Click here to Reset your password.</a> <p>";
                body += "Thanks";
                mm.Body = body;
                mm.IsBodyHtml = true;
            }
        }

    }

}
  