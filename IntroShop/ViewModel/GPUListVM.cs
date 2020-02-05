using IntroShop.Main.Models;
using System.Collections.Generic;

namespace IntroShop.ViewModel
{
    public class GPUListVM
    {
        public IEnumerable<GPU> GPUs { get; set; }
        public string currentCategory { get; set; }
    }
}
