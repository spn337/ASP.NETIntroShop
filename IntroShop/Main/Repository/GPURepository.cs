using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class GPURepository : IAllGPUs
    {
        private readonly DBContent dbContent;
        public GPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<GPU> GPUs => dbContent.GPUs;
    }
}
