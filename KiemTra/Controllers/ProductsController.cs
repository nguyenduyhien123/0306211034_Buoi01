using KiemTra.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiemTra.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Name = "OPPO Reno10 5G",
                Description = "6.7 inch, Full HD+, 128GB",
                Price = 250,
                Stock = 30,
                Image = "oppo-reno10-blue-thumbnew-600x600.jpg"

            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy Z Fold5 5G",
                Description = "Chính 7.6\" & Phụ 6.2\", 256GB",
                Price = 400,
                Stock = 0,
                Image = "samsung-galaxy-z-fold5.jpg"
            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy A14 4G",
                Description = "6.6\" Full HD+ 6GB",
                Price = 324,
                Stock = 32,
                Image = "samsung-galaxy-a14-(8).jpg"
            });
            products.Add(new Product()
            {
                Name = "iPhone 14 Promax",
                Description = "6.7\" Super Retina XDR, 128GB",
                Price = 700,
                Stock = 25,
                Image = "iphone-14-pro-max-tim-thumb-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "iPhone 14 Pro",
                Description = "6.1\" Super Retina XDR, 128GB",
                Price = 600,
                Stock = 0,
                Image = "iphone-14-pro-(54).jpg"
            });
            products.Add(new Product()
            {
                Name = "Xiaomi Redmi 12",
                Description = "6.79\" Full HD+",
                Price = 370,
                Stock = 196,
                Image = "xiaomi-redmi-12-4gb-(2).jpg"
            });
            products.Add(new Product()
            {
                Name = "OPPO Find N2 Flip 5G",
                Description = "Chính 6.8\" & Phụ 3.26\", Full HD+",
                Price = 1000,
                Stock = 23,
                Image = "oppo-n2-flip-den-thumb-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "vivo Y36",
                Description = "6.64\", Full HD+, 128GB",
                Price = 420,
                Stock = 565,
                Image = "vivo-y36-xanh-thumbnew-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy A24",
                Description = "6.5\", Full HD+, 6GB",
                Price = 380,
                Stock = 343,
                Image = "vivo-y36-xanh-thumbnew-600x600.jpg"
            });
            double sumPrice = 0;
            double sumStock = 0;
            foreach (var item in products)
            {
                sumPrice += item.Price * item.Stock;
                sumStock += item.Stock;
            }
            ViewBag.sumPrice = sumPrice; ViewBag.sumStock = sumStock;
            return View(products);
        }
        public IActionResult Grid()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Name = "OPPO Reno10 5G",
                Description = "6.7 inch, Full HD+, 128GB",
                Price = 250,
                Stock = 30,
                Image = "oppo-reno10-blue-thumbnew-600x600.jpg"

            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy Z Fold5 5G",
                Description = "Chính 7.6\" & Phụ 6.2\", 256GB",
                Price = 400,
                Stock = 0,
                Image = "samsung-galaxy-z-fold5.jpg"
            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy A14 4G",
                Description = "6.6\" Full HD+ 6GB",
                Price = 324,
                Stock = 32,
                Image = "samsung-galaxy-a14-(8).jpg"
            });
            products.Add(new Product()
            {
                Name = "iPhone 14 Promax",
                Description = "6.7\" Super Retina XDR, 128GB",
                Price = 700,
                Stock = 25,
                Image = "iphone-14-pro-max-tim-thumb-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "iPhone 14 Pro",
                Description = "6.1\" Super Retina XDR, 128GB",
                Price = 600,
                Stock = 0,
                Image = "iphone-14-pro-(54).jpg"
            });
            products.Add(new Product()
            {
                Name = "Xiaomi Redmi 12",
                Description = "6.79\" Full HD+",
                Price = 370,
                Stock = 196,
                Image = "xiaomi-redmi-12-4gb-(2).jpg"
            });
            products.Add(new Product()
            {
                Name = "OPPO Find N2 Flip 5G",
                Description = "Chính 6.8\" & Phụ 3.26\", Full HD+",
                Price = 1000,
                Stock = 23,
                Image = "oppo-n2-flip-den-thumb-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "vivo Y36",
                Description = "6.64\", Full HD+, 128GB",
                Price = 420,
                Stock = 565,
                Image = "vivo-y36-xanh-thumbnew-600x600.jpg"
            });
            products.Add(new Product()
            {
                Name = "Samsung Galaxy A24",
                Description = "6.5\", Full HD+, 6GB",
                Price = 380,
                Stock = 343,
                Image = "vivo-y36-xanh-thumbnew-600x600.jpg"
            });
            double sumPrice = 0;
            double sumStock = 0;
            foreach (var item in products)
            {
                sumPrice += item.Price * item.Stock;
                sumStock += item.Stock;
            }
            ViewBag.sumPrice = sumPrice;
            ViewBag.sumStock = sumStock;
            return View(products);
        }

    }
}