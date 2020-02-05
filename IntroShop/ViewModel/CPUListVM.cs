using IntroShop.Main.Models;
using System.Collections.Generic;

namespace IntroShop.ViewModel
{
    public class CPUListVM
    {
        public IEnumerable<CPU> CPUs { get; set; }
        public string currentCategory { get; set; }
    }
}
