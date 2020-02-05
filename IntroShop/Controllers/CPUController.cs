using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class CPUController : Controller
    {
        private readonly IAllCPUs _allCPUs;
        public CPUController(IAllCPUs CPUs)
        {
            _allCPUs = CPUs;
        }
        public ViewResult List()
        {
            ViewBag.Title = "CPUs";
            CPUListVM obj = new CPUListVM();
            obj.CPUs = _allCPUs.CPUs;
            obj.currentCategory = "Best";

            return View(obj);
        }
    }
}
