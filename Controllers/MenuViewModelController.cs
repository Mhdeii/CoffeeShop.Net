using Microsoft.AspNetCore.Mvc;
using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;
using MahalCoffee_CSC400.Models;

public class MenuViewModelController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public MenuViewModelController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> productList()
    {
        IEnumerable<Product> productList = await _unitOfWork.Product.GetAllAsync();

        MenuView menuViewModel = new MenuView
        {
            Products = productList.ToList()
        };

        return View(menuViewModel);
    }



    
    public async Task<IActionResult> MenuViewModel()
    {
        IEnumerable<Product> productList = await _unitOfWork.Product.GetAllAsync();
        return View(productList);
    }
}
