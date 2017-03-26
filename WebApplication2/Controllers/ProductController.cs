using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using WebApplication2.Models.ViewModels;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Product List";
            List<ProductViewModel> productList = new List<ProductViewModel>();
            XElement root = XElement.Load(Server.MapPath("/DataFiles/ProductData.xml"));

            if (root != null)
            {
                IEnumerable<XElement> products = from el in root.Elements("Product")
                                              select el;

                ProductViewModel vm = null;
                foreach (var item in products)
                {
                    vm = new ProductViewModel();
                    vm.ProductId = Convert.ToInt32(item.Element("ProductId").Value.ToString());
                    vm.ProductName = item.Element("ProductName").Value;
                    vm.ProductCost = Decimal.Parse(item.Element("ProductCost").Value.ToString());
                    vm.ProductImage = item.Element("ProductImage").Value;
                    
                    productList.Add(vm);
                }
            }
            return View(productList);
        }

        public ActionResult ProductDetails(int Id)
        {
            if (Id == 0)
                return null;

            XElement root = XElement.Load(Server.MapPath("/DataFiles/ProductData.xml"));

            IEnumerable<XElement> productElements = from element in root.Elements("Product")
                                      where (string)element.Attribute("Id") == Id.ToString()
                                      select element;

            //XElement productElement = productElements.FirstOrDefault();

            ProductViewModel vm = null;
            foreach (var item in productElements)
            {
                vm = new ProductViewModel();
                vm.ProductId = Convert.ToInt32(item.Element("ProductId").Value.ToString());
                vm.ProductName = item.Element("ProductName").Value;
                vm.ProductCost = Decimal.Parse(item.Element("ProductCost").Value.ToString());
                vm.ProductImage = item.Element("ProductImage").Value;

              
            }


            return View(vm);
        }
	}
}