using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyWayGroceries.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EasyWayGroceries.Controllers
{
    public class DashboardController : Controller
    {
        private readonly EasyWayContext _dbContext;
        List<ProductsModel> ProductList = new List<ProductsModel>();

        public object HttpCacheability { get; private set; }

        public DashboardController(EasyWayContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult ShowProducts()
        {
            CartCount();
            //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
            ProductList = _dbContext.Products.ToList();
            for (int i = 0; i < ProductList.Count; i++)
            {
                CartDetails cartdetails = _dbContext.CartDetails.Where(u => u.ProductId == ProductList[i].ProductId && u.CartNo == UserDetails.CartNo).FirstOrDefault();
                if (cartdetails != null)
                {
                    ProductList[i].Quantity = cartdetails.Quantity.ToString();
                }
                else
                {
                    ProductList[i].Quantity = "Add";
                }
                ProductList[i].ImagePath = "~/ProductImages/" + ProductList[i].ProductId + ".jpg";
            }
            return View(ProductList);
        }
        public IActionResult ProductDetails(int ProductId,string mode)
        {
            if (mode == "Cart") { HttpContext.Session.SetString("LastSelected", ""); }
            else
            {
                HttpContext.Session.SetString("LastSelected", ProductId.ToString());
            }

             //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
            ProductsModel productDetails = _dbContext.Products.Where(u => u.ProductId == ProductId).FirstOrDefault();
            CartDetails cartdetails = _dbContext.CartDetails.Where(u => u.ProductId == ProductId && u.CartNo == UserDetails.CartNo).FirstOrDefault();
            if (cartdetails != null)
            {
                productDetails.Quantity = cartdetails.Quantity.ToString();
            }
            else
            {
                productDetails.Quantity = "Add";
            }
            productDetails.ImagePath = "~/ProductImages/" + productDetails.ProductId + ".jpg";
            ViewBag.Mode = mode;
            return View(productDetails);
        }
        [HttpPost]
        public JsonResult AddToCart(ProductsModel model)
        {
            //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
            ProductsModel productDetails = _dbContext.Products.Where(u => u.ProductId == model.ProductId).FirstOrDefault();
            CartDetails cartdetails = _dbContext.CartDetails.Where(u => u.ProductId == model.ProductId && u.CartNo == UserDetails.CartNo).FirstOrDefault();
            
            if (cartdetails != null)
            {
                if (double.Parse(model.Quantity) > 0)
                {
                    cartdetails.Quantity = double.Parse(model.Quantity);
                    _dbContext.Update(cartdetails);
                }
                else
                {
                    _dbContext.Remove(cartdetails);
                }
                _dbContext.SaveChanges();

            }
            else
            {
                if (double.Parse(model.Quantity) > 0)
                {
                    CartDetails selectedItem = new CartDetails();
                    selectedItem.CartNo = UserDetails.CartNo;
                    selectedItem.Quantity = double.Parse(model.Quantity);
                    selectedItem.ProductId = model.ProductId;
                    _dbContext.Add(selectedItem);
                    _dbContext.SaveChanges();
                }
            }

            CartCount();
            productDetails.Quantity = model.Quantity;
      
           // return RedirectToAction("ProblemDetails", productDetails);

          //  ProblemDetails(ProblemDetails, productDetails);
           return Json("Success");

        }

        public void CartCount() {
            //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
            HttpContext.Session.SetInt32("CartNo", _dbContext.CartDetails.Where(u => u.CartNo == UserDetails.CartNo).Count());
        }


    }
}