using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class CPURepository : IAllCPUs
    {
        private readonly DBContent dbContent;
        public CPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<CPU> CPUs => dbContent.CPUs;
    }
}
