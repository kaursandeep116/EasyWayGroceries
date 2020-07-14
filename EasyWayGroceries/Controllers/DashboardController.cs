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

        public DashboardController(EasyWayContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Welcome() {
          //RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            ProductList = _dbContext.Products.ToList();
            for(int i=0;i < ProductList.Count;i++) {
                ProductList[i].ImagePath="~/ProductImages/"+ProductList[i].ProductId+".jpg";
            }
            return View(ProductList);
        }
   
        public IActionResult ProductDetails(ProductsModel model)
        {
          
            return View(model);

        }
        [HttpPost]
        public JsonResult AddToCart(ProductsModel model)
        {
            ProductsModel productDetails = _dbContext.Products.Where(u => u.ProductId == model.ProductId).FirstOrDefault();
            AddItem additem = new AddItem();
            additem.ProductId = productDetails.ProductId;
            additem.UnitPrice = productDetails.Price;
            additem.Quantity = float.Parse(model.Quantity);
            additem.TotalPrice = additem.Quantity * additem.UnitPrice;
            RegistrationModel UserDetails = HttpContext.Session.GetObjectFromJson<RegistrationModel>("UserDetails");
            List<CustomerOrderModel> customerOrderList = _dbContext.CustomerOrders.ToList();
            if (customerOrderList == null) {
                CustomerOrderModel customerOrder = new CustomerOrderModel();
                customerOrder.CustomerId = UserDetails.CustomerId;
                customerOrder.OrderId = 20000;
                customerOrder.status = "Cart";
                _dbContext.Add(customerOrder);
                _dbContext.SaveChanges();
            }
            else if()
            {
                CustomerOrderModel customerOrder = new CustomerOrderModel();
                customerOrder.CustomerId = UserDetails.CustomerId;
                customerOrder.OrderId = 20000;
                customerOrder.status = "Cart";
                _dbContext.Add(customerOrder);
                _dbContext.SaveChanges();
            }
            return Json("Success");

        }

        //public JsonResult AddToCart(ProductsModel model) {
        //    Console.WriteLine("Helloooo::" + model.Quantity + " " );
        //    return Json("");
        //}
    }
}