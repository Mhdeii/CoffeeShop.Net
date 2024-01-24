using MahalCoffee.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using MahalCoffee.Models;


namespace MahalCoffee_CSC400.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Review review)
        {
               
                await _unitOfWork.Review.AddAsync(review);
                await _unitOfWork.SaveAsync();

            return RedirectToAction("Index");
        }
        



      
    }
}
