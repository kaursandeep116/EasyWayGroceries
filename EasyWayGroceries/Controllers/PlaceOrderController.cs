using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyWayGroceries.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyWayGroceries.Controllers
{
    public class PlaceOrderController : Controller
    {
        private readonly EasyWayContext _dbContext;
        List<CartDetails> CartList = new List<CartDetails>();
        public PlaceOrderController(EasyWayContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult ShowCart()
        {
            double totalCost = 0;
            double serviceTax = 0;
            double deliveryFee = 4.99;
            List<ProductsModel> ProductList = new List<ProductsModel>();
            //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
            CartList = _dbContext.CartDetails.ToList();
            for (int i = 0; i < CartList.Count; i++)
            {
                ProductsModel Product = _dbContext.Products.Where(u => u.ProductId == CartList[i].ProductId).FirstOrDefault();
                Product.Quantity = CartList[i].Quantity.ToString();
                Product.TotalPrice = Product.Price * CartList[i].Quantity;
                Product.ImagePath = "~/ProductImages/" + Product.ProductId + ".jpg";
                ProductList.Add(Product);
                totalCost = totalCost + Product.TotalPrice;
            }
            serviceTax = 0.07 * totalCost;
            ViewBag.ItemTotal = String.Format("{0:0.00}", totalCost);
            ViewBag.Cost = String.Format("{0:0.00}", totalCost + deliveryFee + serviceTax);
            ViewBag.ServiceTax = String.Format("{0:0.00}", serviceTax);
            ViewBag.DeliveryFee = String.Format("{0:0.00}", deliveryFee);
            return View(ProductList);
        }

        public JsonResult RemoveItem(ProductsModel model)
        {
            //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            RegistrationModel UserDetails = new RegistrationModel();
            UserDetails.CartNo = 30002;
           // ProductsModel productDetails = _dbContext.Products.Where(u => u.ProductId == model.ProductId).FirstOrDefault();
            CartDetails cartdetails = _dbContext.CartDetails.Where(u => u.ProductId == model.ProductId && u.CartNo == UserDetails.CartNo).FirstOrDefault();
            _dbContext.Remove(cartdetails);
            _dbContext.SaveChanges();
            return Json("Success");
        }
    }
}