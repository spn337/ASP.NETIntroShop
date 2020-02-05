using IntroShop.Main.Models;
using System.Collections.Generic;

namespace IntroShop.ViewModel
{
    public class PhoneListVM
    {
        public IEnumerable<Phone> Phones { get; set; }
        public string currentCategory { get; set; }
    }
}
