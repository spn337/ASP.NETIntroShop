using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class GPUController : Controller
    {
        private readonly IAllGPUs _allGPUs;
        public GPUController(IAllGPUs GPUs)
        {
            _allGPUs = GPUs;
        }
        public ViewResult List()
        {
            ViewBag.Title = "CPUs";
            GPUListVM obj = new GPUListVM();
            obj.GPUs = _allGPUs.GPUs;
            obj.currentCategory = "Best";

            return View(obj);
        }
    }
}
