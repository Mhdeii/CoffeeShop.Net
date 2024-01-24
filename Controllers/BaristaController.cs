using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahalCoffee.Controllers
{
    public class BaristaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaristaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Barista barista)
        {
            barista.AdminId = 1;
            await _unitOfWork.Barista.AddAsync(barista);
            await _unitOfWork.SaveAsync();

            return RedirectToAction("Profile");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Barista baristaFromDb = await _unitOfWork.Barista?.GetAsync(u => u.BaristaId == id);

            if (baristaFromDb == null)
            {
                return NotFound();
            }

            return View(baristaFromDb);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Barista barista)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Barista.UpdateAsync(barista);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "Category data updated successfully";
                return RedirectToAction("Profile");
            }

            return View();
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Barista baristaFromDb = await _unitOfWork.Barista.GetAsync(u => u.BaristaId == id);
            if (baristaFromDb == null)
            {
                return NotFound();
            }

            return View(baristaFromDb);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Barista barista = await _unitOfWork.Barista.GetAsync(u => u.BaristaId == id);
            if (barista == null)
            {
                return NotFound();
            }

            await _unitOfWork.Barista.RemoveAsync(barista);
            await _unitOfWork.SaveAsync();
            TempData["success"] = "Category data deleted successfully";
            return RedirectToAction("Profile");
        }

    }
}

