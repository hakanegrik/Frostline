using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrostlineECommerce.App.Business.Concrete;
using FrostlineECommerce.App.DataAccess.Repositories;
using FrostlineECommerce.App.Entitiy.Concrete;
using FrostlineECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;

namespace FrostlineECommerce.Controllers
{
    public class ProductController : Controller
    {
        ProductService product = new ProductService(new ProductRepository());
        PeriodService period = new PeriodService(new PeriodRepository());
        CategoryService category = new CategoryService(new CategoryRepository());
        DiscountService discount = new DiscountService(new DiscountRepository());


        public IActionResult Index()
        {
            ViewModel model = new ViewModel();

            model.Product = product.TGetAll();
            model.Period = period.TGetAll();


            return View(model);
        }


        public IActionResult Discount()
        {
            ViewModel model = new ViewModel();

            model.Discount = discount.TGetAll();

            return View(model);
        }

        public IActionResult CreateDiscount()
        {
            
            var model = new DiscountViewModel();


            List<SelectListItem> periods = new List<SelectListItem>();

            foreach (var item in period.TGetAll())
            {
                periods.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            List<SelectListItem> categories = new List<SelectListItem>();

            foreach (var item in category.TGetAll())
            {
                categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Periods = new SelectList(periods, "Value", "Text");
            ViewBag.Categories = new SelectList(categories, "Value", "Text");

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateDiscount(DiscountViewModel model)
        {
            var periodData = period.TGetById(model.PeriodId);
            var categoryData = category.TGetById(model.CategoryId);

            var requestModel = new Discount();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.PeriodName = periodData.Name;
            requestModel.PeriodId = model.PeriodId;
            requestModel.CategoryName = categoryData.Name;
            requestModel.CategoryId = model.CategoryId;
            requestModel.DiscountRate = model.DiscountRate;
            requestModel.StartDate = model.StartDate;
            requestModel.EndDate = model.EndDate;
            requestModel.IsActive = model.IsActive;

            discount.TAdd(requestModel);

            return RedirectToAction("Index");
        }


        public IActionResult DiscountProducts(int id)
        {
            ViewModel model = new ViewModel();

            var prodList = new List<Product>();
            var periodData = period.TGetById(id);

            var value = discount.TGetById(id);
            var producData = product.TGetAll();

            DateTime today = DateTime.Today;
            
            var discounData = discount.TGetAll().Where(x => x.PeriodId == id && x.StartDate <= today && x.EndDate >= today).ToList();


            foreach (var p in producData)
            {
                foreach (var d in discounData)
                {
                    if (d.CategoryId == p.CategoryId)
                    {
                        p.Price -= (p.Price * d.DiscountRate) / 100;
                        prodList.Add(p);
                    }
                }
            }

            model.Product = prodList;
            model.Period =period.TGetAll();
            ViewBag.PeriodId = id;
            ViewBag.PeriodName = period.TGetById(id).Name;
            return View(model);
        }


        public IActionResult PeriodDiscount(int id)
        {
            var discounData = discount.TGetAll().Where(x => x.PeriodId == id && x.StartDate <= DateTime.Today && x.EndDate >= DateTime.Today).ToList();
           
            var model = new List<DiscountViewModel>();

            foreach (var item in discounData)
            {
                var discountModel = new DiscountViewModel();

                discountModel.Name = item.Name;
                discountModel.Id = item.Id;
                discountModel.PeriodName = item.PeriodName;
                discountModel.PeriodId = item.PeriodId;
                discountModel.CategoryName = item.CategoryName;
                discountModel.CategoryId = item.CategoryId;
                discountModel.DiscountRate = item.DiscountRate;
                discountModel.StartDate = item.StartDate;
                discountModel.EndDate = item.EndDate;
                discountModel.IsActive = item.IsActive;

                model.Add(discountModel);
            }

            ViewBag.Period = period.TGetById(id).Name;
          
            return View(model);
        }

        

        public IActionResult EditDiscount(int id)
        {
            var discounData = discount.TGetById(id);
            var model = new DiscountViewModel();

            model.Name = discounData.Name;
            model.Id = discounData.Id;
            model.PeriodName = discounData.PeriodName;
            model.PeriodId = discounData.PeriodId;
            model.CategoryName = discounData.CategoryName;
            model.CategoryId = discounData.CategoryId;
            model.DiscountRate = discounData.DiscountRate;
            model.StartDate = discounData.StartDate;
            model.EndDate = discounData.EndDate;
            model.IsActive = discounData.IsActive;

   

            List<SelectListItem> periods = new List<SelectListItem>();

            foreach (var item in period.TGetAll())
            {
                periods.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            List<SelectListItem> categories = new List<SelectListItem>();

            foreach (var item in category.TGetAll())
            {
                categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Periods = new SelectList(periods, "Value", "Text");
            ViewBag.Categories = new SelectList(categories, "Value", "Text");

            return View(model);
        }

        [HttpPost]
        public ActionResult EditDiscount(DiscountViewModel model)
        {
            var discounData = discount.TGetById(model.Id);
            var periodData = period.TGetById(model.PeriodId);
            var categoryData = category.TGetById(model.CategoryId);

            discount.TDelete(discounData);

            var requestModel = new Discount();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.PeriodName = periodData.Name;
            requestModel.PeriodId = model.PeriodId;
            requestModel.CategoryName = categoryData.Name;
            requestModel.CategoryId = model.CategoryId;
            requestModel.DiscountRate = model.DiscountRate;
            requestModel.StartDate = model.StartDate;
            requestModel.EndDate = model.EndDate;
            requestModel.IsActive = model.IsActive;

            discount.TAdd(requestModel);

            return RedirectToAction("Index");
        }
    }
}
