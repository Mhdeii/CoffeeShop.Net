using MahalCoffee.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using MahalCoffee.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MahalCoffee_CSC400.Models;

namespace MahalCoffee.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> productList = await _unitOfWork.Product.GetAllAsync();
            return View(productList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
               
                await _unitOfWork.Product.AddAsync(product);
                await _unitOfWork.SaveAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ProductList()
        {
            return View();
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product productFromDb = await _unitOfWork.Product.GetAsync(u => u.ProductId == id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Product.UpdateAsync(product);
                await _unitOfWork.SaveAsync();

                await _unitOfWork.Product.RemoveAsync(product);
                await _unitOfWork.SaveAsync();

                TempData["success"] = "Category data updated successfully";
                return RedirectToAction("MenuViewModel", "MenuViewModel");
            }

            return View();
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product productFromDb = await _unitOfWork.Product.GetAsync(u => u.ProductId == id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }

        [HttpPost, ActionName("DeletePost")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Product product = await _unitOfWork.Product.GetAsync(u => u.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            _unitOfWork.Product.RemoveAsync(product);
            await _unitOfWork.SaveAsync();
            TempData["success"] = "Category data deleted successfully";

            return RedirectToAction("MenuViewModel", "MenuViewModel");
        }

    }
}
