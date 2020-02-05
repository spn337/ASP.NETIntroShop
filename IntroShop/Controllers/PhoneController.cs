using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace IntroShop.Controllers 
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        //private readonly ICategories _allCategories;

        public PhoneController(IAllPhones phones /*ICategories phoneCategory*/)
        {
            _allPhones = phones;
            //_allCategories = phoneCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Phones";
            PhoneListVM obj = new PhoneListVM();
            obj.Phones = _allPhones.Phones;
            obj.currentCategory = "Best";

            return View(obj);
        }
    }
}
